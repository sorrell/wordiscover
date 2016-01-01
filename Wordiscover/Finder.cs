using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Word;
using SysRegex = System.Text.RegularExpressions;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Linq.Expressions;


namespace Wordiscover
{
    using OCDictionary = ObservableConcurrentDictionary<Word.Range, string>;
    public static class Finder
    {
        public static Task FindText(string searchKey, 
                                    bool searchKeyCaseSensitive,
                                    ObservableConcurrentDictionary<Word.Range, string> observableResults, 
                                    IProgress<int> progress,
                                    CancellationToken cancelToken,
                                    ProxSearchSettings prox = null)
        {
            return Task.Run(() =>
            {
                var paraVisitedCount = 0;
                var proxIsNull = (prox == null);
                int totalParaCount = DocumentHelpers.ActiveDocument.Paragraphs.Count;
                var pOpts = new ParallelOptions { CancellationToken = cancelToken };
                var sKeyRegOpts = searchKeyCaseSensitive ? SysRegex.RegexOptions.None : SysRegex.RegexOptions.IgnoreCase;
                var searchKeyRegex = proxIsNull
                                ? new SysRegex.Regex(searchKey, sKeyRegOpts)
                                : new SysRegex.Regex(searchKey + ".*?" + prox.SearchKey + "|" + prox.SearchKey + ".*?" + searchKey + "|" + searchKey, sKeyRegOpts);

                Parallel.ForEach(DocumentHelpers.GetParagraphsEnumerator(), 
                                 pOpts, 
                                 (currentParagraph, loopState, index) =>
                    {
                        // Catch this cancellation throw in the FindPane to update the pane/results
                        pOpts.CancellationToken.ThrowIfCancellationRequested();
                        var paraRange = ((Word.Paragraph)currentParagraph).Range;
                        
                        // Find all of the single Find matches
                        if (proxIsNull)
                        {
                            FinderHelpers.DoFind(searchKeyRegex.Match(paraRange.Text),
                                                 paraRange.Start,
                                                 paraRange.End,
                                                 observableResults);
                        }

                        #region Proximity Matching
                        // Proximity matching
                        
                        else
                        {
                            // If we are doing interparagraph matching, let's make sure we don't
                            // try to access a paragraph out of bounds
                            if (prox.ParaProximity)
                            {
                                int lookaheadPosition = (int)index + prox.ParaThreshold;
                                int topRange = (lookaheadPosition > totalParaCount)
                                    ? totalParaCount
                                    : lookaheadPosition;
                                //Debug.WriteLine("LAP: " + lookaheadPosition.ToString() +
                                //                "Total: " + totalParaCount.ToString() +
                                //                "topRng: " + topRange.ToString());
                                paraRange.End = prox.ParaEndingRanges[topRange - 1];
                            }

                            IEnumerable<SysRegex.Match> matches = null;
                            if (paraRange.Text != null)
                            {
                                if (!prox.LogicalNot)
                                {

                                    searchKeyRegex = new SysRegex.Regex(searchKey + ".*?" + prox.SearchKey, sKeyRegOpts);
                                    var proxKeyRegex = new SysRegex.Regex(prox.SearchKey + ".*?" + searchKey, sKeyRegOpts);


                                    var skMatches = searchKeyRegex.Matches(paraRange.Text);
                                    var pkMatches = proxKeyRegex.Matches(paraRange.Text);
                                    matches = skMatches.OfType<SysRegex.Match>()
                                                .Concat(pkMatches.OfType<SysRegex.Match>())
                                                .Where(m => m.Success);

                                }

                                else
                                {
                                    // why didn't we do this in the assignment of matches and let the if statement
                                    // override its value?  imagine all of the wasted ops this call does
                                    // if its not needed!
                                    matches = searchKeyRegex.Matches(paraRange.Text).OfType<SysRegex.Match>();
                                }

                                FinderHelpers.DoFindProximity(matches,
                                                              paraRange.Start,
                                                              paraRange.End,
                                                              new SysRegex.Regex(searchKey, sKeyRegOpts),
                                                              prox,
                                                              observableResults);
                            }
                        }
                        #endregion Proximity Matching

                        // Report back our progress
                        progress.Report(++paraVisitedCount);
                    });
            }, cancelToken);
        }

    }
}
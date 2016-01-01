// -------------------------------------------------------------------------
// 
//  FinderHelpers are where all of the find/prox/replace logic takes place.
//
//  Regular Find relies on DoFind.
//  Proximity Find relies on DoFindProx.
//  Replace - let's thank the standard library for that one...
//  
// -------------------------------------------------------------------------

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

namespace Wordiscover
{
    using OCDictionary = ObservableConcurrentDictionary<Word.Range, string>;
    public static class FinderHelpers
    {
        /// <summary>
        /// DoFind is the helper for a regular Find (no proximity).  Very simple logic:
        /// Given a Regex Match, it will iterate through the match adding matches to 
        /// the OberservableConcurrentDictionary
        /// </summary>
        /// <param name="match">The regex match based on the Find box text value</param>
        /// <param name="startRange">The Paragraph's start range - we need this for highlighting</param>
        /// <param name="endRange">The Paragraph's end range - we need this for highlighting</param>
        /// <param name="observableResults">The concurrent dictionary we are writing results to</param>
        public static void DoFind(SysRegex.Match match,
                                    int startRange,
                                    int endRange,
                                    OCDictionary observableResults)
        {
            while (match.Success)
            {
                // get actual match start and end range locations
                var beginRangeMatch = startRange + match.Index;
                var endRangeMatch = beginRangeMatch + match.Length;

                // get some context for the match
                var beginContext = beginRangeMatch >= 5 ? (beginRangeMatch - 5) : beginRangeMatch;
                var endContext = (endRangeMatch + 5) < endRange ? (endRangeMatch + 5) : endRange;
                FinderHelpers.AddResults(beginRangeMatch, endRangeMatch, beginContext, endContext, observableResults);

                match = match.NextMatch();
            }
        }

        /// <summary>
        /// DoFindProximity takes matches and decides if they are truly proximity based on
        ///  1. Stripping the match of special characters and extra whitespace
        ///  2. Splitting the match into a list based on whitespace
        /// Once we have a list, we can just walk through the X proximity words to see if a match
        /// exists.  This means you can't search for a word within X words of a hyphen.
        /// </summary>
        /// <param name="matches">Enumberable list of possible matches</param>
        /// <param name="startRange">The Paragraph's start range - we need this for highlighting</param>
        /// <param name="endRange">The Paragraph's end range - we need this for highlighting</param>
        /// <param name="searchKeyRegex">SearchKey</param>
        /// <param name="prox">Prox object, to tell us ProxRegKey, proximity, case sensitive, etc</param>
        /// <param name="observableResults">The concurrent dictionary we are writing results to</param>
        public static void DoFindProximity(IEnumerable<SysRegex.Match> matches,
                                            int startRange,
                                            int endRange,
                                            SysRegex.Regex searchKeyRegex,
                                            ProxSearchSettings prox,
                                            OCDictionary observableResults)
        {

            foreach (var match in matches)
            {
                //  so if our searchKey is "this " and the proxKey is "search", we will match the following with threshold = 5
                //  1. this sentence represents a search string that has a hit
                //      Match:  this.*search
                //  2. search string in this sentence
                //      Match:  search.*this

                //  first lets find our search key
                var searchKeyMatch = searchKeyRegex.Match(match.Value);

                while (searchKeyMatch.Success)
                {
                    var pKeyRegOpts = prox.CaseSensitive ? SysRegex.RegexOptions.None : SysRegex.RegexOptions.IgnoreCase;
                    var proximityKeyRegex = new SysRegex.Regex(prox.SearchKey, pKeyRegOpts);
                    var searchKeyMatchEndpoint = searchKeyMatch.Index + searchKeyMatch.Length;

                    //  so if our searchKey is "this " and the proxKey is "search", with a threshold = 5
                    //
                    //  1. this sentence represents a search string that has a hit
                    //     |   ||                     |    |       |
                    //      \ /  \                     \  /       /
                    //  searchKey \                  proxKey     /
                    //             \________afterWords__________/
                    //
                    //  2. search string in this sentence
                    //    ||    |          ||   ||       |
                    //    | \  /           | \ / |       |
                    //    | proxKey        |searchKey    |
                    //    \               /       \     /
                    //     \_beforeWords_/       afterWords

                    string beforeWords = FinderHelpers.GetProximityWords(match.Value.Substring(0, searchKeyMatch.Index), prox.WordThreshold, true);
                    string afterWords = FinderHelpers.GetProximityWords(match.Value.Substring(searchKeyMatchEndpoint), prox.WordThreshold, false);

                    var beforeMatch = proximityKeyRegex.Match(beforeWords);
                    var afterMatch = proximityKeyRegex.Match(afterWords);

                    var successPredicate = prox.LogicalNot
                                           ? (!beforeMatch.Success && !afterMatch.Success)
                                           : (beforeMatch.Success || afterMatch.Success);

                    while (successPredicate)
                    {
                        // Find where the match starts - before or after search key
                        int matchIndex = beforeMatch.Success
                            ? ((beforeWords.Length - beforeMatch.Index + 2) * -1)
                            : afterMatch.Success
                              ? afterMatch.Index + afterMatch.Length + 3
                              : 0;

                        int searchKeyIndex = startRange + match.Index + searchKeyMatch.Index;
                        int proxKeyIndex = searchKeyIndex + matchIndex;
                        int startIndex = searchKeyIndex < proxKeyIndex ? searchKeyIndex : proxKeyIndex;
                        int endIndex = searchKeyIndex > proxKeyIndex ? searchKeyIndex : proxKeyIndex;

                        FinderHelpers.AddResults(startIndex, endIndex + searchKeyMatch.Length, observableResults);

                        // So, if we are searching IN proximity, then let's get all matches IN proximity
                        // both the before matches, AND the after matches
                        if (!prox.LogicalNot)
                        {
                            beforeMatch = beforeMatch.NextMatch();
                            afterMatch = afterMatch.NextMatch();
                            successPredicate = (beforeMatch.Success || afterMatch.Success);
                        }
                        // Otherwise, we found a match that is NOT in proximity (before/after) of the search word, 
                        // so let's take it and break out of the loop (no need to search further...)
                        else break;
                    }
                    searchKeyMatch = searchKeyMatch.NextMatch();
                }
            }
        }


        public static void AddResults(int beginRangeMatch,
                                      int endRangeMatch,
                                      OCDictionary dict)
        {
            AddResults(beginRangeMatch, endRangeMatch, -1, -1, dict);
        }
        public static void AddResults(int beginRangeMatch,
                                      int endRangeMatch,
                                      int beginContext,
                                      int endContext,
                                      OCDictionary dict)
        {
            var rng = DocumentHelpers.GetRange(beginRangeMatch, endRangeMatch);
            var isProxSearch = (beginContext != -1) && (endContext != -1); 
            var matchWords = isProxSearch
                             ? DocumentHelpers.GetRange(beginContext, endContext).Text
                             : rng.Text;
            dict.Add(rng, matchWords);
        }

        /// <summary>
        /// This function is intended to be called once a match has been found, and now the
        /// caller wants to the pre/succeeding <proxThreshold> number of words.
        /// </summary>
        /// <param name="words">The matches before/after string</param>
        /// <param name="proxThreshold">The (int)proximity to search within</param>
        /// <param name="beforeWords">This bool tells us if we're passing words before the match, or after the match</param>
        /// <returns></returns>
        public static string GetProximityWords(string words,
                                              int proxThreshold,
                                              bool beforeWords)
        {
            var wordlist = StripWhiteSpaceAndSpecialChars(words);
            Func<string, int, bool> predicate = beforeWords
                                                ? (Func<string, int, bool>)
                                                  ((word, wordIndex) => wordIndex > (wordlist.Count - proxThreshold - 1))
                                                : (word, wordIndex) => wordIndex < proxThreshold;
            return String.Join(" ", wordlist
                                     .Select((word) => word)
                                     .Where(predicate));
        }

        /// <summary>
        /// Get rid of extraneous whitespace and non-word characters
        /// </summary>
        /// <param name="str">The string to clean</param>
        /// <returns></returns>
        public static List<string> StripWhiteSpaceAndSpecialChars(string str)
        {
            var pattern = @"\W\s+|\s{2,}";
            var patternRegex = new SysRegex.Regex(pattern);
            var match = patternRegex.Match(str);
            while (match.Success)
            {
                str = SysRegex.Regex.Replace(str, pattern, " ");
                match = match.NextMatch();
            }
            
            return str.Trim().Split(null).ToList();
        }

        /// <summary>
        /// Simple Regex replace
        /// </summary>
        /// <param name="rng"></param>
        /// <param name="searchKey"></param>
        /// <param name="replaceKey"></param>
        public static void ReplaceText(Word.Range rng, string searchKey, string replaceKey)
        {
            SysRegex.Regex patternRegex = new SysRegex.Regex(searchKey);
            rng.Text = patternRegex.Replace(rng.Text, replaceKey);
        }
    }
}

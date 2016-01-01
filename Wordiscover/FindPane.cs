using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using Office = Microsoft.Office.Core;
using System.Collections.Concurrent;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Wordiscover.Properties;

namespace Wordiscover
{
    public partial class FindPane : Cintio.PanelScrollControl.PanelScrollControl
    {
        // We use the syncContext avoid cross thread exceptions when updating the UI
        private readonly SynchronizationContext _syncContext;
        
        // A simple concurrent dictionary to store the results
        ObservableConcurrentDictionary<Word.Range, string> _observableResults;

        // We are displaying a list of resultNumber|resultText - this map gives us
        // the ability to jump to that location in the text when selected
        Dictionary<int, Word.Range> _resultMap;

        // We don't want to add duplicate Word.Range results - but we find dupes when
        // doing concurrent proximity searches.  This list ensures the user never notices
        HashSet<string> _hashList;

        // This object is used for proximity searching
        ProxSearchSettings _prox;

        // Give the user an idea of how long this search is taking!
        Stopwatch _stopwatch;

        // If the user cancels a search, we use send this token down the chain
        // to our current async calls
        CancellationTokenSource _cts;

        // Give the user an idea of how far along in the search we are
        Progress<int> _progressIndicator;

        // We need to know if the document has changes for proximity searching
        // This is because, to perform the prox search, we grab paragraph
        // ending locations (to speed up search) - so if these change, we need to know
        public bool DocumentHasChanges { get; set; }

        private const string HelpText = "Enter search term or expression here!";

        int _numResults = 0;
        int _paraCount = 0;

        private delegate void UpdateUiDelegate ();

        public FindPane()
        { 
            InitializeComponent();
            _syncContext = SynchronizationContext.Current;
            _prox = new ProxSearchSettings();
            ToggleProximityComponents();
            labelPercent.Text = "";
            labelTimer.Text = "";
            panelProxComponents.Visible = false;
            panelReplaceComponents.Visible = false;
            SetPanelScrollState();
            DocumentHasChanges = false;
        }

        private void RefreshListView()
        {
            listResults.Clear();
            listResults.View = View.Details;
            listResults.Columns.Add("#", 25, HorizontalAlignment.Left);
            listResults.Columns.Add("Text", 130, HorizontalAlignment.Left);
        }

        /// <summary>
        /// Async method to get results from the doc
        /// </summary>
        private async void GetObservableResults()
        {
            var searchKey = tbSearchKey.Text;
            var cancelled = false;

            UpdateStatuses(0);

            try
            {
                UpdateUi(() => { btnFind.Text = Resources.Cancel; });
                
                await Finder.FindText(searchKey,
                    cbCaseSearchKey.Checked,
                    _observableResults,
                    _progressIndicator,
                    _cts.Token,
                    _prox);
                

            }
            catch (OperationCanceledException)
            {
                cancelled = true;
            }

            finally
            {
                _stopwatch.Stop();
                UpdateStatuses(_paraCount); //100%
                UpdateUi(() => 
                { 
                    btnFind.Text = Resources.Find;
                    if (cancelled)
                        labelTimer.Text += Environment.NewLine + Resources.SearchCancelled;
                });
            }
            

        }

        /// <summary>
        /// This event is added to every new ObservableResults obj we create
        /// and we use it to add items to the listbox when we find results
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddedNewResult(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
                if (e.NewItems != null)
                    foreach (KeyValuePair<Word.Range, string> item in e.NewItems)
                    {
                        AddNewResultsToListbox(item);
                        // Keep the observableResults concurrent dict lean by removing
                        // the current item
                        _observableResults.Remove(item.Key);
                    }
        }


        private void UpdateUi(UpdateUiDelegate d, object state = null)
        {
            _syncContext.Post(o =>
            {
                d();
            }, state);
        }

        /// <summary>
        /// Update the progress bar, progess label, and timer label
        /// </summary>
        /// <param name="newVal">How many paragraphs we've searched</param>
        private void UpdateStatuses(int newVal)
        {
            UpdateUi(() => 
            {
                progressBar.Value = newVal;
                double progress = (newVal * 1.0 / _paraCount) * 100;
                labelPercent.Text = ((int)progress).ToString() + @"%";
                labelTimer.Text = _resultMap.Count.ToString() + 
                                  Resources.results_in + 
                                  String.Format("{0:00}:{1:00}", 
                                  _stopwatch.Elapsed.Minutes, 
                                  _stopwatch.Elapsed.Seconds);
            });
        }

        /// <summary>
        /// We compute the MD5 hash of the result, and if it's not a match in our hashlist
        /// we add the result to the listbox for the user's enjoyment
        /// </summary>
        /// <param name="kvp"></param>
        private void AddNewResultsToListbox(KeyValuePair<Word.Range, string> kvp)
        {
            // We need to calculate the hash of the Range because we create and return new Range objects
            // when we find matches.  This range could be duplicate, especially if someone is using the
            // interparagraph feature and searching 6 paragraphs ahead.  If the match is between paras 4 and 5,
            // then each Parallel.Foreach(1,2,3) will find those too and return them.
            // Sadly, the Word.Range *object* is new and not equal to an already returned Word.Range object
            // that, in fact, contains the same range.  Maddening, right? :)
            string hash = "";
            string txt = "";
            using (MD5 md5 = MD5.Create())
            {
                txt = kvp.Key.Text + kvp.Key.Start.ToString() + kvp.Key.End.ToString();
                hash = BitConverter.ToString(
                  md5.ComputeHash(Encoding.UTF8.GetBytes(kvp.Key.Text + kvp.Key.Start.ToString() + kvp.Key.End.ToString()))
                ).Replace("-", String.Empty);
            }
            if (_hashList.Add(hash))
            {
                UpdateUi(() =>
                {
                    ListViewItem listitem = new ListViewItem((++_numResults).ToString());
                    listitem.SubItems.Add(kvp.Value);
                    listResults.Items.Add(listitem);
                    _resultMap.Add(_numResults, kvp.Key);
                });
            }
        }

        /// <summary>
        /// If the textbox is null/whitespace or has the help text, we retreat
        /// </summary>
        /// <param name="ctrl"></param>
        /// <returns></returns>
        private bool ControlHasInvalidText(Control ctrl)
        {
            return (String.IsNullOrWhiteSpace(ctrl.Text) || ctrl.Text.Equals(HelpText));
        }

        /// <summary>
        /// Make all new objects, restarts our stopwatch, starts search
        /// </summary>
        private void ExecuteSearch()
        {
            _numResults = 0;
            RefreshListView();
            progressBar.Maximum = _paraCount = DocumentHelpers.ActiveDocument.Paragraphs.Count;
            _cts = new CancellationTokenSource();
            _observableResults = new ObservableConcurrentDictionary<Word.Range, string>();
            _resultMap = new Dictionary<int, Word.Range>();
            _hashList = new HashSet<string>();
            _observableResults.CollectionChanged += AddedNewResult;
            _progressIndicator = new Progress<int>(UpdateStatuses);
            SetProxObject();
            if (DocumentHasChanges && (_prox != null))
                GetParagraphMarkers();

            _stopwatch = new Stopwatch();
            _stopwatch.Start();
            UpdateStatuses(0);
            GetObservableResults();
        }

        /// <summary>
        /// Simply package everything the user told us about the proximity
        /// search so we can send it along to the search method
        /// </summary>
        private void SetProxObject()
        {
            if (cbProximity.Checked)
            {
                _prox.SearchKey = tbProxKey.Text;
                _prox.WordThreshold = (int)numericWithin.Value;
                _prox.ParaThreshold = (int)numericParagraphs.Value;
                _prox.CaseSensitive = cbCaseProxKey.Checked;
                _prox.LogicalNot = cbNot.Checked;
                _prox.ParaProximity = cbInterpara.Checked;
            }
            else
                _prox = null;
        }

        private void FindPane_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnFind_Click(sender, e);
        }



        

       

 

       

        

    }
}

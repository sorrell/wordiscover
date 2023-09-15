using System.Collections.Generic;
using Word = Microsoft.Office.Interop.Word;
using System.Windows.Forms;
using Microsoft.Office.Tools;

namespace Wordiscover
{
    public partial class ThisAddIn
    {
        CustomTaskPane myCustomTaskPane;
        FindPane findPane;
        Dictionary<Word.Document, CustomTaskPane> docToPaneMapping;

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            docToPaneMapping = new Dictionary<Word.Document, CustomTaskPane>();

            foreach (Word.Document doc in this.Application.Documents)
            {
                HandleDocMapping(doc);
            }
            //foreach (Word.ProtectedViewWindow pvw in this.Application.ProtectedViewWindows)
            //{
            //    HandleDocMapping(pvw.Document);
            //}
            this.Application.DocumentBeforeClose += new Word.ApplicationEvents4_DocumentBeforeCloseEventHandler(ClosePaneOnDocClose);
            this.Application.DocumentChange += new Word.ApplicationEvents4_DocumentChangeEventHandler(DocHasChanges);
            this.Application.DocumentOpen += new Word.ApplicationEvents4_DocumentOpenEventHandler(DocLoaded);
            //this.Application.ProtectedViewWindowOpen += new Word.ApplicationEvents4_ProtectedViewWindowOpenEventHandler(ProtectedWindowOpened);
        }

        private void DocLoaded(Word.Document Doc)
        {
            HandleDocMapping(DocumentHelpers.ActiveDocument);
            myCustomTaskPane.Visible = true;
            findPane.GetParagraphMarkers();
            findPane.DocumentHasChanges = false;
        }

        private void ProtectedWindowOpened(Word.ProtectedViewWindow PvWn)
        {
            HandleDocMapping(DocumentHelpers.ActiveDocument);
            myCustomTaskPane.Visible = true;
            findPane.GetParagraphMarkers();
            findPane.DocumentHasChanges = false;
        }

        private void HandleDocMapping(Word.Document doc)
        {
            if (!docToPaneMapping.ContainsKey(doc))
            {
                findPane = new FindPane();
                CustomTaskPane ctp = this.CustomTaskPanes.Add(findPane, "Wordiscover", doc.Windows[1]);
                docToPaneMapping[doc] = ctp;
            }
            myCustomTaskPane = docToPaneMapping[doc];
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        private void DocHasChanges()
        {
            if (findPane != null)
                findPane.DocumentHasChanges = true;
        }

        private void ClosePaneOnDocClose(Word.Document Doc, ref bool b)
        {
            if (docToPaneMapping.ContainsKey(DocumentHelpers.ActiveDocument))
            {
                CustomTaskPane ctp = docToPaneMapping[DocumentHelpers.ActiveDocument];
                this.CustomTaskPanes.Remove(ctp);
                docToPaneMapping.Remove(DocumentHelpers.ActiveDocument);
            }
        }
        public void ToggleFindPane()
        {
            if (this.Application.ActiveProtectedViewWindow != null)
            {
                MessageBox.Show("You must have a document open and in EDIT mode (not Protected View) to use Wordiscover.", "Wordiscover Requirements", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                myCustomTaskPane.Visible = !myCustomTaskPane.Visible;
            }
                
        }


        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }

        #endregion
    }
}

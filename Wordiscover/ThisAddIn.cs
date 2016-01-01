using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Word = Microsoft.Office.Interop.Word;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Word;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Microsoft.Office.Tools;
using System.Runtime.InteropServices;

namespace Wordiscover
{
    public partial class ThisAddIn
    {
        CustomTaskPane myCustomTaskPane;
        FindPane findPane;

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            findPane = new FindPane();
            myCustomTaskPane = this.CustomTaskPanes.Add(findPane, "Wordiscover");
            
            this.Application.DocumentBeforeClose += new Word.ApplicationEvents4_DocumentBeforeCloseEventHandler(ClosePaneOnDocClose);
            this.Application.DocumentChange += new Word.ApplicationEvents4_DocumentChangeEventHandler(DocHasChanges);
            this.Application.DocumentOpen += new Word.ApplicationEvents4_DocumentOpenEventHandler(DocLoaded);
        }

        private void DocLoaded(Word.Document Doc)
        {
            findPane.GetParagraphMarkers();
            findPane.DocumentHasChanges = false;
        }


        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        private void DocHasChanges()
        {
            findPane.DocumentHasChanges = true;
        }

        private void ClosePaneOnDocClose(Word.Document Doc, ref bool b)
        {
            if (myCustomTaskPane.Visible)
                myCustomTaskPane.Visible = false;
        }
        public void ToggleFindPane()
        {
            if (this.Application.ActiveDocument != null)
                myCustomTaskPane.Visible = !myCustomTaskPane.Visible;
            else
                MessageBox.Show("You must have a document open to use Wordiscover.");
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using WordNS = Microsoft.Office.Interop.Word;


namespace Wordiscover
{
    public partial class WordiscoverRibbon
    {
        private void Ribbon_Load(object sender, RibbonUIEventArgs e)
        {
            showPane.Label = "Show/Hide" + Environment.NewLine + "Search Pane";
        }       

        private void showPane_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.ToggleFindPane();
        }

        private void buttonAbout_Click(object sender, RibbonControlEventArgs e)
        {
            AboutBox about = new AboutBox();
            about.ShowDialog();
        }

    }
}

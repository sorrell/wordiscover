using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wordiscover
{
    public partial class FindPane
    {
        private void CopyResultsData(bool copyAll, bool copyNums)
        {
            var copyText = "";

            // Copy all
            if (copyAll && (listResults.Items.Count > 0))
            {
                foreach (ListViewItem item in listResults.Items)
                {
                    if (copyNums)
                        copyText += item.SubItems[0].Text + "\t";
                    copyText += item.SubItems[1].Text + Environment.NewLine;
                }

            }

            // Single copy
            else if (listResults.SelectedItems.Count > 0)
            {
                if (copyNums)
                    copyText += listResults.SelectedItems[0].SubItems[0].Text + "\t";
                copyText += listResults.SelectedItems[0].SubItems[1].Text;
            }

            Clipboard.SetText(copyText);
        }
        private void copyRow_Click(object sender, EventArgs e)
        {
            CopyResultsData(false, false);
        }

        private void copyAll_Click(object sender, EventArgs e)
        {
            CopyResultsData(true, false);
        }

        private void copyRowNum_Click(object sender, EventArgs e)
        {
            CopyResultsData(false, true);
        }

        private void copyAllNums_Click(object sender, EventArgs e)
        {
            CopyResultsData(true, true);
        }

        private void finderFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialogFind.ShowDialog();
            tbSearchKey.Font = tbProxKey.Font 
                             = tbReplaceKey.Font
                             = listResults.Font
                             = fontDialogFind.Font;
        }
    }
}

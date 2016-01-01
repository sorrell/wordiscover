using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wordiscover.Properties;

namespace Wordiscover
{
    public partial class FindPane
    {
        private void buttonReplace_Click(object sender, EventArgs e)
        {
            var key = int.Parse(listResults.SelectedItems[0].SubItems[0].Text);
            Microsoft.Office.Interop.Word.Range selRng = listResults.SelectedItems.Count != 0 ? _resultMap[key] : null;
            if (selRng != null)
                FinderHelpers.ReplaceText(selRng, tbSearchKey.Text, tbReplaceKey.Text);
        }

        private void buttonReplaceAll_Click(object sender, EventArgs e)
        {
            foreach (var result in _resultMap)
            {
                FinderHelpers.ReplaceText(result.Value, tbSearchKey.Text, tbReplaceKey.Text);
            }
        }

        private void buttonReplaceOpenClose_Click(object sender, EventArgs e)
        {
            ReplaceShowHide();
        }

        private void ReplaceShowHide()
        {
            panelReplaceComponents.Visible = !panelReplaceComponents.Visible;
            buttonReplaceOpenClose.Image = panelReplaceComponents.Visible ?
                                        Resources.arrowOpen :
                                        Resources.arrowClosed;
            this.ToggleButtons();
        }

        private void labelReplace_Click(object sender, EventArgs e)
        {
            ReplaceShowHide();
        }
    }
}

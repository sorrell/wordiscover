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
        private void buttonResultsOpenClose_Click(object sender, EventArgs e)
        {
            ResultsShowHide();
        }
        private void ResultsShowHide()
        {
            panelResultsComponents.Visible = !panelResultsComponents.Visible;
            buttonResultsOpenClose.Image = panelResultsComponents.Visible ?
                                           Resources.arrowOpen :
                                           Resources.arrowClosed;
            this.ToggleButtons();
        }
        private void listResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listResults.SelectedItems.Count != 0)
            {
                var item = this.listResults.SelectedItems[0];
                var key = int.Parse(item.SubItems[0].Text);
                var selRng = _resultMap[key];
                selRng.Select();
            }
        }

        private void labelResults_Click(object sender, EventArgs e)
        {
            ResultsShowHide();
        }
    }
}

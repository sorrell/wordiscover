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
        private void btnFind_Click(object sender, EventArgs e)
        {
            if (btnFind.Text.Equals(Resources.Find))
            {
                if (ControlHasInvalidText(tbSearchKey))
                {
                    tbSearchKey.Text = HelpText;
                }
                else
                {
                    if (cbProximity.Checked && ControlHasInvalidText(tbProxKey))
                    {
                        tbProxKey.Text = HelpText;
                    }
                    else
                        ExecuteSearch();
                }
            }
            else if (_cts != null)
                _cts.Cancel();
        }

        private void FindShowHide()
        {
            panelFindComponents.Visible = !panelFindComponents.Visible;
            buttonFindOpenClose.Image = panelFindComponents.Visible ?
                                        Resources.arrowOpen :
                                        Resources.arrowClosed;
            this.ToggleButtons();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            tbSearchKey.Text = "";
        }

        private void buttonFindOpenClose_Click(object sender, EventArgs e)
        {
            FindShowHide();
        }

        private void labelFind_Click(object sender, EventArgs e)
        {
            FindShowHide();
        }
    }
}

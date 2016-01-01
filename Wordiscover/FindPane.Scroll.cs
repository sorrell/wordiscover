using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wordiscover
{

    public partial class FindPane
    {
        private void SetPanelScrollState()
        {
            PanelContainer = panelAll;
            BottomControl = panelResultsAll;
            TopControl = panelFindAll;
            TopHeightMargin = menuStrip1.Height;
            ScrollSpeed = 1;
        }

        protected override bool BottomPredicateCheck()
        {
            return panelResultsComponents.Visible;
        }

        protected override void ToggleButtons()
        {   
            var topPosition = PointToClient(TopControl.PointToScreen(Point.Empty));
            _btnScrollUp.Visible = (GetVerticalScrollPosition() > 1);

            BottomControl = BottomPredicateCheck() ? (Control)progressBar : panelResultsLabel;
            var bottomPosition = PointToClient(BottomControl.PointToScreen(Point.Empty));
            _btnScrollDown.Visible = (bottomPosition.Y + BottomControl.Height) > this.ClientSize.Height;
        }
    }
}

   

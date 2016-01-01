using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;
using Wordiscover.Properties;
using System.ComponentModel;
using System.Diagnostics;


namespace Wordiscover
{

    public partial class FindPane
    {

        public void GetParagraphMarkers()
        {
            _prox.ParaEndingRanges = new List<int>();
            Parallel.ForEach(DocumentHelpers.GetParagraphsEnumerator(), (currentParagraph, loopState, index) =>
            {
                _prox.ParaEndingRanges.Add(((Word.Paragraph)currentParagraph).Range.End);
            });
            Debug.WriteLine(_prox.ParaEndingRanges.Count);
        }



        private void buttonProximityOpenClose_Click(object sender, EventArgs e)
        {
            ProxSearchShowHide();
        }

        private void labelProximity_Click(object sender, EventArgs e)
        {
            ProxSearchShowHide();
        }
        private void cbProximity_CheckedChanged(object sender, EventArgs e)
        {
            ToggleProximityComponents();
            cbInterpara.Checked = false;

            if (cbProximity.Checked)
                _prox = new ProxSearchSettings();
            else
                _prox = null;
        }

        private void ProxSearchShowHide()
        {
            panelProxComponents.Visible = !panelProxComponents.Visible;
            buttonProxOpenClose.Image = panelProxComponents.Visible ?
                                           Resources.arrowOpen :
                                           Resources.arrowClosed;
            this.ToggleButtons();
        }

        private void ToggleProximityComponents()
        {
            var textColor = cbProximity.Checked ? Color.Black : Color.Gray;

            cbProximity.ForeColor = cbCaseProxKey.ForeColor
                                    = cbNot.ForeColor
                                    = textColor;
            numericWithin.Enabled = tbProxKey.Enabled
                                    = cbNot.Enabled
                                    = cbCaseProxKey.Enabled
                                    = numericParagraphs.Enabled
                                    = cbInterpara.Enabled
                                    = cbProximity.Checked;
        }
    }
}

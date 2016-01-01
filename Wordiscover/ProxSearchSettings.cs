// -------------------------------------------------------------------------
// 
//  ProxSearchSettings are just that - all of the user's settings from the UI
// 
// -------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordiscover
{
    public class ProxSearchSettings
    {
        public string SearchKey { get; set; }
        public bool CaseSensitive { get; set; }
        public bool LogicalNot { get; set; }
        public bool ParaProximity { get; set; }
        public int WordThreshold { get; set; }
        public int ParaThreshold { get; set; }
        public List<int> ParaEndingRanges { get; set; }

        public ProxSearchSettings()
        {
            ParaEndingRanges = new List<int>();
            CaseSensitive = false;
            LogicalNot = false;
            ParaProximity = false;
            WordThreshold = 1;
            ParaThreshold = 2;
            SearchKey = "";
        }

        public ProxSearchSettings(
            string searchKey,
            bool caseSensitive,
            bool logicalNot,
            bool paraProximity,
            int wordThreshold,
            int paraThreshold,
            List<int> paraRanges )
        {
            SearchKey = searchKey;
            CaseSensitive = caseSensitive;
            LogicalNot = logicalNot;
            ParaProximity = paraProximity;
            WordThreshold = wordThreshold;
            ParaThreshold = paraThreshold;
            ParaEndingRanges = paraRanges;
        }
    }
}

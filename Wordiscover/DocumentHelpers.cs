// -------------------------------------------------------------------------
// 
//  DocumentHelpers are calls made into the ActiveDocument
// 
// -------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;

namespace Wordiscover
{
    public static class DocumentHelpers 
    {
        static DocumentHelpers()
        {
            ActiveDocument = Globals.ThisAddIn.Application.ActiveDocument;
        }
        private static Word.Document _activeDocument;
        public static Word.Document ActiveDocument 
        {
            get 
            {
                _activeDocument = Globals.ThisAddIn.Application.ActiveDocument; 
                return _activeDocument;
            }
            set { _activeDocument = value; } 
        }

        public static Word.Range GetRange(int start, int end)
        {
            return ActiveDocument.Range(start, end);
        }

        public static IEnumerable<object> GetParagraphsEnumerator()
        {
            return ActiveDocument.Paragraphs.Cast<object>();
        }

        public static int GetParagraphsCount()
        {
            return ActiveDocument.Paragraphs.Count;
        }
    }
}

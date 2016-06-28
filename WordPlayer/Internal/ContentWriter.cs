using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Word;

namespace WordPlayer.Internal
{
    public class ContentWriter
    {

        public static ThisAddIn ThisAddIn;

        public static void WriteQuote(string arg)
        {
            var start = ThisAddIn.Application.ActiveDocument.Content.Start;
            var end = ThisAddIn.Application.ActiveDocument.Content.End;
            var rng = ThisAddIn.Application.ActiveDocument.Range(start, end);
            rng.Text = rng.Text + arg + " \v\v\t";
            object oMissing = System.Reflection.Missing.Value;
            object oEoF = WdUnits.wdStory;
            ThisAddIn.Application.ActiveWindow.Selection.EndKey(ref oEoF, ref oMissing);
        }

    }
}

﻿using Microsoft.Office.Interop.Word;
using WordPlayer.Utils;

namespace WordPlayer
{
    public partial class ThisAddIn
    {

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            InterceptKeys.SetHook();
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
            InterceptKeys.ReleaseHook();
            WordPlayer.close();
        }


        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}

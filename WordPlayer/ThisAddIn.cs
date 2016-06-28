using System.Resources;
using Microsoft.Office.Interop.Word;
using WordPlayer.Internal;
using WordPlayer.Utils;

namespace WordPlayer
{
    public partial class ThisAddIn
    {

        private WordPlayer _wordPlayer;
        
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            _wordPlayer = Globals.Ribbons.WordPlayer;
            ContentWriter.ThisAddIn = this;
            
        }

        public void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
            _wordPlayer.Close();
            
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

using System;
using System.Windows.Forms;

namespace WordPlayer.Gui
{
    public partial class HelpMenu : Form
    {
        public HelpMenu()
        {
            InitializeComponent();
            var content = Properties.Resources.HelpContent;
            rickTxtBox_about.Text = content;
        }

        private void rickTxtBox_about_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}

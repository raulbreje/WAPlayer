using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordPlayer.Gui
{
    public partial class WAControl : UserControl
    {
        public WAControl()
        {
            InitializeComponent();
        }

        private void WAControl_Load(object sender, EventArgs e)
        {
            this.Visible = true;
        }
    }
}

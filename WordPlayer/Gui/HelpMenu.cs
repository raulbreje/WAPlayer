﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordPlayer.Gui
{
    public partial class HelpMenu : Form
    {
        public HelpMenu()
        {
            InitializeComponent();
            rickTxtBox_about.Text = "Just a preview.";
        }
    }
}

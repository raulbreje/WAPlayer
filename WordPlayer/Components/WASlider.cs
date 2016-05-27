using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Core;

namespace WordPlayer.Components
{
    public partial class WASlider : TrackBar, RibbonControl, RibbonComponent, IComponent, IDisposable
    {
        public WASlider()
        {
            InitializeComponent();
        }

        public string Id
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public OfficeRibbon Ribbon
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IRibbonUI RibbonUI
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        RibbonComponent RibbonComponent.Parent
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void PerformDynamicLayout()
        {
            throw new NotImplementedException();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}

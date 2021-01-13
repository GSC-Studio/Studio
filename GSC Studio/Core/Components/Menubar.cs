using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WeifenLuo.WinFormsUI.Docking;

namespace GSC_Studio.Core.Components
{
    public partial class Menubar : UserControl
    {
        private VisualStudioToolStripExtender Extender;
        private VS2015DarkTheme Theme;

        public Menubar()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;

            Extender = new VisualStudioToolStripExtender();
            Theme = new VS2015DarkTheme();

            Extender.SetStyle(MenuStrip1, VisualStudioToolStripExtender.VsVersion.Vs2015, Theme);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        public MenuStrip GetMenubarControl
        {
            get => MenuStrip1;
        }
    }
}

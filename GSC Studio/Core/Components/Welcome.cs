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
    public partial class Welcome : DockContent
    {
        public Welcome()
        {
            InitializeComponent();

            NewProject.MouseHover += (object o, EventArgs e) =>
            {
                NewProject.ForeColor = Color.RoyalBlue;
            };

            NewProject.MouseLeave += (object o, EventArgs e) =>
            {
                NewProject.ForeColor = Color.DodgerBlue;
            };

            OpenProject.MouseHover += (object o, EventArgs e) =>
            {
                OpenProject.ForeColor = Color.RoyalBlue;
            };

            OpenProject.MouseLeave += (object o, EventArgs e) =>
            {
                OpenProject.ForeColor = Color.DodgerBlue;
            };
        }

        public void AddLastProjects(List<string> projects)
        {

        }
    }
}

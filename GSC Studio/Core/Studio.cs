using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

using GSC_Studio.Core.Design;
using GSC_Studio.Core.Components;
using GSC_Studio.Core.Service;
using System.ComponentModel;
using GSC_Studio.Core.Assets;

namespace GSC_Studio.Core
{
    public class Studio : Window
    {
        public Structure structure;
        public Menubar menubar;
        public ProjectModel CurrentProject;

        public Color DefaultColor = Color.FromArgb(0, 122, 204),
                     DebugColor = Color.FromArgb(0, 122, 204);

        public bool isDebugging = false;

        public Studio()
        {
            structure = new Structure();
            menubar = new Menubar();
            menubar.GetMenubarControl.MouseDown += (object o, MouseEventArgs e) => Drag(e);

            UpdateBorderColor();

            AddControlBody(structure);
            AddControlHead(menubar);

            AddEditor("Test.gsc", "lol");
        }

        public void UpdateBorderColor() => BackColor = (!isDebugging ? DefaultColor : DebugColor);

        public void AddEditor(string title, string value)
        {
            Editor editor = new Editor { Text = title };
            editor.Show(structure.DockerControl);
        }

        protected override void OnDeactivate(EventArgs e)
        {
            base.OnDeactivate(e);
            BackColor = Color.FromArgb(42, 42, 44);
        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            UpdateBorderColor();
        }

        public bool IsProjectLoaded() => CurrentProject != null;

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            if (IsProjectLoaded())
            {
                if (Project.IsProjectUnsaved(CurrentProject))
                {
                    var response = MessageBox.Show("Close the window?", "GSC Studio", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    e.Cancel = (response == DialogResult.No);
                }
            }
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSC_Studio.Core.Design
{
    [DesignerCategory("")]
    public class FixedButton : Button
    {
        public FixedButton()
        {
            BackColor = Color.Transparent;
            FlatStyle = FlatStyle.Flat;
            ForeColor = Color.White;
            Width = 45;
            Dock = DockStyle.Right;


            FlatAppearance.BorderSize = 0;
            FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 30, 30);
            FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 70, 70);
        }

        protected override bool ShowFocusCues => false;
    }
}

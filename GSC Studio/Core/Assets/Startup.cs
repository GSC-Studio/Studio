using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSC_Studio.Core.Assets
{
    public class Startup
    {
        public Size WindowSize { get; set; } = new Size(800, 600);
        public FormWindowState WindowState { get; set; } = FormWindowState.Normal;
    }
}

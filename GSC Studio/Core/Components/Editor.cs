using CefSharp;
using CefSharp.SchemeHandler;
using CefSharp.WinForms;
using GSC_Studio.Core.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace GSC_Studio.Core.Components
{
    public partial class Editor : DockContent
    {
        public ChromiumWebBrowser WebControl;

        internal static readonly int GWL_EXSTYLE = -20;
        internal static readonly int WS_EX_COMPOSITED = 0x02000000;

        [DllImport("user32")]
        internal static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32")]
        internal static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        public Editor()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw | ControlStyles.UserPaint | ControlStyles.SupportsTransparentBackColor, true);
            SAFECONTROL.Hide();

            WebControl = new ChromiumWebBrowser("CACHE://gsc_studio/")
            {
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(30, 30, 30),
            };
            WebControl.CreateControl();

            SAFECONTROL.Controls.Add(WebControl);

            WebControl.LoadingStateChanged += (o, e) =>
            {
                if (!WebControl.IsLoading)
                {
                    Invoke((MethodInvoker)delegate
                    {
                        SAFECONTROL.Show();
                    });
                }
            };

            int style = GetWindowLong(WebControl.Handle, GWL_EXSTYLE);
            style |= WS_EX_COMPOSITED;
            SetWindowLong(WebControl.Handle, GWL_EXSTYLE, style);

        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;
                return handleParam;
            }
        }
    }
}

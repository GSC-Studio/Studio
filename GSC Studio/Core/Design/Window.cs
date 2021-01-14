using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSC_Studio.Core.Design
{
    [DesignerCategory("")]
    public class Window : Form
    {
        #region Load

        [DllImport("user32.dll")]
        static extern bool LockWindowUpdate(IntPtr hWndLock);

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private bool isLocked;
        private Size currentSize;

        private const int RANGE = 2, HT_CAPTION = 0x2, WM_NCLBUTTONDOWN = 0xA1, HTLEFT = 10, HTRIGHT = 11, HTTOP = 12, HTTOPLEFT = 13, HTTOPRIGHT = 14, HTBOTTOM = 15, HTBOTTOMLEFT = 16, HTBOTTOMRIGHT = 17;

        private Panel body, head, headBody, headControl;

        Rectangle WindowTop
        {
            get
            {
                return new Rectangle(0, 0, this.ClientSize.Width, RANGE);
            }
        }

        Rectangle WindowLeft
        {
            get
            {
                return new Rectangle(0, 0, RANGE, this.ClientSize.Height);
            }
        }

        Rectangle WindowBottom
        {
            get
            {
                return new Rectangle(0, this.ClientSize.Height - RANGE, this.ClientSize.Width, RANGE);
            }
        }

        Rectangle WindowRight
        {
            get
            {
                return new Rectangle(this.ClientSize.Width - RANGE, 0, RANGE, this.ClientSize.Height);
            }
        }

        Rectangle TopLeft
        {
            get
            {
                return new Rectangle(0, 0, RANGE, RANGE);
            }
        }

        Rectangle TopRight
        {
            get
            {
                return new Rectangle(this.ClientSize.Width - RANGE, 0, RANGE, RANGE);
            }
        }

        Rectangle BottomLeft
        {
            get
            {
                return new Rectangle(0, this.ClientSize.Height - RANGE, RANGE, RANGE);
            }
        }

        Rectangle BottomRight
        {
            get
            {
                return new Rectangle(this.ClientSize.Width - RANGE, this.ClientSize.Height - RANGE, RANGE, RANGE);
            }
        }
        #endregion

        public Window()
        {
            BackColor = Color.FromArgb(42, 42, 44);
            FormBorderStyle = FormBorderStyle.None;
            Padding = new Padding(1);
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);
            Text = "GSC Studio";

            head = new Container { Dock = DockStyle.Top, Height = 30, BackColor = Color.FromArgb(45, 45, 48) };
            headControl = new Container { Dock = DockStyle.Right, Width = 136, BackColor = Color.FromArgb(45, 45, 48) };
            InitalizeControlButtons(headControl);
            headBody = new Container { Dock = DockStyle.Fill };
            head.Controls.AddRange(new[] { headControl, headBody });
            body = new Container { Dock = DockStyle.Fill, BackColor = Color.FromArgb(30, 30, 30) };
            Controls.AddRange(new[] { body, head });
            SystemEvents.DisplaySettingsChanged += (object o, EventArgs e) => MaximizedBounds = Screen.GetWorkingArea(this);
            MaximizedBounds = Screen.GetWorkingArea(this);
        }

        private Button CustomeButton()
        {
            Button button = new Button
            {
                BackColor = Color.Transparent,
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.White,
                Width = 45,
                Dock = DockStyle.Right
            };

            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            button.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 30, 30);
            button.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 70, 70);

            return button;
        }

        private void InitalizeControlButtons(Panel control_buttons)
        {
            Button CloseButton = CustomeButton();
            Button MaximizeButton = CustomeButton();
            Button MinimizeButton = CustomeButton();

            CloseButton.Paint += (object o, PaintEventArgs e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
                e.Graphics.DrawLine(new Pen(Brushes.White, 1), new Point(18, 10), new Point(28, 20));
                e.Graphics.DrawLine(new Pen(Brushes.White, 1), new Point(18, 20), new Point(28, 10));
            };

            MaximizeButton.Paint += (object o, PaintEventArgs e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
                if (WindowState == FormWindowState.Normal)
                {
                    e.Graphics.DrawRectangle(new Pen(Brushes.White, 1), new Rectangle(18, 10, 10, 10));
                }
                else
                {
                    e.Graphics.DrawRectangle(new Pen(Brushes.White, 1), new Rectangle(15, 12, 10, 10));
                    e.Graphics.DrawRectangle(new Pen(Brushes.White, 1), new Rectangle(18, 10, 10, 10));
                }

            };

            MinimizeButton.Paint += (object o, PaintEventArgs e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
                e.Graphics.DrawLine(new Pen(Brushes.White, 1), new Point(18, 15), new Point(28, 15));
            };

            CloseButton.Click += (object o, EventArgs e) => Application.Exit();
            MaximizeButton.Click += (object o, EventArgs e) => WindowState = WindowState == FormWindowState.Normal ? FormWindowState.Maximized : FormWindowState.Normal;
            MinimizeButton.Click += (object o, EventArgs e) => WindowState = FormWindowState.Minimized;

            control_buttons.Controls.AddRange(new Control[] { MinimizeButton, MaximizeButton, CloseButton });
        }

        public void AddControlBody(params Control[] controls)
        {
            if (body != null)
            {
                body.Controls.AddRange(controls);
            }
        }

        public void AddControlHead(params Control[] controls)
        {
            if (headBody != null)
            {
                headBody.Controls.AddRange(controls);
            }
        }

        public void Drag(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

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

        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);
            switch (message.Msg)
            {
                case 0x84:
                    this.EnableResizing(ref message);
                    break;
            }
        }

        protected override void OnResizeBegin(EventArgs e)
        {
            currentSize = this.Size;
            base.OnResizeBegin(e);
        }

        protected override void OnResizeEnd(EventArgs e)
        {
            base.OnResizeEnd(e);
            currentSize = this.Size;
            this.UnlockWindow();

            this.Update();
            this.Invalidate();
        }

        protected override void OnMove(EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal && IsResized() && !isLocked)
            {
                LockWindow();
            }

            base.OnMove(e);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            if (WindowState == FormWindowState.Normal)
            {
                if (isLocked && IsResized())
                {
                    currentSize = this.Size;
                    UnlockWindow();
                    LockWindow();
                }
            }

            Task.Run(() =>
            {
                Invoke((MethodInvoker)delegate
                {
                    this.Update();
                    this.Invalidate();
                });
            });
        }

        private void LockWindow()
        {
            if (!isLocked)
            {
                isLocked = true;
                LockWindowUpdate(this.Handle);
            }
        }

        private void UnlockWindow()
        {
            if (isLocked)
            {
                isLocked = false;
                LockWindowUpdate(IntPtr.Zero);
                this.Update();
            }
        }

        private bool IsResized()
        {
            if (currentSize.IsEmpty)
            {
                return false;
            }
            else
            {
                return this.Size != currentSize;
            }
        }

        private void EnableResizing(ref Message message)
        {
            var cursor = this.PointToClient(Cursor.Position);

            if (TopLeft.Contains(cursor)) message.Result = (IntPtr)HTTOPLEFT;
            else if (TopRight.Contains(cursor)) message.Result = (IntPtr)HTTOPRIGHT;
            else if (BottomLeft.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMLEFT;
            else if (BottomRight.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMRIGHT;

            else if (WindowTop.Contains(cursor)) message.Result = (IntPtr)HTTOP;
            else if (WindowLeft.Contains(cursor)) message.Result = (IntPtr)HTLEFT;
            else if (WindowRight.Contains(cursor)) message.Result = (IntPtr)HTRIGHT;
            else if (WindowBottom.Contains(cursor)) message.Result = (IntPtr)HTBOTTOM;
        }
    }
}

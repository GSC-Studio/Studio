using CefSharp;
using CefSharp.SchemeHandler;
using CefSharp.WinForms;
using GSC_Studio.Core.Assets;
using GSC_Studio.Core.Components;
using GSC_Studio.Core.Design;
using GSC_Studio.Core.Service;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSC_Studio.Core
{
    public class Studio : Window
    {
        Initialization initialization;

        public Structure structure;
        public Menubar menubar;
        public ProjectModel CurrentProject;

        public Color DefaultColor = Color.FromArgb(0, 122, 204),
                     DebugColor = Color.FromArgb(0, 122, 204);

        public bool isDebugging = false;

        public Studio(Initialization inital)
        {
            initialization = inital;

            InitializeWebControl();

            structure = new Structure();
            menubar = new Menubar();
            menubar.GetMenubarControl.MouseDown += (object o, MouseEventArgs e) => Drag(e);

            UpdateBorderColor();

            AddControlBody(structure);
            AddControlHead(menubar);

            //AddEditor("Test.gsc", "lol");
            OpenWelcomePage();
        }

        public void OpenWelcomePage()
        {
            Welcome welcomeScreen = new Welcome();

            welcomeScreen.Show(structure.DockerControl);
        }

        private void InitializeWebControl()
        {
            CefSettings settings = new CefSettings();
            settings.WindowlessRenderingEnabled = true;
            settings.BackgroundColor = 0x00;

            settings.RegisterScheme(new CefCustomScheme
            {
                SchemeName = "CACHE",
                DomainName = "gsc_studio",
                SchemeHandlerFactory = new FolderSchemeHandlerFactory(
                    rootFolder: (Initialization.CACHE_PATH + "/editor/"),
                    hostName: "gsc_studio",
                    defaultPage: "index.html"
                )
            });

            Cef.Initialize(settings);
        }

        public void UpdateBorderColor() => BackColor = (!isDebugging ? DefaultColor : DebugColor);

        public async void AddEditor(string title, string value)
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

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            initialization.CreateFileInCache("startup.json", JsonConvert.SerializeObject(new Startup
            {
                WindowSize = Size,
                WindowState = WindowState
            }));
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}

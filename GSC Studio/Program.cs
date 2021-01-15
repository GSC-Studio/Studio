using GSC_Studio.Core;
using GSC_Studio.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using GSC_Studio.Core.Assets;

namespace GSC_Studio
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            const string EDITOR = "https://github.com/GSC-Studio/Monaco/archive/main.zip";

            Initialization inital = new Initialization();
            Startup startup = new Startup();

            if (!inital.CacheExists())
            {
                if (MessageBox.Show("You launch GSC Studio for the first time, important modules will be installed.", "GSC Studio - Service", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    inital.CreateCacheFolder();
                    inital.CreateFileInCache("startup.json", JsonConvert.SerializeObject(startup));
                    inital.CreateRepositoryToCache(EDITOR, "/Monaco-main", "/editor");
                }
                else
                {
                    Application.Exit();
                }

            } else
            {
                startup = JsonConvert.DeserializeObject<Startup>(inital.ReadFileFromCache("startup.json"));
            }

            if (!inital.ProjectExists())
            {
                inital.CreateProjectFolder();
            }


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.ThreadException += new ThreadExceptionEventHandler((o, e) => { });
            //Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException); 
            //AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler((o, e) => { });

            Application.Run(new Studio()
            {
                WindowState = startup.WindowState,
                Size = startup.WindowSize
            });
        }
    }
}

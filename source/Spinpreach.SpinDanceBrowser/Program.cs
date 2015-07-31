using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using Spinpreach.SwordsDanceBase;
using Spinpreach.SwordsDanceViewer;

namespace Spinpreach.SpinDanceBrowser
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool run = true;
#if !DEBUG
            // 二重起動を防止する
            using (Mutex mutex = new Mutex(false, Application.ProductName))
            {
                run = mutex.WaitOne(0, false);
            }
#endif

            if (run)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                var login = LoginInfo.Load();
                if (!login.IsExists())
                {
                    LoginForm frm = new LoginForm();
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        login = frm.LoginData;
                        LoginInfo.Save(login);
                    }
                }

                if (login.IsExists())
                {
                    SessionWrapper sessionWrapper = new SessionWrapper(8890);
                    Application.Run(new MainForm(sessionWrapper));
                }
            }

        }
    }
}

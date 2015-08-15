using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nekoxy;

namespace Spinpreach.SwordsDanceBase
{
    public static class Proxy
    {

        public static Action<Session> AfterSessionComplete_Text;

        public static void Startup(int ProxyPort)
        {
            HttpProxy.Startup(ProxyPort);
            HttpProxy.AfterSessionComplete += (s) => Task.Run(() => SwordsDanceProxy_AfterSessionComplete(s));
        }

        public static void Shutdown()
        {
            HttpProxy.Shutdown();
        }

        private static void SwordsDanceProxy_AfterSessionComplete(Session s)
        {
            if (s.Response.ContentType.Equals("text/html"))
            {
                AfterSessionComplete_Text?.Invoke(s);
            }
            else
            {
                //Console.WriteLine(string.Format("ContentType = {0}", s.Response.ContentType));
            }
        }
    }
}
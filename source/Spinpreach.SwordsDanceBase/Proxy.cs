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

        public delegate void EventHandler(Session s);

        public static event EventHandler AfterSessionComplete_Text;

        public static void Startup(int ProxyPort)
        {
            HttpProxy.Startup(ProxyPort);
            HttpProxy.AfterSessionComplete += s => Task.Run(() => SwordsDanceProxy_AfterSessionComplete(s));
        }

        public static void Shutdown()
        {
            HttpProxy.Shutdown();
        }

        private static void SwordsDanceProxy_AfterSessionComplete(Session s)
        {

            //Console.WriteLine("******************************************************");

            if (s.Response.ContentType.Equals("text/html"))
            {
                if (AfterSessionComplete_Text != null)
                {
                    //Console.WriteLine(string.Format("ContentType = {0}, PathAndQuery = {1}", s.Response.ContentType, s.Request.PathAndQuery));
                    AfterSessionComplete_Text(s);
                }
            }
            else
            {
                //Console.WriteLine(string.Format("ContentType = {0}", s.Response.ContentType));
            }

        }
    }
}

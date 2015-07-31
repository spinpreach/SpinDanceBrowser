using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nekoxy;
using Codeplex.Data;
using Newtonsoft.Json;
using Spinpreach.SwordsDanceBase.api;

namespace Spinpreach.SwordsDanceBase
{

    public class SessionWrapper
    {

        public int ProxyPort { get; }

        public SessionWrapper(int ProxyPort)
        {
            this.ProxyPort = ProxyPort;
            Proxy.Startup(ProxyPort);
            Proxy.AfterSessionComplete_Text += this.AfterSessionComplete_Text;
        }

        private void AfterSessionComplete_Text(Session s)
        {

#if DEBUG
            SessionWriter.XmlWriter(s.Request.PathAndQuery.Replace("/", "_"), s.Response.BodyAsString);
            SessionWriter.JsonWriter(s.Request.PathAndQuery.Replace("/", "_"), s.Response.BodyAsString);
#endif

            switch (s.Request.PathAndQuery)
            {

                // /login/start
                // /party/list
                // /forge
                // /produce
                // /repair
                // /composition
                // /duty
                // /mission/index
                // /album/list
                // /user/profile
                // /shop/list
                // /furniture/index

                case "/login/start":

                    var hoge = JsonConvert.DeserializeObject<_login_start>(s.Response.BodyAsString);

                    break;

                case "/home":

                    var x = JsonConvert.DeserializeObject<_home>(s.Response.BodyAsString);
                    //var x = (_home)DynamicJson.Parse(s.Response.BodyAsString);

                    Console.WriteLine(string.Format("依頼札 = {0}", x.resource.bill));
                    Console.WriteLine(string.Format("木炭 = {0}", x.resource.charcoal));
                    Console.WriteLine(string.Format("玉鋼 = {0}", x.resource.steel));
                    Console.WriteLine(string.Format("冷却材 = {0}", x.resource.coolant));
                    Console.WriteLine(string.Format("砥石 = {0}", x.resource.file));
                    Console.WriteLine(string.Format("資源保有最大値 = {0}", x.resource.max_resource));

                    break;

                default:
                    Debug.WriteLine(s.Request.PathAndQuery);
                    break;

            }

        }
    }
}

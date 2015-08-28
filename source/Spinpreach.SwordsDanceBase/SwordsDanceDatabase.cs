using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

using Spinpreach.SwordsDanceBase.api;

namespace Spinpreach.SwordsDanceBase
{
    public class SwordsDanceDatabase
    {

        private NekoxyWrapper nw;

        public SwordsDanceDatabase(NekoxyWrapper nw)
        {
            this.nw = nw;
            this.nw.SessionComplete += this.nw_Log;
            this.nw.SessionComplete += this.nw_SessionComplete;
        }

        private void nw_Log(string api, string request, string response)
        {
            try
            {
                var time = DateTime.Now;
                SessionWriter.JsonWriterTransaction(api, response);
                SessionWriter.JsonWriterHistory(api, response, time);
                SessionWriter.XmlWriterTransaction(api, response);
                SessionWriter.XmlWriterHistory(api, response, time);
            }
            catch (Exception)
            {
                Console.WriteLine(string.Format("{0} : {1}.{2}", "Exception", this.GetType().FullName, System.Reflection.MethodBase.GetCurrentMethod().Name));
            }
        }

        private void nw_SessionComplete(string api, string request, string response)
        {
            switch (api)
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

                    var hoge = JsonConvert.DeserializeObject<_login_start>(response);

                    break;

                case "/home":

                    var x = JsonConvert.DeserializeObject<_home>(response);
                    //var x = JsonConvert.DeserializeObject<dynamic>(response);
                    //var x = (_home)DynamicJson.Parse(s.Response.BodyAsString);

                    Console.WriteLine(string.Format("依頼札 = {0}", x.resource.bill));
                    Console.WriteLine(string.Format("木炭 = {0}", x.resource.charcoal));
                    Console.WriteLine(string.Format("玉鋼 = {0}", x.resource.steel));
                    Console.WriteLine(string.Format("冷却材 = {0}", x.resource.coolant));
                    Console.WriteLine(string.Format("砥石 = {0}", x.resource.file));
                    Console.WriteLine(string.Format("資源保有最大値 = {0}", x.resource.max_resource));

                    break;

                default: Console.WriteLine(api); break;
            }
        }
    }
}
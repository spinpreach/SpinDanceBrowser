using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Spinpreach.SwordsDanceBase
{
    public class Querys
    {
        private SwordsDanceDatabase database;
        public Querys(SwordsDanceDatabase database)
        {
            this.database = database;
        }

        public void _login_start(string request, string response)
        {
            //************************************************************
            var req = new Apis.Requests._login_start(request);
            var res = JsonConvert.DeserializeObject<Apis.Responses._login_start>(response);
            //************************************************************
            this.database.api.request.login_start = req;
            this.database.api.response.login_start = res;
            //************************************************************

            // 部隊情報の登録
            this.database.table.transaction.party = new Tables.Transactions.Party();
            foreach (var item in res.party.Select(x => x.Value))
            {
                this.database.table.transaction.party.Rows.Add(new Tables.Transactions.Party.Row(item));
            }

            // サーバ時間とクライアント時間の誤差
            this.database.table.ts = DateTime.Parse(res.now).Subtract(DateTime.Now);

            // イベント発生
            this.database.apiActions._login_start?.Invoke();
        }

        public void _home(string request, string response)
        {
            //************************************************************
            var req = new Apis.Requests._home(request);
            var res = JsonConvert.DeserializeObject<Apis.Responses._home>(response);
            //************************************************************
            this.database.api.request.home = req;
            this.database.api.response.home = res;
            //************************************************************

            Console.WriteLine(string.Format("依頼札 = {0}", res.resource.bill));
            Console.WriteLine(string.Format("木炭 = {0}", res.resource.charcoal));
            Console.WriteLine(string.Format("玉鋼 = {0}", res.resource.steel));
            Console.WriteLine(string.Format("冷却材 = {0}", res.resource.coolant));
            Console.WriteLine(string.Format("砥石 = {0}", res.resource.file));
            Console.WriteLine(string.Format("資源保有最大値 = {0}", res.resource.max_resource));

            // イベント発生
            this.database.apiActions._home?.Invoke();
        }

        public void _conquest_complete(string request, string response)
        {
            //************************************************************
            var req = new Apis.Requests._conquest_complete(request);
            var res = JsonConvert.DeserializeObject<Apis.Responses._conquest_complete>(response);
            //************************************************************
            this.database.api.request.conquest_complete = req;
            this.database.api.response.conquest_complete = res;
            //************************************************************

            // 部隊情報の登録
            this.database.table.transaction.party = new Tables.Transactions.Party();
            foreach (var item in res.party.Select(x => x.Value))
            {
                this.database.table.transaction.party.Rows.Add(new Tables.Transactions.Party.Row(item));
            }

            // イベント発生
            this.database.apiActions._conquest_complete?.Invoke();
        }

        public void _conquest_start(string request, string response)
        {
            //************************************************************
            var req = new Apis.Requests._conquest_start(request);
            var res = JsonConvert.DeserializeObject<Apis.Responses._conquest_start>(response);
            //************************************************************
            this.database.api.request.conquest_start = req;
            this.database.api.response.conquest_start = res;
            //************************************************************

            // 部隊情報の登録
            this.database.table.transaction.party = new Tables.Transactions.Party();
            foreach (var item in res.party.Select(x => x.Value))
            {
                this.database.table.transaction.party.Rows.Add(new Tables.Transactions.Party.Row(item));
            }

            // イベント発生
            this.database.apiActions._conquest_start?.Invoke();
        }

        public void _conquest_cancel(string request, string response)
        {
            //************************************************************
            var req = new Apis.Requests._conquest_cancel(request);
            var res = JsonConvert.DeserializeObject<Apis.Responses._conquest_cancel>(response);
            //************************************************************
            this.database.api.request.conquest_cancel = req;
            this.database.api.response.conquest_cancel = res;
            //************************************************************

            // 部隊情報の登録
            this.database.table.transaction.party = new Tables.Transactions.Party();
            foreach (var item in res.party.Select(x => x.Value))
            {
                this.database.table.transaction.party.Rows.Add(new Tables.Transactions.Party.Row(item));
            }

            // イベント発生
            this.database.apiActions._conquest_cancel?.Invoke();
        }

    }
}
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
            try
            {
                #region JsonConvert

                var req = new Apis.Requests._login_start(request);
                var res = JsonConvert.DeserializeObject<Apis.Responses._login_start>(response);

                #endregion

                #region database.api

                this.database.api.request.login_start = req;
                this.database.api.response.login_start = res;

                this.database.apiNotify._login_start?.Invoke();

                #endregion

                // サーバ時間とクライアント時間の誤差
                this.database.table.ts = DateTime.Parse(res.now).Subtract(DateTime.Now);

                #region transaction.castlekeep

                // 部隊情報の登録
                this.database.table.transaction.castlekeep = new Tables.Transactions.Castlekeep(res);

                // 変更通知(Table)
                this.database.tableNotify.transactions_castlekeep?.Invoke();

                #endregion

                #region transaction.party

                // 部隊情報の登録
                this.database.table.transaction.party = new Tables.Transactions.Party();
                foreach (var item in res.party.Select(x => x.Value))
                {
                    this.database.table.transaction.party.Rows.Add(new Tables.Transactions.Party.Row(item));
                }

                // 変更通知(Table)
                this.database.tableNotify.transactions_party?.Invoke();

                #endregion

                #region transaction.resource

                // 資源の登録
                this.database.table.transaction.resource = new Tables.Transactions.Resource(res.resource);

                // 変更通知(Table)
                this.database.tableNotify.transactions_resource?.Invoke();

                #endregion

            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("Exception : {0}.{1} >> {2}", ex.TargetSite.ReflectedType.FullName, ex.TargetSite.Name, ex.Message));
            }
        }

        public void _home(string request, string response)
        {
            try
            {
                #region JsonConvert

                var req = new Apis.Requests._home(request);
                var res = JsonConvert.DeserializeObject<Apis.Responses._home>(response);

                #endregion

                #region database.api

                this.database.api.request.home = req;
                this.database.api.response.home = res;

                this.database.apiNotify._home?.Invoke();

                #endregion

                #region transaction.resource

                // 資源の登録
                this.database.table.transaction.resource = new Tables.Transactions.Resource(res.resource);

                // 変更通知(Table)
                this.database.tableNotify.transactions_resource?.Invoke();

                #endregion

            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("Exception : {0}.{1} >> {2}", ex.TargetSite.ReflectedType.FullName, ex.TargetSite.Name, ex.Message));
            }
        }

        public void _conquest_complete(string request, string response)
        {
            try
            {
                #region JsonConvert

                var req = new Apis.Requests._conquest_complete(request);
                var res = JsonConvert.DeserializeObject<Apis.Responses._conquest_complete>(response);

                #endregion

                #region database.api

                this.database.api.request.conquest_complete = req;
                this.database.api.response.conquest_complete = res;

                this.database.apiNotify._conquest_complete?.Invoke();

                #endregion

                #region transaction.party

                // 部隊情報の登録
                this.database.table.transaction.party = new Tables.Transactions.Party();
                foreach (var item in res.party.Select(x => x.Value))
                {
                    this.database.table.transaction.party.Rows.Add(new Tables.Transactions.Party.Row(item));
                }

                // 変更通知(Table)
                this.database.tableNotify.transactions_party?.Invoke();

                #endregion

                #region transaction.resource

                // 資源の登録
                this.database.table.transaction.resource = new Tables.Transactions.Resource(res.resource);

                // 変更通知(Table)
                this.database.tableNotify.transactions_resource?.Invoke();

                #endregion
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("Exception : {0}.{1} >> {2}", ex.TargetSite.ReflectedType.FullName, ex.TargetSite.Name, ex.Message));
            }
        }

        public void _conquest_start(string request, string response)
        {
            try
            {
                #region JsonConvert

                var req = new Apis.Requests._conquest_start(request);
                var res = JsonConvert.DeserializeObject<Apis.Responses._conquest_start>(response);

                #endregion

                #region database.api

                this.database.api.request.conquest_start = req;
                this.database.api.response.conquest_start = res;

                this.database.apiNotify._conquest_start?.Invoke();

                #endregion

                #region transaction.party

                // 部隊情報の登録
                this.database.table.transaction.party = new Tables.Transactions.Party();
                foreach (var item in res.party.Select(x => x.Value))
                {
                    this.database.table.transaction.party.Rows.Add(new Tables.Transactions.Party.Row(item));
                }

                // 変更通知(Table)
                this.database.tableNotify.transactions_party?.Invoke();

                #endregion
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("Exception : {0}.{1} >> {2}", ex.TargetSite.ReflectedType.FullName, ex.TargetSite.Name, ex.Message));
            }
        }

        public void _conquest_cancel(string request, string response)
        {
            try
            {
                #region JsonConvert

                var req = new Apis.Requests._conquest_cancel(request);
                var res = JsonConvert.DeserializeObject<Apis.Responses._conquest_cancel>(response);

                #endregion

                #region database.api

                this.database.api.request.conquest_cancel = req;
                this.database.api.response.conquest_cancel = res;

                this.database.apiNotify._conquest_cancel?.Invoke();

                #endregion

                #region transaction.party

                // 部隊情報の登録
                this.database.table.transaction.party = new Tables.Transactions.Party();
                foreach (var item in res.party.Select(x => x.Value))
                {
                    this.database.table.transaction.party.Rows.Add(new Tables.Transactions.Party.Row(item));
                }

                // 変更通知(Table)
                this.database.tableNotify.transactions_party?.Invoke();

                #endregion
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("Exception : {0}.{1} >> {2}", ex.TargetSite.ReflectedType.FullName, ex.TargetSite.Name, ex.Message));
            }
        }
    }
}
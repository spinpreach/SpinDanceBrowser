using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Spinpreach.SwordsDanceBase;

namespace Spinpreach.SpinDanceBrowser.Timers
{
    /// <summary>
    /// 遠征のタイマーイベントを発生させます。
    /// ※遠征中の艦隊が存在する場合のみ発生します。
    /// </summary>
    public class MissionTimer
    {
        public Action Notify;
        private SwordsDanceDatabase database;
        private Timer timer;

        public MissionTimer(SwordsDanceDatabase database)
        {
            this.database = database;
            this.timer = new Timer(1000);
            this.timer.Elapsed += new ElapsedEventHandler(this.timer_Elapsed);
            this.timer.Start();
        }

        private void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            try
            {
                // 遠征中の部隊を抽出
                var q1 = this.database.table.transaction.party.Rows.Where(x => x.status == 2);

                // 遠征帰還時間が現在時間になった部隊が存在するか？
                var flag = !q1.Where(x => (int)this.database.ServerTime.Subtract((DateTime)x.finished_at).TotalSeconds == -1).Count().Equals(0);
                
                if (flag) this.Notify?.Invoke();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
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
    /// 資源ログのタイマーイベントを発生させます。
    /// </summary>
    public class ResourceTimer
    {
        public Action Notify;
        private SwordsDanceDatabase database;
        private Timer timer;

        public ResourceTimer(SwordsDanceDatabase database)
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
                this.timer = new Timer(1000 * 60 * 5);
                this.Notify?.Invoke();
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("Exception : {0}.{1} >> {2}", ex.TargetSite.ReflectedType.FullName, ex.TargetSite.Name, ex.Message));
            }
        }
    }
}
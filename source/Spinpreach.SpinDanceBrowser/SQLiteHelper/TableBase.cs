using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SQLite;

namespace Spinpreach.SpinDanceBrowser.SQLiteHelper
{
    public abstract class TableBase : IDisposable
    {

        private string dbname;
        protected SQLiteConnection connection;

        public TableBase(string dbname)
        {
            // ファイル名に使用できない文字を排除する。
            Path.GetInvalidFileNameChars().ToList().ForEach(x => { dbname = dbname.Replace(x, '_'); });
            this.dbname = string.Format("{0}.db", dbname);
            this.connection = new SQLiteConnection(this.connectionString);
        }

        public void Dispose()
        {
            this.connection.Close();
        }

        private string connectionString
        {
            get
            {
                string directory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "SpinDanceBrowser");
                if (!Directory.Exists(directory)) Directory.CreateDirectory(directory);
                string ret = string.Format(@"Data Source={0}\{1};Version=3;New=True;Compress=True;", directory, dbname);
                return (ret);
            }
        }

    }

    public abstract class RowBase
    {

        private DateTime time;

        public DateTime datetime
        {
            get { return (new DateTime(time.Year, time.Month, time.Day, time.Hour, time.Minute, time.Second)); }
            set { this.time = value; }
        }

        public RowBase()
        {
            this.datetime = DateTime.MaxValue;
        }

    }

}
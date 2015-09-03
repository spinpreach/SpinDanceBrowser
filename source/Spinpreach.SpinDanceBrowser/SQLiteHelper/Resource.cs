using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace Spinpreach.SpinDanceBrowser.SQLiteHelper
{
    public class Resource: TableBase
    {
        public Resource(string dbname) : base(dbname)
        {
            try
            {
                this.connection.Open();
                if (this.IsTable()) this.CreateTable();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string tablename
        {
            get { return this.GetType().Name; }
        }

        private bool IsTable()
        {
            bool ret = true;
            var sql = new StringBuilder();

            sql.AppendLine(" SELECT ");
            sql.AppendLine("    Count(*) ");
            sql.AppendLine(" FROM ");
            sql.AppendLine("    sqlite_master ");
            sql.AppendLine(" WHERE ");
            sql.AppendLine("    type = 'table' ");
            sql.AppendLine(" AND ");
            sql.AppendLine("    name = '" + this.tablename + "' ");

            using (var cs = new SQLiteCommand(this.connection))
            {
                cs.CommandText = sql.ToString();
                using (var reader = cs.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ret = reader.GetInt32(0).Equals(0);
                    }
                }
            }

            return (ret);
        }

        private void CreateTable()
        {

            var sql = new StringBuilder();

            sql.AppendLine(" CREATE TABLE ");
            sql.AppendLine(" " + this.tablename + " ");
            sql.AppendLine(" ( ");
            sql.AppendLine("    date datetime, ");
            sql.AppendLine("    bill integer, ");
            sql.AppendLine("    charcoal integer, ");
            sql.AppendLine("    steel integer, ");
            sql.AppendLine("    coolant integer, ");
            sql.AppendLine("    file integer, ");
            sql.AppendLine("    datetime datetime, ");
            sql.AppendLine(" 	PRIMARY KEY(date) ");
            sql.AppendLine(" ) ");

            using (var sc = new SQLiteCommand(this.connection))
            {
                sc.CommandText = sql.ToString();
                sc.ExecuteNonQuery();
            }

        }

        private bool IsRow(Row value)
        {
            bool ret = false;
            var sql = new StringBuilder();

            sql.AppendLine(" SELECT ");
            sql.AppendLine("    * ");
            sql.AppendLine(" FROM ");
            sql.AppendLine(" 	" + this.tablename + " ");
            sql.AppendLine(" WHERE ");
            sql.AppendLine(" 	date = @date ");

            using (var command = new SQLiteCommand(this.connection))
            {
                command.CommandText = sql.ToString();
                command.Parameters.Add(new SQLiteParameter("@date", value.date));
                var table = new DataTable();
                using (var adapter = new SQLiteDataAdapter(command))
                {
                    adapter.Fill(table);
                }
                ret = !table.Rows.Count.Equals(0);
            }

            return (ret);
        }

        private void Insert(Row value)
        {
            var sql = new StringBuilder();

            sql.AppendLine(" INSERT INTO ");
            sql.AppendLine(" " + this.tablename + " ");
            sql.AppendLine(" ( ");
            sql.AppendLine("    date, ");
            sql.AppendLine("    bill, ");
            sql.AppendLine("    charcoal, ");
            sql.AppendLine("    steel, ");
            sql.AppendLine("    coolant, ");
            sql.AppendLine("    file, ");
            sql.AppendLine("    datetime ");
            sql.AppendLine(" ) ");
            sql.AppendLine(" VALUES ");
            sql.AppendLine(" ( ");
            sql.AppendLine("    @date, ");
            sql.AppendLine("    @bill, ");
            sql.AppendLine("    @charcoal, ");
            sql.AppendLine("    @steel, ");
            sql.AppendLine("    @coolant, ");
            sql.AppendLine("    @file, ");
            sql.AppendLine("    @datetime ");
            sql.AppendLine(" ) ");

            using (var sc = new SQLiteCommand(this.connection))
            {
                sc.CommandText = sql.ToString();
                sc.Parameters.Add(new SQLiteParameter("@date", value.date));
                sc.Parameters.Add(new SQLiteParameter("@bill", value.bill));
                sc.Parameters.Add(new SQLiteParameter("@charcoal", value.charcoal));
                sc.Parameters.Add(new SQLiteParameter("@steel", value.steel));
                sc.Parameters.Add(new SQLiteParameter("@coolant", value.coolant));
                sc.Parameters.Add(new SQLiteParameter("@file", value.file));
                sc.Parameters.Add(new SQLiteParameter("@datetime", value.datetime));
                sc.ExecuteNonQuery();
            }
        }

        private void Update(Row value)
        {
            var sql = new StringBuilder();

            sql.AppendLine(" UPDATE ");
            sql.AppendLine(" " + this.tablename + " ");
            sql.AppendLine(" SET  ");
            sql.AppendLine(" 	bill = @bill, ");
            sql.AppendLine(" 	charcoal = @charcoal, ");
            sql.AppendLine(" 	steel = @steel, ");
            sql.AppendLine(" 	coolant = @coolant, ");
            sql.AppendLine(" 	file = @file, ");
            sql.AppendLine(" 	datetime = @datetime ");
            sql.AppendLine(" WHERE  ");
            sql.AppendLine(" 	date = @date ");

            using (var sc = new SQLiteCommand(this.connection))
            {
                sc.CommandText = sql.ToString();
                sc.Parameters.Add(new SQLiteParameter("@date", value.date));
                sc.Parameters.Add(new SQLiteParameter("@bill", value.bill));
                sc.Parameters.Add(new SQLiteParameter("@charcoal", value.charcoal));
                sc.Parameters.Add(new SQLiteParameter("@steel", value.steel));
                sc.Parameters.Add(new SQLiteParameter("@coolant", value.coolant));
                sc.Parameters.Add(new SQLiteParameter("@file", value.file));
                sc.Parameters.Add(new SQLiteParameter("@datetime", value.datetime));
                sc.ExecuteNonQuery();
            }
        }

        public void Merge(Row value)
        {
            if (!this.IsRow(value))
            {
                this.Insert(value);
            }
            else
            {
                this.Update(value);
            }
        }

        public List<Row> Full()
        {
            var ret = new List<Row>();
            var sql = new StringBuilder();

            sql.AppendLine(" SELECT ");
            sql.AppendLine("    * ");
            sql.AppendLine(" FROM ");
            sql.AppendLine(" 	" + this.tablename + " ");

            using (var sc = new SQLiteCommand(sql.ToString(), this.connection))
            {
                var table = new DataTable();
                using (var adapter = new SQLiteDataAdapter(sc))
                {
                    adapter.Fill(table);
                }

                foreach (DataRow item in table.Rows)
                {
                    var row = new Row();
                    row.date = (DateTime)item["date"];
                    row.bill = (int)(long)item["bill"];
                    row.charcoal = (int)(long)item["charcoal"];
                    row.steel = (int)(long)item["steel"];
                    row.coolant = (int)(long)item["coolant"];
                    row.file = (int)(long)item["file"];
                    row.datetime = (DateTime)item["datetime"];
                    ret.Add(row);
                }
            }

            return (ret);
        }

        public class Row : RowBase
        {
            private DateTime _date;
            public DateTime date
            {
                get { return (new DateTime(this._date.Year, this._date.Month, this._date.Day)); }
                set { this._date = value; }
            }

            /// <summary>
            /// 依頼札
            /// </summary>
            public int bill { get; set; } = 0;

            /// <summary>
            /// 木炭
            /// </summary>
            public int charcoal { get; set; } = 0;

            /// <summary>
            /// 玉鋼
            /// </summary>
            public int steel { get; set; } = 0;

            /// <summary>
            /// 冷却材
            /// </summary>
            public int coolant { get; set; } = 0;

            /// <summary>
            /// 砥石
            /// </summary>
            public int file { get; set; } = 0;
        }

    }
}
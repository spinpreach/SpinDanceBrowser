using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spinpreach.SwordsDanceBase.Tables.Transactions
{
    public class Party
    {
        public List<Row> Rows { get; set; } = new List<Row>();

        public class Row
        {
            /// <summary>
            /// 部隊番号
            /// </summary>
            public int no { get; set; } = 0;

            /// <summary>
            /// 状態（0:未開放 1:待機中 2:遠征中）
            /// </summary>
            public int status { get; set; } = 0;

            /// <summary>
            /// 部隊名
            /// </summary>
            public string name { get; set; } = string.Empty;

            /// <summary>
            /// 遠征帰還時間
            /// </summary>
            public DateTime? finished_at { get; set; } = null;

            /// <summary>
            /// 所属している刀剣のID
            /// </summary>
            public List<string> id { get; set; } = new List<string>();

            public Row(Apis.Responses.Party value)
            {
                this.no = value.party_no;
                this.status = value.status;
                this.name = value.party_name;
                this.finished_at = value.finished_at == null ? (DateTime?)null : DateTime.Parse(value.finished_at);
                this.id = value.slot.Select(x => x.Value.serial_id).ToList();
            }
        }
    }
}
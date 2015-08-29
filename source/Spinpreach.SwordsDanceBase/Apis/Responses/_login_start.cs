using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spinpreach.SwordsDanceBase.Apis.Responses
{
    public class _login_start
    {
        /// <summary>
        /// 審神者
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// レベル
        /// </summary>
        public string level { get; set; }

        /// <summary>
        /// 経験値
        /// </summary>
        public string exp { get; set; }

        /// <summary>
        /// 刀剣所有可能数
        /// </summary>
        public string max_sword { get; set; }

        /// <summary>
        /// 刀装所有可能数
        /// </summary>
        public string max_equip { get; set; }

        /// <summary>
        /// ?
        /// </summary>
        public string tutorial { get; set; }

        /// <summary>
        /// ?
        /// </summary>
        public string secretary { get; set; }

        /// <summary>
        /// ?
        /// </summary>
        public string secretary_serial_id { get; set; }

        /// <summary>
        /// ?
        /// </summary>
        public string secretary_hp { get; set; }

        /// <summary>
        /// ?
        /// </summary>
        public string secretary_hp_max { get; set; }

        /// <summary>
        /// ?
        /// </summary>
        public Currency currency { get; set; }

        /// <summary>
        /// ?
        /// </summary>
        public dynamic item { get; set; }

        /// <summary>
        /// 資材情報
        /// </summary>
        public Resource resource { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public dynamic equip { get; set; }

        /// <summary>
        /// 最大部隊数
        /// </summary>
        public string max_party { get; set; }

        /// <summary>
        /// 最大鍛練所
        /// </summary>
        public string forge_slot { get; set; }

        /// <summary>
        /// 最大手入部屋
        /// </summary>
        public string repair_slot { get; set; }

        /// <summary>
        /// ?
        /// </summary>
        public dynamic furniture { get; set; }

        /// <summary>
        /// 部隊情報
        /// </summary>
        public Dictionary<int, Party> party { get; set; }

        /// <summary>
        /// ?
        /// </summary>
        public object duty { get; set; }

        /// <summary>
        /// ?
        /// </summary>
        public object leave { get; set; }

        /// <summary>
        /// ?
        /// </summary>
        public object back { get; set; }

        /// <summary>
        /// ?
        /// </summary>
        public News[] news { get; set; }

        /// <summary>
        /// ?
        /// </summary>
        public string t { get; set; }

        /// <summary>
        /// ?
        /// </summary>
        public int status { get; set; }

        /// <summary>
        /// サーバーサイド時間
        /// </summary>
        public string now { get; set; }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spinpreach.SwordsDanceBase.Tables.Transactions
{
    public class Castlekeep
    {
        /// <summary>
        /// 審神者
        /// </summary>
        public string name { get; set; } = string.Empty;

        /// <summary>
        /// レベル
        /// </summary>
        public int level { get; set; } = 0;

        /// <summary>
        /// 経験値
        /// </summary>
        public long exp { get; set; } = 0;

        /// <summary>
        /// 刀剣所有可能数
        /// </summary>
        public int max_sword { get; set; } = 0;

        /// <summary>
        /// 刀装所有可能数
        /// </summary>
        public int max_equip { get; set; } = 0;

        /// <summary>
        /// 最大部隊数
        /// </summary>
        public int max_party { get; set; } = 0;

        /// <summary>
        /// 最大鍛練所
        /// </summary>
        public int forge_slot { get; set; } = 0;

        /// <summary>
        /// 最大手入部屋
        /// </summary>
        public int repair_slot { get; set; } = 0;

        public Castlekeep() { }
        public Castlekeep(Apis.Responses._login_start value)
        {
            this.name = value.name;
            this.level = value.level;
            this.exp = value.exp;
            this.max_sword = value.max_sword;
            this.max_equip = value.max_equip;
            this.max_party = value.max_party;
            this.forge_slot = value.forge_slot;
            this.repair_slot = value.repair_slot;
        }
    }
}
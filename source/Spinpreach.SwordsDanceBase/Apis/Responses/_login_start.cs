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
        public int level { get; set; }

        /// <summary>
        /// 経験値
        /// </summary>
        public long exp { get; set; }

        /// <summary>
        /// 刀剣所有可能数
        /// </summary>
        public int max_sword { get; set; }

        /// <summary>
        /// 刀装所有可能数
        /// </summary>
        public int max_equip { get; set; }

        /// <summary>
        // Tutorial(?)
        /// </summary>
        public int tutorial { get; set; }

        /// <summary>
        /// Secretary Sword ID(Party 1 Index 1,Will display in honmaru.)
        /// </summary>
        public string secretary { get; set; }

        /// <summary>
        /// 秘書刀剣シリアル(A unique number in server,used to distinguish different swords.)
        /// </summary>
        public string secretary_serial_id { get; set; }

        /// <summary>
        /// 秘書刀剣HP
        /// </summary>
        public string secretary_hp { get; set; }

        /// <summary>
        /// 秘書刀剣MAXHP
        /// </summary>
        public string secretary_hp_max { get; set; }

        /// <summary>
        /// Money(小判)
        /// </summary>
        public Currency currency { get; set; }

        /// <summary>
        ///All the items you have.(like High Speed Repair / Amulet)
        /// </summary>
        public dynamic item { get; set; }

        /// <summary>
        /// 資材情報
        /// </summary>
        public Resource resource { get; set; }

        /// <summary>
        ///List of all the equipments you have.
        /// </summary>
        public dynamic equip { get; set; }

        /// <summary>
        /// 最大部隊数
        /// </summary>
        public int max_party { get; set; }

        /// <summary>
        /// 最大鍛練所
        /// </summary>
        public int forge_slot { get; set; }

        /// <summary>
        /// 最大手入部屋
        /// </summary>
        public int repair_slot { get; set; }

        /// <summary>
        /// Background.(景趣)
        /// </summary>
        public dynamic furniture { get; set; }

        /// <summary>
        /// 部隊情報
        /// </summary>
        public Dictionary<int, Party> party { get; set; }

        /// <summary>
        /// Internal Affairs.(内番)
        /// </summary>
        public object duty { get; set; }

        /// <summary>
        /// Swords that have gone.(Already deprecated)
        /// </summary>
        public object leave { get; set; }

        /// <summary>
        /// Swords that have back.(Already deprecated)
        /// </summary>
        public object back { get; set; }

        /// <summary>
        ///Notifications.(The ad box when you log in the game)
        /// </summary>
        public News[] news { get; set; }

        /// <summary>
        /// Token.(Used to communication with game server)
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

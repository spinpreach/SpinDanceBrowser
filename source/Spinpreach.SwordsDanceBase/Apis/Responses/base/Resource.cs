using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spinpreach.SwordsDanceBase.Apis.Responses
{
    public class Resource
    {
        /// <summary>
        /// 依頼札
        /// </summary>
        public int bill { get; set; }

        /// <summary>
        /// 木炭
        /// </summary>
        public int charcoal { get; set; }

        /// <summary>
        /// 玉鋼
        /// </summary>
        public int steel { get; set; }

        /// <summary>
        /// 冷却材
        /// </summary>
        public int coolant { get; set; }

        /// <summary>
        /// 砥石
        /// </summary>
        public int file { get; set; }

        /// <summary>
        /// 資源保有最大値
        /// </summary>
        public int max_resource { get; set; }

        /// <summary>
        /// この情報を受け取ったサーバーサイド時間
        /// </summary>
        public string recovered_at { get; set; }
    }
}

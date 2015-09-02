using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spinpreach.SwordsDanceBase.Tables.Transactions
{
    public class Resource
    {
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

        /// <summary>
        /// 資源保有最大値
        /// </summary>
        public int max_resource { get; set; } = 0;

        public Resource() { }
        public Resource(Apis.Responses.Resource value)
        {
            this.bill = value.bill;
            this.charcoal = value.charcoal;
            this.steel = value.steel;
            this.coolant = value.coolant;
            this.file = value.file;
            this.max_resource = value.max_resource;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spinpreach.SwordsDanceBase.Apis.Responses
{
    public class _conquest_complete
    {
        public int success { get; set; }
        public string field_id { get; set; }
        public string party_no { get; set; }
        public Dictionary<int, Party> party { get; set; }
        public dynamic sword { get; set; }
        public dynamic summary { get; set; }
        public dynamic conquest { get; set; }
        public dynamic evolution { get; set; }
        public dynamic result { get; set; }
        public dynamic resource { get; set; }
        public dynamic item { get; set; }
        public dynamic reward { get; set; }
        public string t { get; set; }
        public int status { get; set; }
        public string now { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spinpreach.SwordsDanceBase.Apis.Responses
{
    public class _conquest_start
    {
        public Dictionary<int, Party> party { get; set; }
        public dynamic summary { get; set; }
        public string t { get; set; }
        public int status { get; set; }
        public string now { get; set; }
    }
}
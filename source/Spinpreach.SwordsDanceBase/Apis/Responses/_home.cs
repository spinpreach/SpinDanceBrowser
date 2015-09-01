using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spinpreach.SwordsDanceBase.Apis.Responses
{
    public class _home
    {
        public int mission { get; set; }
        public dynamic party { get; set; } // ここの部隊情報は使えない。
        public object[] duty { get; set; }
        public int receive { get; set; }
        public Resource resource { get; set; }
        public string t { get; set; }
        public int status { get; set; }
        public string now { get; set; }
    }
}
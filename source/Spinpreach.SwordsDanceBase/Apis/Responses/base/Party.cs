using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spinpreach.SwordsDanceBase.Apis.Responses
{
    public class Party
    {
        public int party_no { get; set; }
        public int status { get; set; }
        public string party_name { get; set; }
        public string finished_at { get; set; }
        public Dictionary<int, Slot> slot { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spinpreach.SwordsDanceBase;

namespace Spinpreach.SwordsDanceBaseExample
{
    class Program
    {
        static void Main(string[] args)
        {
            SessionWrapper sw = new SessionWrapper(8890);
            while (true) System.Threading.Thread.Sleep(1000);
        }
    }
}

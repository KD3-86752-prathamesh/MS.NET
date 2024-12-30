using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace practice28_12
{
    internal class Docs : Report
    {
        protected override void CreateReport()
        { 
            Console.WriteLine("DOCS is created"); 

        }

        protected override void ParseReport()
        {
          Console.WriteLine("DOCS is parsed");
        }

        protected override void SaveReport()
        {
            Console.WriteLine("DOCS is saved");
        }

        protected override void ValidateReposrt()
        {
            Console.WriteLine("DOCS is validated");
        }
    }
}

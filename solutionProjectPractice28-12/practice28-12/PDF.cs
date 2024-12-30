using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice28_12
{
    internal class PDF : Report
    {
        protected override void CreateReport()
        {
            Console.WriteLine("PDF report is created"); 
        }

        protected override void ParseReport()
        {
            Console.WriteLine("PDF report is parsed");
        }

        protected override void SaveReport()
        {
            Console.WriteLine("PDF report is saved"); 
        }

        protected override void ValidateReposrt()
        {
            Console.WriteLine("PDF report is validated");
        }
    }
}

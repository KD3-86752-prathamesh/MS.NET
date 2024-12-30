using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice28_12
{
    internal class ReportFactory
    {

        public Report GetReport(int choice)
        {

            if (choice == 1)
            {
                return new PDF();
            }
            else if (choice == 2)
            {
                return new Docs();
            }
            else if (choice == 3)
            {
                return new XMl(); 
            }
            else
            {
                return null;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice28_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReportFactory rf = new ReportFactory();
            Console.WriteLine("1.pdf 2.DOCS 3.XML ");
            int choice = Convert.ToInt32(Console.ReadLine()); 
           Report rp =  rf.GetReport(choice);
            rp.CallMethods(); 
            Logger.GetLogger().Log("pdf obj is created"); 

        }
    }
}

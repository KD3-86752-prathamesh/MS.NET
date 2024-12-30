using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace practice28_12
{
    internal class XMl : SpecialReport
    {
        protected override void CreateReport()
        {
            Console.WriteLine("XML report is created ");
            Logger.GetLogger().Log("xml reort is created ");  
        }

        protected override void ParseReport()
        {
            Console.WriteLine("XML report is parsed ");
            Logger.GetLogger().Log("xml reopr is parsed  ");
        }

        protected override void SaveReport()
        {
            Console.WriteLine("XML reort is saved");
            Logger.GetLogger().Log("xml reort is saved");
        }

        protected override void ValidateReposrt()
        {
            Console.WriteLine("XML report is validated");
            Logger.GetLogger().Log("xml reort is validated"); 
        }

        protected override void RevalidteReport()
        {
            Console.WriteLine("XML is report is revalidated ");
            Logger.GetLogger().Log("xml reort is revalidated ");
        }
    }
}

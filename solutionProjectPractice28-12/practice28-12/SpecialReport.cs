using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice28_12
{
    internal abstract class SpecialReport : Report
    {


        protected abstract void RevalidteReport(); 
        public override void CallMethods()
        {
            CreateReport();
            ParseReport();
            ValidateReposrt();
            SaveReport();
            RevalidteReport();
        }

    }
}

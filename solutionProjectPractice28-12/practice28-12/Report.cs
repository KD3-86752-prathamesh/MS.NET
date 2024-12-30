using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice28_12
{
    internal abstract class Report
    {

        protected abstract void CreateReport();

        protected abstract void ValidateReposrt();

        protected abstract void ParseReport();

        protected abstract void SaveReport();

        public virtual void CallMethods()
        {
            CreateReport(); 
            ParseReport();
            ValidateReposrt();
            SaveReport();
        }


    }
}

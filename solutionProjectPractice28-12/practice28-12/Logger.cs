using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice28_12
{
    internal class Logger
    {
        private Logger() { }

        public static Logger GetLogger()   
        {
            return Instance;
        } 

    static  Logger Instance = new Logger();

        public void  Log (string message)
        {
            Console.WriteLine("time" + DateTime.Now.ToString() + message);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace BitRush.NET
{
    class Program
    {
        private static ILog Logger = LogManager.GetLogger(typeof(Program));
        
        static void Main(string[] args)
        {
            Logger.InfoFormat("Starting application with args: {0}", args);
        }
    }
}

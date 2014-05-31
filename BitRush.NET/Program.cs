using System;
using log4net;

namespace BitRushNET.BackupRunner
{
    class Program
    {
        private static readonly ILog Logger = LogManager.GetLogger(typeof(Program));
        
        static void Main(string[] args)
        {
			Logger.InfoFormat("Starting application with args: {0}", args);
			Console.ReadLine();
        }
    }
}

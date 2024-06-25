using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    public sealed class Logger
    {
        private static Logger logger = null;
        private static readonly object padlock = new object();
        private Logger() { }

        public static Logger Instance {
            get 
            {
                lock (padlock) 
                {
                    if (logger == null)
                        logger = new Logger();
                    return logger;
                } 
            }
        }

        public void LogMessage(string message)
        {
            //code to log message
            Console.WriteLine(message);
        }
    }
}

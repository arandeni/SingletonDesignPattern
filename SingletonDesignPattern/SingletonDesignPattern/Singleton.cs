using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    public sealed class Singleton
    {
        private static Singleton instance = null;
        private Singleton() { }

        //using property
        public static Singleton Instance
        {
            get
            {
                if (instance == null) { 
                    instance = new Singleton();
                }
                return instance;
            }
        }

        //using method
        public static Singleton GetInstance() 
        {
            if(instance == null)
                instance = new Singleton();

            return instance;
        }

    }
}

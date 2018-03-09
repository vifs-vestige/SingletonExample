using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample
{
    class ConfigLoader
    {
        private static ConfigLoader Instance;

        //We use a private constructors so other classes can't make it's own version
        private ConfigLoader() { }

        //We are putting a lock on Instance, this makes it thread safe
        //If different threads try to get instance at the same time, whatever thread hit it first well make it
        //In single threaded applications, this is not needed
        public static ConfigLoader GetInstance()
        {
            if(Instance == null)
            {
                lock (Instance)
                {
                    if (Instance == null)
                        Instance = new ConfigLoader();
                }
            }
            return Instance;
        }

        public string GetConfig()
        {
            return "We got some config stuff, woo";
        }
    }
}

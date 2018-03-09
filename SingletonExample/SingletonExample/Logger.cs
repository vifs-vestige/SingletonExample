using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample
{
    class Logger
    {
        private static Logger Instance;

        //We don't make the object till it is needed, this is called Lazy Loading
        //Lazy loading can be used to make a program more efficient
        public static Logger GetInstance()
        {
            if (Instance == null){
                Instance = new Logger();
            }
            return Instance;
        }

        //We use a private constructors so other classes can't make it's own version
        private Logger()
        {

        }

        
        public void LogStuff(string s)
        {
            Console.WriteLine(s);
        }

    }
}

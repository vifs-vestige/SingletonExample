using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger.GetInstance().LogStuff("First line of code in Main");
            Logger.GetInstance().LogStuff("Loaded from config: " + ConfigLoader.GetInstance().GetConfig());
            Logger.GetInstance().LogStuff("Got from Database: " + Database.GetInstance().GetStuffFromDB());
            Logger.GetInstance().LogStuff("Enough examples, bye");

        }
    }
}

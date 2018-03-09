using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample
{
    class Database
    {
        //because this variable is static, it is instantiated  when the class is loaded
        //This way is also thread safe because it's ran before any code could even touch it
        private static Database Instance = new Database();

        //We use a private constructors so other classes can't make it's own version
        private Database() { }

        public static Database GetInstance()
        {
            return Instance;
        }

        public string GetStuffFromDB()
        {
            return "Pretend this is a table";
        }
    }
}

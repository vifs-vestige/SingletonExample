using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExample
{
    class Array
    {

        public Array()
        {
            //normal arrays need to have a set size, in this case, 5
            string[] array = new string[5];
            array[0] = "bob";
            array[1] = "jim";
            array[2] = "john";
            array[3] = "larry";
            array[4] = "hank";

            Console.WriteLine(array[4] + " really enjoys cheeseburgers");
            Console.WriteLine("");
        }
    }
}

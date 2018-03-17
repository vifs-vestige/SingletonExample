using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExample
{
    class DynamicArray
    {

        public DynamicArray()
        {
            //list in C# is a resizeable array, kinda
            //not to be confused with a link list
            List<int> numbers = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                numbers.Add(i);
            }
            Console.WriteLine("List size is " + numbers.Count());
            for (int i = 5; i < 10; i++)
            {
                numbers.Add(i);
            }
            Console.WriteLine("List size now " + numbers.Count());
            numbers.ForEach(x => Console.Write(x));
            Console.WriteLine("");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //pretty much every array, collections, whatever, in C# are 0 based
            new Array();
            MultiDimensionalArray.TwoDArray();
            MultiDimensionalArray.ThreeDArray();
            new DynamicArray();
            Console.ReadLine();
        }
    }
}

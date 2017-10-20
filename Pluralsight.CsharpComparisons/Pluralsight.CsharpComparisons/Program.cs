using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pluralsight.CsharpComparisons
{
    class Program
    {
        static void Main(string[] args)
        {
            string apple = "apple";
            string pear = "pear";

            //Console.WriteLine(apple.CompareTo(pear));
            //Console.WriteLine(pear.CompareTo(apple));
            //Console.WriteLine(apple.CompareTo(apple));
            DisplayOrder(apple,pear);
            DisplayOrder(pear,apple);
            DisplayOrder(apple,apple);
        }

        static void DisplayOrder<T>(T x, T y) where T : IComparable<T>
        {
            int result = x.CompareTo(y);
            if (result == 0)
                Console.WriteLine("{0,12} = {1}", x, y);
            else if (result > 0)
                Console.WriteLine("{0,12} > {1}", x, y);
            else
                Console.WriteLine("{0,12} < {1}", x, y);
        } 
    }
}

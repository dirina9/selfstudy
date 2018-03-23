using System;

namespace Pluralsight.arrays
{
    public class ArraysAsRefTypes
    {
        public void ArraysAsRefTypesExample()
        {
            int[] x1 = { 1, 4, 9, 16 };
            WriteXArray(x1);
            var x2 = x1;
            WriteXArray(x2);
            int[] x3 = { 1, 4, 9, 16 };
            WriteXArray(x3);

            Console.WriteLine("RefEquals(x1, x2): " + ReferenceEquals(x1, x2));
            Console.WriteLine("x1=x2 is {0}" , x1 == x2);
            Console.WriteLine("x1=x3 is {0}", x1 == x3);
        }

        private void WriteXArray(int[] x)
        {
            Console.WriteLine(string.Join(" ", x));
        }
    }
}
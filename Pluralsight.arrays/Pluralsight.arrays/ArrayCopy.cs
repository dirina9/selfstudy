using System;

namespace Pluralsight.arrays
{
    public class ArrayCopy
    {
        public void ArrayCopyExample()
        {
            int[] squares = {1, 4, 9, 16};

            int[] copy = new int[8];
            squares.CopyTo(copy, 2);

            foreach (int value in copy)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine("squares == copy? {0}", squares == copy);
        }
    }
}
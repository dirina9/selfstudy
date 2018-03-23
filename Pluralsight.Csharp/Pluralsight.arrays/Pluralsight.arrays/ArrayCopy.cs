using System;

namespace Pluralsight.arrays
{
    public class ArrayCopy
    {
        public void ArrayCopyExample()
        {
            int[] squares = {1, 4, 9, 16};
            Console.WriteLine("Исходное значение:");
            Console.WriteLine(string.Join(" ", squares));
            int[] copy = new int[8];

            Console.WriteLine("Копируем со 2 индекса в массиве назначения:");
            squares.CopyTo(copy, 2);
            Console.WriteLine(string.Join(" ", copy));
            Console.WriteLine("squares == copy? {0}", squares == copy);
        }
    }
}
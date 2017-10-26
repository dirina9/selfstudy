using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pluralsight.CSharpEquality.Structural
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] arr1 = { "apple", "orange", "pineapple" };
            string[] arr2 = { "apple", "pear", "pineapple" };

            //Console.WriteLine(arr1 == arr2);
            //Console.WriteLine(arr1.Equals(arr2));
            var arrayEq = (IStructuralEquatable) arr1;
            bool structEqual = arrayEq.Equals(arr2, StringComparer.OrdinalIgnoreCase);
            Console.WriteLine(structEqual);

            var arrayComp = (IStructuralComparable)arr1;
            int structComp = arrayComp.CompareTo(arr2, StringComparer.OrdinalIgnoreCase);
            Console.WriteLine(structComp);

        }
    }
}

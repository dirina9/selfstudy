using System;
using System.Security.Cryptography.X509Certificates;

namespace Pluralsight.CSharpEquality.FoodEquals
{
    class Program
    {
        static void Main(string[] args)
        {
            Food banana = new Food("banana");
            Food banana2 = new Food("banana");
            Food chocolate = new Food("chocolate");
            /*string banana = "banana";
            string banana2 = String.Copy(banana);*/

            Console.WriteLine(banana.Equals(chocolate));
            /*Console.WriteLine(banana);
            Console.WriteLine(banana2);*/
            Console.WriteLine(ReferenceEquals(banana,banana2));
            //Console.WriteLine(banana.Equals(banana2));

        }
    }
}

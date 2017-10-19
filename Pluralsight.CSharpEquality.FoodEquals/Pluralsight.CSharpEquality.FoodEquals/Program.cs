using System;

namespace Pluralsight.CSharpEquality.FoodEquals
{
    class Program
    {
        static void Main(string[] args)
        {
            Food banana = new Food("banana");
            Food banana2 = new Food("banana");
            Food chocolate = new Food("chocolate");

            Console.WriteLine(banana.Equals(chocolate));
            Console.WriteLine(banana.Equals(banana2));
        }
    }
}

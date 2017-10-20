using System;
using System.Security.Cryptography.X509Certificates;

namespace Pluralsight.CSharpEquality.FoodEquals
{
    class Program
    {
        static void Main(string[] args)
        {
            Food apple = new Food("apple", FoodGroup.Fruit);
            CookedFood stewedApple = new CookedFood("stewed", "apple", FoodGroup.Fruit);

            Console.WriteLine(apple);
            Console.WriteLine(stewedApple);

        }
    }
}

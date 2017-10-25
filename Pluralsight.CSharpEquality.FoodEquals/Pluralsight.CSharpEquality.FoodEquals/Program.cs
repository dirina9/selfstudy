using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Pluralsight.CSharpEquality.FoodEquals
{
    class Program
    {
        static void Main(string[] args)
        {
            Food apple = new Food("apple", FoodGroup.Fruit);
            CookedFood stewedApple = new CookedFood("stewed", "apple", FoodGroup.Fruit);
            CookedFood bakedApple = new CookedFood("baked", "apple", FoodGroup.Fruit);
            CookedFood stewedApple2 = new CookedFood("stewed","apple", FoodGroup.Fruit);
            Food apple2 = new Food("apple", FoodGroup.Fruit);

            Console.WriteLine(apple);
            Console.WriteLine(stewedApple);
            DisplayWhetherEqual(apple, stewedApple);
            DisplayWhetherEqual(stewedApple,bakedApple);
            DisplayWhetherEqual(stewedApple,stewedApple2);
            DisplayWhetherEqual(apple,apple2);
            DisplayWhetherEqual(apple,apple);

            bool areEqual = string.Equals("Apple", "Pineapple", StringComparison.CurrentCultureIgnoreCase);
            Console.WriteLine(areEqual);

            //To do an equals for which there is no Equals() method:
            int cmpResult = string.Compare(
                "Apple", "Pineapple", CultureInfo.GetCultureInfo("fr-FR"), CompareOptions.IgnoreSymbols);
            areEqual = (cmpResult == 0);

            //case-sensitive ordinal:
            areEqual = ("Apple" == "Pineapple");

            string apple1 = "Apple";
            string apple3 = "Ap" + "ple";
            Console.WriteLine(String.Format("strings are {0} and {1}", apple1,apple3));
            Console.WriteLine(apple1 == apple3);
            Console.WriteLine(ReferenceEquals(apple1,apple3));

            Food[] list =
            {
                new Food("orange", FoodGroup.Fruit),
                new Food("banana", FoodGroup.Fruit),   
                new Food("pear", FoodGroup.Fruit), 
                new Food("apple", FoodGroup.Fruit)};

            Array.Sort(list, FoodNameComparer.Instance);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }

        static void DisplayWhetherEqual(Food food1, Food food2)
        {
            if(food1 == food2)
                Console.WriteLine(String.Format("{0,12}=={1}", food1,food2));
            else
            {
                Console.WriteLine( String.Format("{0,12} != {1}", food1,food2));
            }
        }
    }
}

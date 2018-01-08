using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace _1_fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your name:");
            string name = Console.ReadLine();
            Console.WriteLine("How many hours of sleep did you getlast night?");
            int hoursOfSleep = int.Parse(Console.ReadLine());
            Console.WriteLine("Hello," + name);
            if (hoursOfSleep > 8)
            {
                Console.WriteLine("You are well rested");
            }
            else
            {
                Console.WriteLine("You need more sleep");
            }
        }
    }
}

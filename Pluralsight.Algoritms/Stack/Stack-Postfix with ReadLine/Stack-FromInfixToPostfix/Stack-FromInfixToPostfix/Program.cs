using System;

namespace Stack_FromInfixToPostfix
{
    class Program
    {
        static void Main()
        {
            string str = TakeString();
            if (str==null)
            {
                Console.WriteLine("Incorrect value");
            }
            Calculator.Calculate(str);
        }

        static string TakeString()
        {
            Console.WriteLine("Please, write infix:");
            return Console.ReadLine();
        }
    }
}

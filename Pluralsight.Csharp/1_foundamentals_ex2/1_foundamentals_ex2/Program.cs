using System;
namespace _1_foundamentals_ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            IGradeTracker book = CreateGradeBook();
            EnterBookName();
            book.Name = Console.ReadLine();
            book.WriteGrades(Console.Out);
            GradeStatistics stats = book.ComputeStatistics();
            stats.ShowResults();
        }

       static void EnterBookName()
        {
            try
            {
                Console.WriteLine("Enter a name");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        private static IGradeTracker CreateGradeBook()
        {
            return new ThrowAwayGradeBook();
        }

    }

}

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace _1_foundamentals_ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            IGradeTracker book = CreateGradeBook();
            try
            {
                Console.WriteLine("Enter a name");
                book.Name = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            book.WriteGrades(Console.Out);

            GradeStatistics stats = book.ComputeStatistics();
            stats.ShowResults();
        }


        private static IGradeTracker CreateGradeBook()
        {
            return new ThrowAwayGradeBook();
        }


    }
}

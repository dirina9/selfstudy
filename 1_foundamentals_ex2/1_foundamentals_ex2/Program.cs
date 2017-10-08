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

            /*book.NameChanged += OnNameChanged;*/
            try
            {
                Console.WriteLine("Enter a name");
                book.Name = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            /*book.Name = "Scott`s grade book";
            book.Name = "grade book";*/

            foreach (var grade in book)
            {
                Console.WriteLine(grade);
            }
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);
            //book.Name = null;
            book.WriteGrades(Console.Out);

            GradeStatistics stats = book.ComputeStatistics();
            /*Console.WriteLine(book.Name);*/


            WriteResult("Highest", stats.HighestGrade);
            WriteResult("Average", stats.AverageGrade);
            WriteResult("Lowest", stats.LowestGrade);
            WriteResult(stats.Description, stats.LetterGrade);
        }

        private static IGradeTracker CreateGradeBook()
        {

            //SpeechSynthesizer synth = new SpeechSynthesizer();
            //synth.Speak("hello! This is the program");

            return new ThrowAwayGradeBook();
        }

        /* static void OnNameChanged(object sender, NameChangedEventArgs args)
         {
             Console.WriteLine($"GradeBook changed name from {args.ExistingName} to {args.NewName}");
         }*/


        /*static void WriteResult(string description, int result)
        {
            Console.WriteLine(description + ":" + result);
        }*/

        static void WriteResult(string description, string result)
        {
            Console.WriteLine($"{description}:{result}", description, result);
        }

        static void WriteResult(string description, float result)
        {
            Console.WriteLine("{0}:{1:F2}", description, result);
        }


    }
}

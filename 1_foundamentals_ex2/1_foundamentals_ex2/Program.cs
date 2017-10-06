using System;
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

            //SpeechSynthesizer synth = new SpeechSynthesizer();
            //synth.Speak("hello! This is the program");
            //GradeBook book;
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);
            book.AddGrade(89);
            GradeStatistics stats = book.ComputeStatistics();

            //GradeBook book2 = new GradeBook();
            //book2.AddGrade(75);
            //book2 = book;
            //book.AddGrade(2);

            Console.WriteLine(stats.HighestGrade);
            Console.WriteLine(stats.AverageGrade);
            Console.WriteLine(stats.LowestGrade);

        }
    }
}

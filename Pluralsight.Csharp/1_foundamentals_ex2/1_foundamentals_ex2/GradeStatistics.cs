using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_foundamentals_ex2
{
    public class GradeStatistics
    {
        public GradeStatistics()
        {
            HighestGrade = 0;
            LowestGrade = float.MaxValue;

        }

        public void ShowResults()
        {
            WriteResult("Highest", HighestGrade);
            WriteResult("Average", AverageGrade);
            WriteResult("Lowest", LowestGrade);
            WriteResult(Description, LetterGrade);

        }
       

        static void WriteResult(string description, string result)
        {
            Console.WriteLine("{0}:{1}", description, result);
        }

        static void WriteResult(string description, float result)
        {
            Console.WriteLine("{0}:{1:F2}", description, result);
        }

        public string Description
        {
            get
            {
                string result;
                switch (LetterGrade)
                {
                    case "A":
                        result = "Excellent";
                        break;
                    case "B":
                        result = "Good";
                        break;
                    case "C":
                        result = "Average";
                        break;
                    case "D":
                        result = "Below Average";
                        break;
                    default:
                        result = "Failing";
                        break;
                }
                return result;
            }
        }
        public string LetterGrade
        {
            get
            {
                string result;
                if (AverageGrade >= 90)
                {
                    result = "A";
                }
                else if (AverageGrade >= 80)
                {
                    result = "B";
                }
                else if (AverageGrade >= 70)
                {
                    result = "C";
                }
                else if (AverageGrade >= 60)
                {
                    result = "D";
                }
                else
                {
                    result = "F";
                }
                return result;

            }
        }
        public float AverageGrade;
        public float HighestGrade;
        public float LowestGrade;
    }
}

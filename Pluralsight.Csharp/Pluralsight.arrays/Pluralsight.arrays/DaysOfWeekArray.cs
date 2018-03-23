using System;
using System.Collections.Generic;
using System.Linq;

namespace Pluralsight.arrays
{
    public class DaysOfWeekArray
    {
        public void StartDaysOfWeekArrayExample()
        {
            String[] daysOfWeek =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };
            daysOfWeek[5] = "PartyDay";
            Array.Reverse(daysOfWeek);
            var reverse2Times = daysOfWeek.Reverse();

            Console.WriteLine("Reverse array two times:");
            foreach (string day in reverse2Times)
            {
                Console.WriteLine(day);
            }
            Console.WriteLine("");

            Console.WriteLine("Make days plural (+s):");
            MakeDaysPlural(daysOfWeek);
            WriteLineArray(daysOfWeek);

            Console.WriteLine("After sorting elements by using the default comparer:");
            Array.Sort(daysOfWeek);
            WriteLineArray(daysOfWeek);

            Console.WriteLine("After sorting elements by using the String Length Comparer:");
            var comparer = new StringLengthComparer();
            Array.Sort(daysOfWeek,comparer);
            WriteLineArray(daysOfWeek);

            Console.WriteLine("After finding index of element with W:");
            int indexOfW = Array.FindIndex(daysOfWeek, x => x[0] == 'W');
            Console.WriteLine(indexOfW);
            Console.WriteLine("Element:");
            Console.WriteLine(daysOfWeek[indexOfW]);
            Console.WriteLine("");


            String[] sortedDays =
            {
                "Friday",
                "Monday",
                "Saturday",
                "Sunday",
                "Thursday",
                "Tuesday",
                "Wednesday"
            };
            Console.WriteLine("Sorted days list:");
            WriteLineArray(sortedDays);
            int indexOfSunday = Array.BinarySearch(sortedDays, "Sunday");
            Console.WriteLine("Index of Sunday is " + indexOfSunday);
        }

        class StringLengthComparer : IComparer<string>
        {
            public int Compare(string x, string y)
            {
                return x.Length.CompareTo(y.Length);
            }
        }
        static void MakeDaysPlural(string[] daysOfWeek)
        {
            for (int i = 0; i < daysOfWeek.Length; i++)
            {
                daysOfWeek[i] = daysOfWeek[i] + "s";
            }
        }

        public void WriteLineArray(string[] daysOfWeek)
        {
            foreach (string day in daysOfWeek)
            {
                Console.WriteLine(day);
            }
            Console.WriteLine("");
        }
    }
}
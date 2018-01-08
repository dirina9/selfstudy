using System;
using System.Collections.Generic;
using System.Linq;

namespace Pluralsight.arrays
{
    public class DaysOfWeekArray
    {
        public void StartDaysOfWeekArrayExample()
        {
            String monday = "Monday";
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
            var reversed = daysOfWeek.Reverse();

            foreach (string day in reversed)
            {
                Console.WriteLine(day);
            }
            MakeDaysPlural(daysOfWeek);
            WriteLineArray(daysOfWeek);

            Array.Sort(daysOfWeek);
            WriteLineArray(daysOfWeek);

            Console.WriteLine("");
            var comparer = new StringLengthComparer();
            Array.Sort(daysOfWeek,comparer);
            WriteLineArray(daysOfWeek);

            int indexOfW = Array.FindIndex(daysOfWeek, x => x[0] == 'W');
            Console.WriteLine(indexOfW);
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
            int indexOfSun = Array.BinarySearch(sortedDays, "Sunday");
            Console.WriteLine("Index is " + indexOfSun);
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
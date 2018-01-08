using System;

namespace Pluralsight.arrays
{
    public class Program
    {
        static void Main(string[] args)
        {
            var daysOfWeekArray = new DaysOfWeekArray();
            daysOfWeekArray.StartDaysOfWeekArrayExample();
            Console.WriteLine("");

            var peopleArray = new PeopleArray();
            peopleArray.PeopleArrayExample();
            Console.WriteLine("");

            var arraysAsRefTypes = new ArraysAsRefTypes();
            arraysAsRefTypes.ArraysAsRefTypesExample();
            Console.WriteLine("");

            var objArray = new ObjArray();
            objArray.ObjArrayExample();
            Console.WriteLine("");

            var arraycopy = new ArrayCopy();
            arraycopy.ArrayCopyExample();
            Console.WriteLine("");

            int x1;
            int[] x2;
            int x3 = 5;
            int[] x4 = new int[5];
            Console.WriteLine(x4[0]);

            int[] x5 = new int[5] {1, 4, 9, 16, 25};
        }
    }
}

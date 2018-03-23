using System;

namespace Pluralsight.arrays
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start Days Of Week Array Example"); 
            var daysOfWeekArray = new DaysOfWeekArray();
            daysOfWeekArray.StartDaysOfWeekArrayExample();
            Console.WriteLine("");

            Console.WriteLine("Start People Array Example"); 
            var peopleArray = new PeopleArray();
            peopleArray.PeopleArrayExample();
            Console.WriteLine("");

            Console.WriteLine("Start Array As Ref Types Example"); 
            var arraysAsRefTypes = new ArraysAsRefTypes();
            arraysAsRefTypes.ArraysAsRefTypesExample();
            Console.WriteLine("");

            Console.WriteLine("Start Object Array Example"); 
            var objArray = new ObjArray();
            objArray.ObjArrayExample();
            Console.WriteLine("");

            Console.WriteLine("Start Array Copy Example"); 
            var arraycopy = new ArrayCopy();
            arraycopy.ArrayCopyExample();
            Console.WriteLine("");
        }
    }
}

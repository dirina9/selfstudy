using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_myself
{
    class Program
    {
        static void Main(string[] args)
        {
            var kitisStudent = new KitisStudent("Petrov", "Math");
            kitisStudent.PassExam();
            var cheater = new Cheatting(kitisStudent);
            cheater.PassExam();
            var ipovsStudent = new IpovsStudent("Seregin", "History");
            ipovsStudent.PassExam();
            var horoshist = new CorrectExam(ipovsStudent);
            horoshist.PassExam();
        }
    }
}

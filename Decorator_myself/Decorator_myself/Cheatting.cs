using System;

namespace Decorator_myself
{
    public class Cheatting : Decorator
    {
        public Cheatting(Student concreteStudent) : base(concreteStudent)
        {
        }

        public void PassExam()
        {
            Console.WriteLine("!!! Cheat");
            base.PassExam();
        }
    }
}
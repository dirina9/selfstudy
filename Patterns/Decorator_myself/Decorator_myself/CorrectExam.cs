using System;

namespace Decorator_myself
{
    public class CorrectExam : Decorator
    {
        public CorrectExam(Student concreteStudent) : base(concreteStudent)
        {
        }

        public new void PassExam()
        {
            Console.WriteLine("!!! Correctly");
            base.PassExam();
        }
    }
}
using System;

namespace Decorator_myself
{
    public class KitisStudent : Student
    {
        private string name;
        private string kaf = "kitis";
        private string subject;
        public KitisStudent(string name, string subject)
        {
            this.name = name;
            this.subject = subject;
        }
        public override void PassExam()
        {
            Console.WriteLine("pass {0} exam by {1} ({2})",subject,name,kaf);
        }
    }
}
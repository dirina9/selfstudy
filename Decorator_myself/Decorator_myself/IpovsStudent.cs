using System;
using System.Security.Cryptography.X509Certificates;

namespace Decorator_myself
{
    public class IpovsStudent : Student
    {
        private string name;
        private string kaf = "ipovs";
        private string subject;

        public IpovsStudent(string name, string subject)
        {
            this.name = name;
            this.subject = subject;
        }

        public override void PassExam()
        {
            Console.WriteLine("pass {0} exam by {1} ({2})", subject, name, kaf);
        }
    }
}
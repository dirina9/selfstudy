namespace Decorator_myself
{
    abstract public class Decorator
    {
        protected Student student;

        public Decorator(Student concreteStudent)
        {
            this.student = concreteStudent;
        }

        public void PassExam()
        {
            student.PassExam();
        }
    }
}
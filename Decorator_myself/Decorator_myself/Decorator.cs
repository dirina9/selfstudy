namespace Decorator_myself
{
    abstract public class Decorator
    {
        private Student student;

        protected Decorator(Student concreteStudent)
        {
            this.student = concreteStudent;
        }

        protected void PassExam()
        {
            student.PassExam();
        }
    }
}
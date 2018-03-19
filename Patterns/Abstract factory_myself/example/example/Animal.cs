using System;

namespace example
{
    public abstract class Animal: IAnimal
    {
        private readonly string _name;

        protected Animal(string name)
        {
            _name = name;
        }

        public virtual void Walk()
        {
            Console.WriteLine("From abstract");
        }
    }
}
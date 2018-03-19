using Interfaces;
using System;

namespace Animals
{
    public class Lion : ICarnivore
    {
        virtual public void Eat(IHerbivore herbivore)
        {
            Console.WriteLine(this.GetName() + " eats " + herbivore.GetName());
        }

        virtual public string GetName()
        {
            return "lion";
        }
        public void Update(string food)
        {
            Console.WriteLine("Notified {0} of {1}", GetName(), food);
        }
    }
}

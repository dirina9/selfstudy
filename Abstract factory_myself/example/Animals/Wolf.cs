using Interfaces;
using System;

namespace Animals
{
    public class Wolf : ICarnivore
    {
        public void Eat(IHerbivore herbivore)
        {
            Console.WriteLine(this.GetName() + " eats " + herbivore.GetName());
        }

        public string GetName()
        {
            return "wolf";
        }
        public void Update(string food)
        {
            Console.WriteLine("Notified {0} of {1}", GetName(), food);
        }
    }
}
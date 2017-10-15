using Interfaces;
using System;

namespace Animals
{
    public class Lion : ICarnivore
    {
        virtual public void Eat(IHerbivore herbivore)
        {
            Console.WriteLine(this.GetType().Name + " eats " + herbivore.GetType().Name);
        }
    }
}

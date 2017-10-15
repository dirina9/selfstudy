
using Interfaces;
using System;

namespace Animals
{
    public class SmallLion : Lion
    {
        override public void Eat(IHerbivore herbivore)
        {
            Console.WriteLine(this.GetType().Name + " play with " + herbivore.GetType().Name);
        }
    }
}

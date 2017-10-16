
using Interfaces;
using System;

namespace Animals
{
    public class SmallLion : Lion
    {
        override public void Eat(IHerbivore herbivore)
        {
            Console.WriteLine(this.GetName() + " play with " + herbivore.GetName());
        }

        public override string GetName()
        {
            return "small" + base.GetName();
        }
    }
}

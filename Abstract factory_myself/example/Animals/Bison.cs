using System;
using Interfaces;

namespace Animals
{
    public class Bison : IHerbivore
    {
        public string GetName()
        {
            return "bizon";
        }

        public void Update(string food)
        {
            Console.WriteLine("Notified {0} of {1}", GetName(), food);
        }
    }
}

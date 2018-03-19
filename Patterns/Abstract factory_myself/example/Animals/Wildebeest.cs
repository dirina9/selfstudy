using System;
using Interfaces;

namespace Animals
{
    public class Wildebeest : IHerbivore
    {
        public string GetName()
        {
            return "wildebeest";
        }
        public void Update(string food)
        {
            Console.WriteLine("Notified {0} of {1}", GetName(), food);
        }
    }
}

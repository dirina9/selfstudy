using System;
using example;

namespace DoFactory.GangOfFour.Abstract.RealWorld
{
    /// <summary>
    /// MainApp startup class for Real-World
    /// Abstract Factory Design Pattern.
    /// </summary>
    class MainApp
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        public static void Main()
        {
            // Create and run the African animal world
            IContinent continent = new Africa();
            IHerbivore heribove = continent.CreateHerbivore();
            ICarnivore carnivore = continent.CreateCarnivore();
            carnivore.Eat(heribove);

            continent = new America();
            heribove = continent.CreateHerbivore();
            carnivore = continent.CreateCarnivore();
            carnivore.Eat(heribove);

        }
    }
}
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
        public static void Main()
        {
            // Create and run the African animal world
            IContinent continent = new Africa();
            IHerbivore herbivore = continent.CreateHerbivore();
            ICarnivore carnivore = continent.CreateCarnivore();
            carnivore.Eat(herbivore);

            continent = new America();
            herbivore = continent.CreateHerbivore();
            carnivore = continent.CreateCarnivore();
            carnivore.Eat(herbivore);

        }
    }
}
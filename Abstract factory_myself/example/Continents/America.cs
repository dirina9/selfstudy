using Animals;
using Interfaces;

namespace Continents
{
    public class America : IContinent
    {
        public ICarnivore CreateCarnivore()
        {
            return new Wolf();
        }

        public IHerbivore CreateHerbivore()
        {
            return new Bison();
        }
    }
}

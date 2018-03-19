using Animals;
using Interfaces;

namespace Continents
{
    public class Africa : IContinent
    {
        public ICarnivore CreateCarnivore()
        {
            return new Lion();
        }

        public IHerbivore CreateHerbivore()
        {
            return new Wildebeest();
        }

        public SmallLion createSmallLion()
        {
            return new SmallLion();
        }
    }
}

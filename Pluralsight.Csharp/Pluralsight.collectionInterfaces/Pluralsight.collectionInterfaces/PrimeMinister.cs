namespace Pluralsight.collectionInterfaces
{
    public class PrimeMinister
    {
        public string Name { get; private set; }
        public int YearElected { get; private set; }

        public PrimeMinister(string name, int year)
        {
            this.Name = name;
            this.YearElected = year;
        }

        public override string ToString()
        {
            return string.Format("{0}, elected: {1}", Name, YearElected);
        }
    }
}
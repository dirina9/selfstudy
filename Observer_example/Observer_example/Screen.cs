using System;

namespace Observer_example
{
    class Screen : IScreens
    {
        private string name;

        public Screen(string new_name)
        {
            this.name = new_name;
        }
        public void Update(Parking parking)
        {
            Console.WriteLine("Notified {0} change to {1}", name, parking.Places);
        }
    }
}

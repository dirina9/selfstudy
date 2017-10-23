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
        public void Update(int places)
        {
            Console.WriteLine("Notified {0}: count of places was changed to {1}", name, places);
        }
    }
}

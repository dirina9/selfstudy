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

        public void Attention(string m, string n)
        {
            Console.WriteLine("Owner of car " + m + " with the number " + n + ". Please, go to contact center!");
        }

    }
}

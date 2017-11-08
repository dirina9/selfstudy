using System;

namespace Observer_example
{
    class Screen : IScreen
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

        public void OnCarCrashHandler(string model, string number)
        {
            Console.WriteLine("SCREEN:{0} The owner of {1} № {2}. Please, go to contact center!", this.name, model, number);
        }
    }
}

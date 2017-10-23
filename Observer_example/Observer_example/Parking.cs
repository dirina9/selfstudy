using System;
using System.Collections.Generic;

namespace Observer_example
{
    class Parking
    {
        private int places { get; set; }
        private readonly List<IScreens> screens = new List<IScreens>();
        public delegate void MethodContainer();
        public event MethodContainer OnCarArrive;
        public event MethodContainer OnCarLeft;

        public int Places
        {
            get { return this.places; }
        }

        public Parking(int places)
        {
            this.places = places;
        }

        public void Attach(IScreens screen)
        {
            screens.Add(screen);
        }

        public void Detach(IScreens screen)
        {
            screens.Remove(screen);
        }

        public void Notify()
        {
            foreach (var screen in screens)
            {
                if (places > 0)
                {
                    screen.Update(places); 
                }
                else
                {
                    Console.WriteLine("There are no free places");

                }
            }
        }

        public void CarArrive()
        {
            places--;
            if (OnCarArrive != null) OnCarArrive();
        }

        public void CarLeft()
        {
            places++;
            if (OnCarLeft != null) OnCarLeft();
        }
    }
}

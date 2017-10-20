using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Observer_example
{
    class Parking
    {
        private int places { get; set; }
        private readonly List<IScreens> screens = new List<IScreens>();

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

        private void Notify()
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
            Notify();
        }
        public void CarLeft()
        {
            places++;
            Notify();
        }
    }
}

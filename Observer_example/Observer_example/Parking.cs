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
        public int Places;
        private List<IScreens> Screens = new List<IScreens>();

        public Parking(int places)
        {
            this.Places = places;
        }

        public void Attach(IScreens screen)
        {
            Screens.Add(screen);
        }

        public void Detach(IScreens screen)
        {
            Screens.Remove(screen);
        }

        public void Notify()
        {
            foreach (var screen in Screens)
            {
                if (Places > 0)
                {
                    screen.Update(this);
                }
                else
                {
                    Console.WriteLine("There are no free places"); 
                    
                }
            }
        }

        public void CarArrive()
        {
            Places--;
            Notify();
        }
        public void CarLeft()
        {
            Places++;
            Notify();
        }
    }
}

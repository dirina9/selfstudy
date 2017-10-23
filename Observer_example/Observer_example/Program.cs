using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_example
{
    class Program
    {
        static void Main(string[] args)
        {
            Parking parking = new Parking(50);
            parking.OnCarArrive += parking.Notify;
            parking.OnCarLeft += parking.Notify;
            parking.Attach(new Screen("screen1"));
            IScreens screen = new Screen("screen2");

            parking.Attach(screen);
            parking.CarArrive();
            parking.CarArrive();
            parking.CarLeft();
            parking.CarArrive();
            parking.CarArrive();
            parking.Detach(screen);
            parking.CarArrive();
            parking.CarArrive();

        }
    }
}

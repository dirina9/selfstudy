using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
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
            IScreens screen1 = new Screen("screen1");
            IScreens screen2 = new Screen("screen2");
            parking.OnCarCrash += screen1.Attention;
            parking.OnCarCrash += screen2.Attention;
            parking.Attach(screen1);
            parking.Attach(screen2);

            parking.CarArrive();
            parking.CarArrive();
            parking.CarLeft();
            parking.CarArrive();
            parking.CarCrash("bmw", "G777GG");
            parking.CarArrive();
            parking.Detach(screen1);
            parking.CarArrive();
            parking.CarArrive();
            parking.CarCrash("audi", "F888FF");

        }
    }
}

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
            parking.Attach(new Screen("screen1"));
            Screen screen = new Screen("screen2");
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

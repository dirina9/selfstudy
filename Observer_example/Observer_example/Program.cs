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
            parking.Attach("screen1");
            parking.Attach("screen2");
            parking.AttachBig("screen BIG1");

            parking.CarArrive();
            parking.CarArrive();
            parking.CarLeft();
            parking.CarArrive();
            parking.CarCrash("bmw", "G777GG");
            parking.CarArrive();
            parking.CarCrash("lada", "G222MM");
            parking.CarArrive();
            parking.CarArrive();
            parking.CarCrash("audi", "F888FF");

            Console.ReadKey();
        }
    }
}

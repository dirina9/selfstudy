using System;
using System.Collections.Generic;
using System.Net.Configuration;

namespace Observer_example
{
    class Parking
    {
        private int places { get; set; }
        private readonly List<IScreens> screens = new List<IScreens>();
        public delegate void MethodContainer();
        public delegate void MethodCrash(CarCrashEventArgs e);
        public event MethodContainer OnCarArrive;
        public event MethodContainer OnCarLeft;
        //public event MethodContainer OnCarCrash;
        public event MethodCrash OnCarCrash;

        //public event EventHandler<CarCrashEventArgs> OnCarCrash;

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

        public void CarCrash()
        {
            if (OnCarCrash != null) OnCarCrash(new CarCrashEventArgs("audi", "F888FF"));
        }
        
        public class CarCrashEventArgs : EventArgs
        {
            public CarCrashEventArgs(string m, string n)
            {
                string model = m;
                string number = n;
            }

            private string model;
            private string number;

            public String Model
            {
                get { return model; }
                set { model = value; }
            }
            public String Number
            {
                get { return number; }
                set { number = value; }
            }
        }

    }
}

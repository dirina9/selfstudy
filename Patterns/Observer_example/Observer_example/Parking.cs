using System;
using System.Collections.Generic;

namespace Observer_example
{
    class Parking
    {
        private int places { get; set; }
        private readonly List<IScreen> screens = new List<IScreen>();
        public delegate void MethodCrash(string m, string n);
        public event MethodCrash OnCarCrash;

        public int Places
        {
            get { return this.places; }
        }


        public Parking(int places)
        {
            this.places = places;
        }

        public void AttachBig(string screenName)
        {
            IScreen screen = new LargeScreen(screenName);
            this.Subscribe(screen);
        }

        public void Attach(string screenName)
        {
            IScreen screen = new Screen(screenName);
            this.Subscribe(screen);
        }

        private void Subscribe(IScreen screen)
        {
            this.OnCarCrash += screen.OnCarCrashHandler;
            screens.Add(screen);
        }

        public void CarArrive()
        {
            places--;
        }

        public void CarLeft()
        {
            places++;
        }

        public void CarCrash(string m, string n)
        {
            if (OnCarCrash != null) OnCarCrash(m,n);
        }

    }
}

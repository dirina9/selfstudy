using System;

namespace Observer_example
{
    public class LargeScreen : IScreen
    {
        private readonly string _name;

        public LargeScreen(string name)
        {
            _name = name;
        }

        public void Update(int places)
        {
            throw new NotImplementedException();
        }

        public void OnCarCrashHandler(string model, string number)
        {
            Console.WriteLine("A BIGGASCREENA:{0} The owner of {1} № {2}. Please, go to contact center!", this._name, model, number);
        }
    }
}
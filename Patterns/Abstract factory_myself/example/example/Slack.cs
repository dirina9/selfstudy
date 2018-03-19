using System;
using System.Collections.Generic;
using Interfaces;

namespace example
{
    abstract class Slack
    {
        public string _subject;
        public string _food;
        public List<IAnimal> _animals = new List<IAnimal>();

        public Slack(string subject, string food)
        {
            this._subject = subject;
            this._food = food;
        }

        public string Subject
        {
            get { return _subject; }
        }

        public string Food
        {
            get { return _food; }
            set
            {
                if (_food != value)
                {
                    _food = value;
                    Notify(_food);
                }
            }
        }

        public void Attach(IAnimal animal)
        {
            _animals.Add(animal);
        }

        public void Notify(string foodType)
        {
            foreach (IAnimal animal in _animals)
            {
                animal.Update(foodType);
            }
            Console.WriteLine("");
        }

        public class FoodOrders : Slack
        {
            public FoodOrders(string subject, string food) : base(subject, food)
            {
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace Pluralsight.collectionInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //with List
            var daysOfWeek = new List<string> 
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };
            Console.WriteLine("before count = " + daysOfWeek.Count);
            Console.WriteLine("before capacity = " + daysOfWeek.Capacity);
            daysOfWeek.Add("PartyDay");
            daysOfWeek.Add("PartyDay1");
            daysOfWeek.Add("PartyDay2");
            daysOfWeek.Add("PartyDay3");
            Console.WriteLine("after adding count = " + daysOfWeek.Count);
            Console.WriteLine("after adding capacity = " + daysOfWeek.Capacity);
            daysOfWeek.RemoveAt(9);
            daysOfWeek.Remove("PartyDay3");
            daysOfWeek.Remove("PartyDay");
            daysOfWeek.Remove("PartyDay1");
            Console.WriteLine("after removing count = " + daysOfWeek.Count);
            Console.WriteLine("after removing capacity = " + daysOfWeek.Capacity);

            foreach (string day in daysOfWeek)
            {
                Console.WriteLine(day);
            }

            //cant add in copy - read-only
            var copy = daysOfWeek.AsReadOnly();

            //with collection (is read-only)
            string[] daysOfWeek_2 =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };
            ICollection<string> collection = daysOfWeek_2;
            Console.WriteLine("");
            Console.WriteLine("Count = " + collection.Count);

            //observable collection
            ObservableCollection<string> items = new ObservableCollection<string>
            {
                "clock",
                "book",
                "tv"
            };

            items.CollectionChanged += OnCollectionChanged;
        }

        static void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            
        }
    }
}

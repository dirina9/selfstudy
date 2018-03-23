using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace Pluralsight.collectionInterfaces
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Linked List");
            var linkedList = new LinkedLists();
            linkedList.LinkedListsExample();

            Console.WriteLine("");

            Console.WriteLine("Stack");
            var stack = new Stack();
            stack.StackExample();

            Console.WriteLine("");

            Console.WriteLine("Queue"); 
            var queue = new Queue();
            queue.QueueExample();

            Console.WriteLine("");

            Console.WriteLine("Dictionary"); 
            var dictionary = new Dictionary();
            dictionary.DictionaryExample();

            Console.WriteLine("");

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
            //Capacity — это длина буфера для массивов байтов, предоставляемых системой
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

            items.Add("new item");
        }

        static void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            Console.WriteLine("Collection was changed");
        }
    }
}

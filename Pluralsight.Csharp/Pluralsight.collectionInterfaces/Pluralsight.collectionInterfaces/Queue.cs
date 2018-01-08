using System;
using System.Collections.Generic;
using System.Reflection;

namespace Pluralsight.collectionInterfaces
{
    public class Queue
    {
        public void QueueExample()
        {
            //queue - first in first out (FIFO)
            Queue<string> tasks = new Queue<string>();
            tasks.Enqueue("Do the washing up");
            tasks.Enqueue("Finish the C# course");
            tasks.Enqueue("Celebrate New Year!");

            tasks.Dequeue();
            Console.WriteLine("All tasks:");
            foreach(string title in tasks)
            {
                Console.WriteLine(title);
            }


        }
    }
}
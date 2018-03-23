using System;
using System.Collections.Generic;

namespace Pluralsight.collectionInterfaces
{
    public class Queue
    {
        public void QueueExample()
        {
            //queue - first in first out (FIFO)
            Queue<string> tasks = new Queue<string>();
            //Enqueue добавляет объект в конец очереди Queue<T>.
            tasks.Enqueue("Do ex 1");
            tasks.Enqueue("Do ex 2");
            tasks.Enqueue("Do ex 3");
            //Dequeue удаляет объект из начала очереди.
            tasks.Dequeue();

            Console.WriteLine("All tasks:");
            foreach(string title in tasks)
            {
                Console.WriteLine(title);
            }


        }
    }
}
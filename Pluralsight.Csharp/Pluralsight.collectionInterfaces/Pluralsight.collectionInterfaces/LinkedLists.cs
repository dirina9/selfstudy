using System;
using System.Collections.Generic;

namespace Pluralsight.collectionInterfaces
{
    class LinkedLists
    {
        public void LinkedListsExample()
        {
            //LinkedList<T> представляет двухсвязный список, в котором каждый элемент ссылается на следующий и предыдущий
            var items = new LinkedList<string>();
            items.AddLast("speakers");

            //Класс LinkedListNode<T> Представляет узел в LinkedList<T> - определяет свойства List, Next, Previous и Value
            LinkedListNode<string> speakers = items.Find("speakers");

            items.AddAfter(speakers, "notebook");
            items.AddLast("book");
            items.RemoveFirst();

            LinkedListNode<string> book = items.Find("book");
            items.AddFirst("box");

            Console.WriteLine("speakers.Previous");
            Console.WriteLine(book.Previous); 
            Console.WriteLine("After removing and adding new fist item");
            foreach (string item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}

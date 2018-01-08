using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pluralsight.collectionInterfaces
{
    class LinkedLists
    {
        public void LinkedListsExample()
        {
            var items = new LinkedList<string>();
            items.AddLast("book");
            LinkedListNode<string> speakers = items.Find("book");
            items.AddAfter(speakers, "notebook");
            items.AddLast("speakers");

            items.RemoveFirst();
            items.AddFirst("box");


            foreach (string item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}

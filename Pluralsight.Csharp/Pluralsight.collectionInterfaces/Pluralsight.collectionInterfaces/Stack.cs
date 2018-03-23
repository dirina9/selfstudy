using System;
using System.Collections.Generic;

namespace Pluralsight.collectionInterfaces
{
    class Stack
    {
        public void StackExample()
        {
            //stack - first in last out (FILO)
            Stack<string> books = new Stack<string>();
            books.Push("programming");
            books.Push("Harry Potter");
            books.Push("Maths");

            Console.WriteLine("All books:");
            WriteBooks(books);

            //pop - with removing from the stack
            string topBook = books.Pop();
            Console.WriteLine("Top book - " + topBook);
            Console.WriteLine("All books:");
            WriteBooks(books);

            //peek - without removing from the stack
            string topBookAfterPop = books.Peek();
            Console.WriteLine("Top book after pop - " + topBookAfterPop);
            Console.WriteLine("All books:");
            WriteBooks(books);
        }

        public void WriteBooks(Stack<string> books)
        {
            foreach (string title in books)
            {
                Console.WriteLine(title);
            }

            Console.WriteLine("");
        }
    }
}

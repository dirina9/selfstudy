using System;
using System.Collections;
using System.Collections.Generic;

namespace Stack.List
{
    public class Stack<T> : IEnumerable<T>
    {
        //A Last In First Out (LIFO) collection implemented as a linked list
        private LinkedList<T> list = new LinkedList<T>();

        ////Adds the specified item to the stack
        public void Push(T item)
        {
            list.AddFirst(item);
        }

        ////Removes and returns the top item from the stack
        public T Pop()
        {
            if (list.Count == 0)
            {
                throw new InvalidOperationException("The stack is empty");
            }

            T value = list.First.Value;
            list.RemoveFirst();

            return value;
        }
        /// <summary>
        /// Returns the top item from the stack without removeng it from the stack
        /// </summary>
        /// <returns>The top-most item in the stack</returns>
        public T Peek()
        {
            if (list.Count == 0)
            {
                throw new InvalidOperationException("The stack is empty");
            }
            return list.First.Value;
        }

        /// <summary>
        /// The current items in the stack
        /// </summary>
        public int Count
        {
            get { return list.Count; }
        }

        /// <summary>
        /// Removes all items from the stack
        /// </summary>
        public void Clear()
        {
            list.Clear();
        }

        /// <summary>
        /// Enumerates each item in the stack in LIFO order. The stack remains unaltered - Стек остается неизменным 
        /// </summary>
        /// <returns>The LIFO enumerator</returns>
        public IEnumerator<T> GetEnumerator()
        {
            return list.GetEnumerator();
        }

        /// <summary>
        /// Enumerates each item in the stack in LIFO order. The stack remains unaltered
        /// </summary>
        /// <returns>The LIFO enumerator</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return list.GetEnumerator();
        }
    }
}
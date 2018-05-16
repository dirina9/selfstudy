using System;
using System.Collections;
using System.Collections.Generic;

namespace Queue
{
    /// <summary>
    /// A First In First Out collection
    /// </summary>
    /// <typeparam name="T">The type of data stored in the collection</typeparam>
    public class QueueLinkedList<T> : System.Collections.Generic.IEnumerable<T>
    {
        //the queued items - the Last list item is the 
        //newest queue item, the first is the oldest
        //This is so LinkedList<T>.GetEnumerator "just works"
        System.Collections.Generic.LinkedList<T> _items = new System.Collections.Generic.LinkedList<T>();

        /// <summary>
        /// Adds an item to the back of the queue
        /// </summary>
        /// <param name="item">The item to place in the queue</param>
        public void Enqueue(T item)
        {
            _items.AddLast(item);
        }

        public T Dequeue()
        {
            if (_items.Count == 0)
            {
                throw new InvalidOperationException("The queue is empty");
            }

            //store the last value in a temporary variable
            T value = _items.First.Value;

            //remove the last item
            _items.RemoveFirst();

            //returned the store last value
            return value;
        }
        /// <summary>
        /// Returns the front item from the queue without removing it from the queue
        /// </summary>
        /// <returns>The front item from the queue</returns>
        public T Peek()
        {
            if (_items.Count == 0)
            {
                throw new InvalidOperationException("The queue is empty");
            }
            //return the last value in the queue
            return _items.First.Value;
        }
        /// <summary>
        /// The number of items in the queue
        /// </summary>
        public int Count
        {
            get { return _items.Count; }
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
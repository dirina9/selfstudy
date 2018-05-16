using System.Collections;
using System.Collections.Generic;

namespace Queue
{
    /// <summary>
    /// A first in first out collection
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class QueueArray<T> : System.Collections.Generic.IEnumerable<T>
    {
        T[] items = new T[0];

        //the number of items in the queue
        private int size = 0;

        //the index of the first (oldest) item in the queue
        private int head = 0;

        //the index of the last (newest) item in the queue
        private int tail = -1;

        /// <summary>
        /// Adds an item to the back of the queue
        /// </summary>
        /// <param name="item">The item to place in the queue</param>
        private void Enqueue(T item)
        {
            if (items.Length == size)
            {
                int newLength = (size == 0) ? 4 : size * 2;
                T[] newArray = new T[newLength];
                if (size > 0)
                {
                    //copy content
                    //if the array has no wrapping, just copy the valid range
                    //else copy from head to end of the array and then from 0 to the tail
                    //if tail is less than head we`ve wrapped
                    int targetIndex = 0;

                    if (tail < head)
                    {
                        //copy the items[head]...items[end] -> newArray[0]..newArray[N]
                        for (int index = head; index < items.Length; index++)
                        {
                            newArray[targetIndex] = items[index];
                            targetIndex++;
                        }
                        //copy items[0]...items[tail] -> newArray[N+1]
                        for (int index = 0; index <= tail; index++)
                        {
                            newArray[targetIndex] = items[index];
                            targetIndex++;
                        }
                    }
                    else
                    {
                        //copy the items[head]...items[tail] -> newArray[0]..newArray[N]
                        for (int index = head; index < tail; index++)
                        {
                            newArray[targetIndex] = items[index];
                            targetIndex++;
                        }
                    }

                    head = 0;
                    tail = targetIndex - 1; //compensate for the extra bump
                }
                else
                {
                    head = 0;
                    tail = -1;
                }

                items = newArray;

                //now we have a properly sized array and can focus on wrapping issues

                //if tail is at the end of the array we need to wrap around

                if (tail == items.Length - 1)
                {
                    tail = 0;
                }
                else
                {
                    tail++;
                }

                items[tail] = item;
                size++;
            }
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
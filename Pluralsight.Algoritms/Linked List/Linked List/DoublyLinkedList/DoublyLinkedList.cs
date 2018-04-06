using System.Collections;
using System.Collections.Generic;

namespace Linked_List.DoublyLinkedList
{
    public class DoublyLinkedList<T> : System.Collections.Generic.ICollection<T>
    {
        //The first node in the list or null if empty
        public LinkedListNode<T> Head { get; private set; }

        //The last node in the list or null if empty
        public LinkedListNode<T> Tail { get; private set; }


        public void AddLast(T value)
        {
            AddLast(new LinkedListNode<T>(value));
        }

        //Add the node to the end of the list
        public void AddLast(LinkedListNode<T> node)
        {
            if (Count == 0)
            {
                Head = node;
            }
            else
            {
                Tail.Next = node;
                node.Previous = Tail;
            }

            Tail = node;

            Count++;
        }

        //Removes the first node from the list
        public void RemoveFirst()
        {
            if (Count != 0)
            {
                Head = Head.Next;
                Count--;

                if (Count == 0)
                {
                    Tail = null;
                }
                else
                {
                    Head.Previous = null;
                }
            }
        }

        public void RemoveLast()
        {
            if (Count == 1)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                Tail.Previous.Next = null;
                Tail = Tail.Previous;
            }

            Count--;
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(T item)
        {
            throw new System.NotImplementedException();
        }

        public void Clear()
        {
            throw new System.NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new System.NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new System.NotImplementedException();
        }

        public bool Remove(T item)
        {
            LinkedListNode<T> previous = null;
            LinkedListNode<T> current = Head;

            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    //its a node in the middle or end
                    if (previous != null)
                    {
                        previous.Next = current.Next;

                        //it was end - so update Tail
                        if (current.Next == null)
                        {
                            Tail = previous;
                        }
                        else
                        {
                            current.Next.Previous = previous;
                        }

                        Count--;
                    }
                    else
                    {
                        RemoveFirst();
                    }

                    return true;
                }

                previous = current;
                current = current.Next;
            }

            return false;
        
        }

        public int Count { get; private set; }
        public bool IsReadOnly { get; private set; }
    }
}
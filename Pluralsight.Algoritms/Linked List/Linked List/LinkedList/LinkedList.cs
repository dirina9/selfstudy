using System.Collections;
using System.Collections.Generic;

namespace Linked_List.LinkedList
{
    public class LinkedList<T> : System.Collections.Generic.ICollection<T>
    {
        //The first node in the list or null if empty
        public LinkedListNode<T> Head { get; private set; }

        //The last node in the list or null if empty
        public LinkedListNode<T> Tail { get; private set; }

        public void AddFirst(T value)
        {
            AddFirst(new LinkedListNode<T>(value));
        }

        public void AddFirst(LinkedListNode<T> node)
        {
            //Save off the head node so we dont lose it
            LinkedListNode<T> temp = Head;

            //Point head to the new code
            Head = node;

            //Insert the rest of the list behind the head
            Head.Next = temp;

            Count++;

            if (Count == 1)
            {
                //If the list was empty then Head and Tail should
                //both point to the new node.
                Tail = Head;
            }

        }

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
            }
        }

        //Enumerates over the linked list values from Head to Tail
        public IEnumerator<T> GetEnumerator()
        {
            LinkedListNode<T> current = Head;
            while (current != null)
            {
                //Применяя yield return мы декларируем, что данный метод возвращает последовательность IEnumerable

                //основной недостаток yield — это дополнительный класс итератор. 
                //Если последовательность конечная, а вызывающая сторона не выполняет сложных манипуляций с элементами,
                //итератор будет медленнее и создаст нежелательную нагрузку на GC. 
                //Применять же yield целесобразно в случаях обработки длинных последовательностей, когда каждое вычисление коллекции приводит к аллокации больших массивов памяти
                yield return current.Value;
                current = current.Next;
            }
        }

        //Enumerates over the linked list values from Head to Tail
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
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
                LinkedListNode<T> current = Head;
                while (current.Next != Tail)
                {
                    current = current.Next;
                }

                current.Next = null;
                Tail = current;
            }

            Count--;
        }

        public void Add(T item)
        {
            throw new System.NotImplementedException();
        }

        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
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

            while (current!= null)
            {
                if (current.Value.Equals(item))
                {
                    //its a node in the middle or end
                    if (previous!= null)
                    {
                        previous.Next = current.Next;

                        //it was end - so update Tail
                        if (current.Next == null)
                        {
                            Tail = previous;
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
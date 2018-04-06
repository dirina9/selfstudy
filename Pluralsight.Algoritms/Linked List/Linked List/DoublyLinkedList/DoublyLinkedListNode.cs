using System.Collections.Generic;

namespace Linked_List.DoublyLinkedList
{
    public class LinkedListNode<T>
    {
        //Construct a new node with the specified value
        public LinkedListNode(T value)
        {
            Value = value;
        }

        //The node value
        public T Value { get; set; }

        //The next node in the linked list (null if last node)
        public LinkedListNode<T> Next { get; set; }

        //The previous node in the linked list (null if first node)
        public LinkedListNode<T> Previous { get; set; }
    }
}
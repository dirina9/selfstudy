namespace Linked_List.LinkedList
{
    //A node in the LinkedList
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
    }
}
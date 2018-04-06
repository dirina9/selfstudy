using System;

namespace Linked_List
{
    public class NodeChains
    {
        public void StartNodeChainsExample()
        {
            Node first = new Node { Value = 3};
            Node middle = new Node {Value = 5};
            first.Next = middle;
            Node last = new Node {Value = 7};
            middle.Next = last;
            PrintList(first); 
        }
        private static void PrintList(Node node)
        {
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
        }
    }
}
using System;
using System.Collections.Generic;

namespace Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linked list");
            //Linked List - Node Chains
            var nodeChainsExample = new NodeChains();
            nodeChainsExample.StartNodeChainsExample();

            Console.WriteLine("");
            Console.WriteLine("Yield return");
            //Yield return 
            var yieldReturnExample = new YieldReturn();
            IEnumerable<int> numbers = yieldReturnExample.GetNumbers();
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

        }

    }
}

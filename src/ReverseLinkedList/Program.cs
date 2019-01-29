using System;
using System.Linq;

namespace ReverseLinkedList
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var linkedList = new LinkedList<int>();
            for (var i = 0; i < 10; i++)
            {
                linkedList.Add(i);
            }

            Console.WriteLine("Before reverse:");
            PrintLinkedList(linkedList);

            ReverseLinkedList(linkedList);

            Console.WriteLine();
            Console.WriteLine("After reverse:");
            PrintLinkedList(linkedList);
        }

        /// <summary>
        /// Reverse the linked list. Reverse must be done with O(n) time Complexity O(1) extra space. 
        /// </summary>
        public static void ReverseLinkedList<T>(LinkedList<T> linkedList)
        {
            if (linkedList?.First == null)
                return;

            var previousNode = linkedList.First;
            var currentNode = previousNode.Next;
            previousNode.Next = null;

            while (currentNode != null)
            {
                var nextNode = currentNode.Next;
                currentNode.Next = previousNode;
                previousNode = currentNode;
                currentNode = nextNode;
            }

            linkedList.First = previousNode;
        }

        public static void PrintLinkedList<T>(LinkedList<T> linkedList)
        {
            if (linkedList?.First == null)
                return;

            var currentNode = linkedList.First;
            while (currentNode != null)
            {
                Console.Write(currentNode.Value + " ");
                currentNode = currentNode.Next;
            }
        }
    }
}

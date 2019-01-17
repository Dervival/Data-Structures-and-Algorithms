using System;
using LinkedList.Classes;

namespace ll_merge
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LList linkedList = new LList();
            // 20 -> 15 -> 10;
            linkedList.Append(20);
            linkedList.Append(15);
            linkedList.Append(10);
            LList linkedListTwo = new LList();
            // 200 -> 150 -> 100;
            linkedListTwo.Append(200);
            linkedListTwo.Append(150);
            linkedListTwo.Append(100);
            Console.WriteLine("Before Merge:");
            linkedList.Print();
            linkedListTwo.Print();
            MergeLists(linkedList, linkedListTwo);
            Console.WriteLine("After Merge:");
            linkedList.Print();
            linkedListTwo.Print();
        }
        /// <summary>
        /// Merges two singly linked lists through mutation. The first linked list exits the function as the merged linked list, and the second linked list becomes empty. The function returns a reference to the head of the first linked list.
        /// </summary>
        /// <param name="linkedListOne">The first linked list to be merged. Exits function as the merged linked list.</param>
        /// <param name="linkedListTwo">The second linked list to be merged. Exits function empty.</param>
        /// <returns>Returns the head node of the first (merged) linked list.</returns>
        public static Node MergeLists(LList linkedListOne, LList linkedListTwo)
        {
            if(linkedListTwo.Head == null)
            {
                return linkedListOne.Head;
            }
            linkedListOne.Current = linkedListOne.Head;
            Node tmp = linkedListOne.Head;
            while(tmp != null)
            {
                tmp = linkedListOne.Current.Next;
                linkedListOne.Current.Next = linkedListTwo.Head;
                linkedListTwo.Head = tmp;
                linkedListOne.Current = linkedListOne.Current.Next;
            }
            return linkedListOne.Head;
        }
    }
}

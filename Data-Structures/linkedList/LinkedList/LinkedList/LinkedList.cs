using LinkedList.Classes;
using System;


namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LListExample();
        }

        static void NodeExample()
        {
            Node node = new Node(8);
            Node node2 = new Node(14);
            node.Next = node2;
        }

        static void LListExample()
        {
            LList linkedList = new LList();
            linkedList.Print();
            linkedList.Insert(20);
            linkedList.Insert(10);
            linkedList.Insert(5);
            linkedList.Print();
            Console.WriteLine("This linked list has " + linkedList.CountNodes() + " nodes in it.");
        }

        static void LLIncludesExample()
        {
            LList linkedList = new LList();
            linkedList.Insert(20);
            linkedList.Insert(10);
            linkedList.Insert(5);
            linkedList.Print();
            if (linkedList.Includes(10))
            {
                Console.WriteLine("10 existed in list");
            }
            else
            {
                Console.WriteLine("10 not in list");
            }
        }
    }
}

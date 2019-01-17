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
            MergeRef(linkedList, linkedListTwo);
            Console.WriteLine("After Merge:");
            linkedList.Print();
            linkedListTwo.Print();
        }

        public static Node MergeRef(LList linkedListOne, LList linkedListTwo)
        {
            if(linkedListTwo.Head == null)
            {
                return linkedListOne.Head;
            }
            linkedListOne.Current = linkedListOne.Head;
            Node tmp = linkedListOne.Head;
            while(tmp != null)
            {
                //linkedListOne.Print();
                //linkedListTwo.Print();
                //if (linkedListOne.Current.Next != null)
                //{
                //    Console.WriteLine("tmp should point to " + linkedListOne.Current.Next.Value);
                //}
                //else
                //{
                //    Console.WriteLine("tmp should point to null");
                //}
                tmp = linkedListOne.Current.Next;
                //if (linkedListOne.Current.Next != null)
                //{
                //    Console.WriteLine("tmp value = " + tmp.Value);
                //}
                //else
                //{
                //    Console.WriteLine("tmp is null");
                //}
                //Console.WriteLine("current.next should point to " + linkedListTwo.Head.Value);
                linkedListOne.Current.Next = linkedListTwo.Head;
                //Console.WriteLine("current.next = " + linkedListTwo.Head.Value);
                linkedListTwo.Head = tmp;
                linkedListOne.Current = linkedListOne.Current.Next;
            }
            return linkedListOne.Head;
        }

        //public static LList MergeList(LList linkedListOne, LList linkedListTwo)
        //{
        //    linkedListOne.Current = linkedListOne.Head;
        //    Node tmp = linkedListOne.Head;
        //    while (tmp != null)
        //    {
        //        tmp = linkedListOne.Current.Next;
        //        linkedListOne.Current.Next = linkedListTwo.Head;
        //        linkedListTwo.Head = tmp;
        //        linkedListOne.Current = linkedListOne.Current.Next;
        //    }
        //    return linkedListOne;
        //}
    }
}

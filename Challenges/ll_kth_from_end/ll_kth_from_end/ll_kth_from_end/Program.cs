using System;
using LinkedList.Classes;

namespace ll_kth_from_end
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LList linkedList = new LList();
            linkedList.Append(20);
            linkedList.Append(15);
            linkedList.Append(10);
            int kth = LinkedListKthFromEnd(linkedList, 1);
        }

        /// <summary>
        /// Returns the value contained in the node k nodes away from the end of linkedList
        /// </summary>
        /// <param name="linkedList">The linkedList whose node k nodes from the end has its value returned</param>
        /// <param name="k">The number of nodes away from the end of the node whose value is to be returned</param>
        /// <returns>The value of the node k nodes away from the end of the linked list</returns>
        public static int LinkedListKthFromEnd(LList linkedList, int k)
        {
            int length = linkedList.CountNodes();
            //if k is greater than the number of links (number of nodes - 1), the node will be past the head of the linked list
            //if k is less than 0, the node will be past the tail of the linked list
            if (k > length-1 || k < 0)
            {
                throw new IndexOutOfRangeException();
            }
            // Buggy CountNodes() implementation on the data structure - need to reset the Current to Head
            linkedList.Current = linkedList.Head;
            for(int i = 0; i < length-1-k; i++)
            {
                linkedList.Current = linkedList.Current.Next;
            }
            return linkedList.Current.Value;
        }
    }
}

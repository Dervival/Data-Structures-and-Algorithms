using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classes
{
    class LList
    {
        /// <summary>
        /// Head is the first node in the linked list. If Head is null, the linked list is empty.
        /// </summary>
        public Node Head { get; set; }
        /// <summary>
        /// Current tracks the node currently being viewed. 
        /// </summary>
        public Node Current { get; set; }
        /// <summary>
        /// Instantiation of a linked list with a previously existing node.
        /// </summary>
        /// <param name="node">Previously instantiated node that will be used as the head of the newly made linked list.</param>
        public LList(Node node)
        {
            Head = node;
            Current = Head;
        }
        /// <summary>
        /// Instantiation of an empty linked list.
        /// </summary>
        public LList()
        {
            Head = null;
        }
        /// <summary>
        /// Inserts a node containing the provided value at the start of the linked list. The head will point to the added node.
        /// </summary>
        /// <param name="value">The </param>
        public void Insert(int value)
        {
            Node node = new Node(value);
            node.Next = Head;
            Head = node;
        }
        public void Insert(Node node)
        {
            node.Next = Head;
            Head = node;
        }
        public bool Includes(int value)
        {
            Current = Head;
            while (Current.Next != null)
            {
                if (Current.Value == value)
                {
                    return true;
                }
                Current = Current.Next;
            }
            if (Current.Value == value)
            {
                return true;
            }
            return false;
        }
        public void Print()
        {
            Current = Head;
            while (Current.Next != null)
            {
                Console.Write(Current.Value + " -> ");
                Current = Current.Next;
            }
            Console.WriteLine(Current.Value + " -> NULL");
        }
        public int CountNodes()
        {
            int accumulator = 0;
            Current = Head;
            if (Current == null)
            {
                return accumulator;
            }
            if (Current.Next == null)
            {
                return 1;
            }
            while (Current.Next != null)
            {
                accumulator++;
                Current = Current.Next;
            }
            accumulator++;
            return accumulator;
        }
        public void Behead()
        {
            Head = Head.Next;
        }
    }
}

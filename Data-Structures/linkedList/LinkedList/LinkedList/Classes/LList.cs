using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classes
{
    public class LList
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
        /// <param name="value">The value for the node that is to be added at the start of the list.</param>
        public void Insert(int value)
        {
            Node node = new Node(value);
            node.Next = Head;
            Head = node;
        }
        /// <summary>
        /// Inserts a previously constructed node at the start of the linked list. The head will point to the added node.
        /// </summary>
        /// <param name="node">The node to be added to the start of the list.</param>
        public void Insert(Node node)
        {
            node.Next = Head;
            Head = node;
        }
        /// <summary>
        /// Determines whether a node in the linked list contains the value provided. Returns true if the value is found.
        /// </summary>
        /// <param name="value">Value to be found.</param>
        /// <returns>
        /// Returns true if value is found. Otherwise, returns false.
        /// </returns>
        public bool Includes(int value)
        {
            Current = Head;
            if(Current == null)
            {
                return false;
            }
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
        /// <summary>
        /// Prints the linked list node by node to the console. 
        /// </summary>
        public void Print()
        {
            Current = Head;
            if(Current == null)
            {
                Console.WriteLine("NULL");
                return;
            }
            while (Current.Next != null)
            {
                Console.Write(Current.Value + " -> ");
                Current = Current.Next;
            }
            Console.WriteLine(Current.Value + " -> NULL");
        }
        /// <summary>
        /// Counts the number of nodes in the linked list. If the list is empty, the count is zero.
        /// </summary>
        /// <returns>The number of nodes in the list.</returns>
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
        /// <summary>
        /// If it exists, removes the first node from the linked list.
        /// </summary>
        public void Behead()
        {
            if(!(Head == null))
            {
                Head = Head.Next;
            }
        }
        /// <summary>
        /// Appends a new node containing the value parameter to the end of the linked list.
        /// </summary>
        /// <param name="value">Value to be appended to the end of the linked list</param>
        public void Append(int value)
        {
            Current = Head;
            if (Current == null)
            {
                Node headNode = new Node(value);
                Insert(headNode);
                return;
            }
            while (Current.Next != null)
            {
                Current = Current.Next;
            }
            Node newNode = new Node(value);
            Current.Next = newNode;
        }
        /// <summary>
        /// Appends a new node to the end of the linked list.
        /// </summary>
        /// <param name="newNode">Node to be appended to the end of the linked list.</param>
        public void Append(Node newNode)
        {
            Current = Head;
            if(Current == null)
            {
                Insert(newNode);
                return;
            }
            while (Current.Next != null)
            {
                Current = Current.Next;
            }
            Current.Next = newNode;
        }
        /// <summary>
        /// Inserts a new node containing the newValue parameter into a linked list  
        /// </summary>
        /// <param name="value">Value of node to be inserted before</param>
        /// <param name="newValue">Value of node to be inserted</param>
        /// <returns>Returns true if the value was found and insertion was sucessful, false otherwise</returns>
        public bool InsertBefore(int value, int newValue)
        {
            Current = Head;
            if(Current.Value == newValue)
            {
                Insert(newValue);
                return true;
            }
            while(Current.Next != null)
            {
                if(Current.Next.Value == value)
                {
                    Node newNode = new Node(newValue);
                    newNode.Next = Current.Next;
                    Current.Next = newNode;
                    return true;
                }
                Current = Current.Next;
            }
            return false;
        }
        /// <summary>
        /// Inserts a node into a linked list before a node with the provided value
        /// </summary>
        /// <param name="value">Value of node to be inserted before</param>
        /// <param name="newNode">Node to be inserted</param>
        /// <returns>Returns true if the value was found and insertion was sucessful, false otherwise</returns>
        public bool InsertBefore(int value, Node newNode)
        {
            Current = Head;
            if (Current.Value == value)
            {
                Insert(newNode);
                return true;
            }
            while (Current.Next != null)
            {
                if (Current.Next.Value == value)
                {
                    newNode.Next = Current.Next;
                    Current.Next = newNode;
                    return true;
                }
                else
                {
                    Current = Current.Next;
                }
            }
            return false;
        }
        /// <summary>
        /// Inserts a new node containing the newValue parameter into a linked list after a node with the provided value.  
        /// </summary>
        /// <param name="value">Value of node to be inserted after</param>
        /// <param name="newValue">Value of node to be inserted</param>
        /// <returns>Returns true if the value was found and insertion was sucessful, false otherwise</returns>
        public bool InsertAfter(int value, int newValue)
        {
            Current = Head;
            while (Current.Next != null)
            {
                if (Current.Value == value)
                {
                    Node newNode = new Node(newValue);
                    newNode.Next = Current.Next;
                    Current.Next = newNode;
                    return true;
                }
                Current = Current.Next;
            }
            return false;
        }
        /// <summary>
        /// Inserts a node into a linked list after a node with the provided value
        /// </summary>
        /// <param name="value">Value of node to be inserted after</param>
        /// <param name="newNode">Node to be inserted</param>
        /// <returns>Returns true if the value was found and insertion was sucessful, false otherwise</returns>
        public bool InsertAfter(int value, Node newNode)
        {
            Current = Head;
            while (Current.Next != null)
            {
                if (Current.Value == value)
                {
                    newNode.Next = Current.Next;
                    Current.Next = newNode;
                    return true;
                }
                Current = Current.Next;
            }
            return false;
        }
    }
}

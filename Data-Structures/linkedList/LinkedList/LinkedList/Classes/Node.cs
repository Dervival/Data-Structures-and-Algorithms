using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classes
{
    public class Node
    {
        /// <summary>
        /// Value is the integer data stored within the node.
        /// </summary>
        public int Value { get; set; }
        /// <summary>
        /// Next is a reference to another node; for linked lists, it is a reference to the next node in the linked list.
        /// </summary>
        public Node Next { get; set; }
        /// <summary>
        /// Constructor for an integer node. Null values are not allowed - nodes must be instantiated with an initial value.
        /// </summary>
        /// <param name="value"></param>
        public Node(int value)
        {
            Value = value;
        }
    }
}

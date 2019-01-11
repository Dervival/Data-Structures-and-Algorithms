using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classes
{
    class Node
    {
        /// <summary>
        /// Value is the integer data stored within the node.
        /// </summary>
        public int Value { get; set; }
        /// <summary>
        /// Next is a reference to another node; for linked lists, it is a reference to the next node in the linked list.
        /// </summary>
        public Node Next { get; set; }

        public Node(int value)
        {
            Value = value;
        }
    }
}

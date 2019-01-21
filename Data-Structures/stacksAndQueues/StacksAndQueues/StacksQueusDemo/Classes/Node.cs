using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    /// <summary>
    /// Class for basic data units for both stacks and queues, similar to the Node class for the linked list implementation. Can take in an integer Value and a reference to the "next" node in either the stack or queue. The Next reference will point to either another node or null.
    /// </summary>
    class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }

        /// <summary>
        /// Construction of a node with an initial value; means we must initialize with an integer so no nodes containing null.
        /// </summary>
        /// <param name="value">The integer value to initialize the node with.</param>
        public Node(int value)
        {
            Value = value;
        }
    }

}

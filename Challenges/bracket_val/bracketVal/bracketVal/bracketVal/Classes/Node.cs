using System;
using System.Collections.Generic;
using System.Text;

namespace bracketVal.Classes
{
    /// <summary>
    /// I only need the stack from stacks and queues, and I'd rather use an explicit string method instead of messing around with what I have in my stacks and queues .dll
    /// </summary>
    public class Node
    {
        public string Value { get; set; }
        public Node Next { get; set; }

        /// <summary>
        /// Construction of a node with an initial value; means we must initialize with an integer so no nodes containing null.
        /// </summary>
        /// <param name="value">The integer value to initialize the node with.</param>
        public Node(string value)
        {
            Value = value;
        }
    }
}

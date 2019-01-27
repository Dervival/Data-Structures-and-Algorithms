using System;
using System.Collections.Generic;
using System.Text;

namespace bracketVal.Classes
{
    public class Stack
    {
        // Top Reference so we know where the top is. Similar to the Head node of a linked list.
        public Node Top { get; set; }


        /// <summary>
        /// Creates a new stack with an initial node provided by the user.  
        /// </summary>
        /// <param name="node">The node to initialize the stack with. </param>
        public Stack(Node node)
        {
            Top = node;
        }

        /// <summary>
        /// Creates a new stack with an initial node whose value is provided by the user.  
        /// </summary>
        /// <param name="node">The value of a node to initialize the stack with. </param>
        public Stack(string value)
        {
            Node newNode = new Node(value);
            Top = newNode;
        }

        /// <summary>
        /// Creates a new empty stack. Best practice is to avoid using this and initialize with a starting node - an empty stack will throw a null reference exception by design if it is peeked or popped.
        /// </summary>
        public Stack()
        {

        }

        /// <summary>
        /// Pushes a node containing the value provided to the top of the stack.
        /// </summary>
        /// <param name="value">The value to be added to the node that is the new top of the stack.</param>
        public void Push(string value)
        {
            Node node = new Node(value);
            node.Next = Top;
            Top = node;
        }

        /// <summary>
        /// Pushes a node provided by a user to the top of the stack. If that node pointed to any other nodes, that reference is overwritten.
        /// </summary>
        /// <param name="newNode">A previously created node to be added to the top of the stack.</param>
        public void Push(Node newNode)
        {
            newNode.Next = Top;
            Top = newNode;
        }

        /// <summary>
        /// Removes and returns the top node of the stack. If the stack is empty, a null reference exception will be thrown.
        /// </summary>
        /// <returns>The top node of the stack being popped.</returns>
        public Node Pop()
        {
            // create a temporary reference to the node to be popped off the stack
            Node temp = Top;
            // setting Top to the next node in the stack means we do not need to retain the reference on the returned node
            Top = Top.Next;
            // clear the reference of next on the temp for sanitation reasons; if other actions do not clear the .Next property of the returned node, there can be unsafe access to the stack being popped from
            temp.Next = null;
            return temp;
        }

        /// <summary>
        /// Returns the top node of the stack. Does not remove the top node.
        /// </summary>
        /// <returns>The top node of the stack being peeked.</returns>
        public Node Peek()
        {
            return Top;
        }
    }
}

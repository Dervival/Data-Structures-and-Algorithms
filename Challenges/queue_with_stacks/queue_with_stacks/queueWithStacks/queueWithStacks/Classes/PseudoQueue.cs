using System;
using System.Collections.Generic;
using System.Text;
using StacksAndQueues.Classes;

namespace queueWithStacks.Classes
{
    public class PseudoQueue
    {
        /// <summary>
        /// InStack - stack to enqueue to. Outside of methods, this should be the only stack that contains any nodes. Consider the Top reference of the InStack similar to the Rear reference of a traditional queue.
        /// </summary>
        public static Stack InStack = new Stack();

        /// <summary>
        /// OutStack - stack used for dequeueing only. This should be empty at all times except during the dequeueing method, where it acts as a container for the elements being popped off of the InStack to expose the bottom element. When the InStack is empty, consider the top reference of the OutStack similar to the Front reference of a traditional queue.
        /// </summary>
        public static Stack OutStack = new Stack();

        /// <summary>
        /// Adds a node to the top of the InStack - because we are only dequeueing from the OutStack after the InStack has fully been transferred to the OutStack, the top node of InStack will be the node furthest from the top of OutStack, meaning it will be popped last when dequeueing. 
        /// </summary>
        /// <param name="value">Value to enqueue into the pseudoqueue</param>
        public void Enqueue(int value)
        {
            Node newNode = new Node(value);
            InStack.Push(newNode);
        }

        public Node Dequeue()
        {
            //figure out a better way to work with the edge case of an empty pseudoQueue than returning null...
            if (InStack.Peek() == null)
            {
                return null;
            }
            while(InStack.Peek() != null)
            {
                OutStack.Push(InStack.Pop());
            }
            Node temp = OutStack.Pop();
            while(OutStack.Peek() != null)
            {
                InStack.Push(OutStack.Pop());
            }
            return temp;
        }
    }
}

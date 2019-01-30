using System;
using Tree.Classes;
using StacksAndQueues.Classes;

namespace breadthFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void BreadthFirstPrint(BinaryTree<int> binaryTree)
        {
            if(binaryTree.Root == null)
            {
                return;
            }
            Queue<Tree.Classes.Node<int>> BreadthFirstQueue = new Queue<Tree.Classes.Node<int>>();
            BreadthFirstQueue.Enqueue(binaryTree.Root);
            while(BreadthFirstQueue.Peek() != null)
            {
                Tree.Classes.Node<int> dequeuedNode = BreadthFirstQueue.Dequeue().Value;
                Console.WriteLine(dequeuedNode);
                if(dequeuedNode.LeftChild != null)
                {
                    BreadthFirstQueue.Enqueue(dequeuedNode.LeftChild);
                }
                if (dequeuedNode.RightChild != null)
                {
                    BreadthFirstQueue.Enqueue(dequeuedNode.RightChild);
                }
            }
        }
    }
}

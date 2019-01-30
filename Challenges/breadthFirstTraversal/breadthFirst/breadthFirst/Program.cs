using System;
using System.Collections.Generic;
using Tree.Classes;
using StacksAndQueues.Classes;

namespace breadthFirst
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //building the tree from the code challenge example
            BinaryTree<int> newTree = new BinaryTree<int>(2);
            newTree.Root.LeftChild = new Tree.Classes.Node<int>(7);
            newTree.Root.RightChild = new Tree.Classes.Node<int>(5);
            newTree.Root.LeftChild.LeftChild = new Tree.Classes.Node<int>(2);
            newTree.Root.LeftChild.RightChild = new Tree.Classes.Node<int>(6);
            newTree.Root.RightChild.RightChild = new Tree.Classes.Node<int>(9);
            newTree.Root.LeftChild.RightChild.LeftChild = new Tree.Classes.Node<int>(5);
            newTree.Root.LeftChild.RightChild.RightChild = new Tree.Classes.Node<int>(11);
            newTree.Root.RightChild.RightChild.LeftChild = new Tree.Classes.Node<int>(4);
            //testing the output, should match print statement in example
            Console.WriteLine("BreadthFirstPrint:");
            BreadthFirstPrint(newTree);
            //and testing the write from the list function
            Console.WriteLine("BreadthFirstList:");
            List<int> BFList = BreadthFirstList(newTree);
            //and thesting the list from the list function
            Console.WriteLine("BreadthFirstList's list:");
            foreach(int value in BFList)
            {
                Console.WriteLine(value);
            }
        }

        /// <summary>
        /// Traverses a binary tree of integer values and prints out their value in order of when they were visited. Since this is a void method, this cannot be tested against directly; creating a helper function below that can actually be tested against.
        /// </summary>
        /// <param name="binaryTree">The tree to be traversed and printed out.</param>
        public static void BreadthFirstPrint(BinaryTree<int> binaryTree)
        {
            if(binaryTree.Root == null)
            {
                return;
            }
            //okay, name things slightly differently from the built-in classes next time...
            StacksAndQueues.Classes.Queue<Tree.Classes.Node<int>> BreadthFirstQueue = new StacksAndQueues.Classes.Queue<Tree.Classes.Node<int>>();
            BreadthFirstQueue.Enqueue(binaryTree.Root);
            while(BreadthFirstQueue.Peek() != null)
            {
                Tree.Classes.Node<int> dequeuedNode = BreadthFirstQueue.Dequeue().Value;
                Console.WriteLine(dequeuedNode.Value);
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

        /// <summary>
        /// In addition to the above, adds values as they are written to the console into a list, which can then be tested again.
        /// </summary>
        /// <param name="binaryTree">The tree to be traversed breadthFirst.</param>
        /// <returns>A list of integers of the values printed out, in order of when they were accessed.</returns>
        public static List<int> BreadthFirstList(BinaryTree<int> binaryTree)
        {
            List<int> returnList = new List<int>();
            if (binaryTree.Root == null)
            {
                return returnList;
            }
            StacksAndQueues.Classes.Queue<Tree.Classes.Node<int>> BreadthFirstQueue = new StacksAndQueues.Classes.Queue<Tree.Classes.Node<int>>();
            BreadthFirstQueue.Enqueue(binaryTree.Root);
            while (BreadthFirstQueue.Peek() != null)
            {
                Tree.Classes.Node<int> dequeuedNode = BreadthFirstQueue.Dequeue().Value;
                Console.WriteLine(dequeuedNode.Value);
                returnList.Add(dequeuedNode.Value);
                if (dequeuedNode.LeftChild != null)
                {
                    BreadthFirstQueue.Enqueue(dequeuedNode.LeftChild);
                }
                if (dequeuedNode.RightChild != null)
                {
                    BreadthFirstQueue.Enqueue(dequeuedNode.RightChild);
                }
            }
            return returnList;
        }
    }
}

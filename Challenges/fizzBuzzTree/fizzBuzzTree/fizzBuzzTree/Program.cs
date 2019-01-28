using System;
using Tree.Classes;

namespace fizzBuzzTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static BinaryTree<object> FizzBuzzTree(BinaryTree<object> binaryTree)
        {
            if(binaryTree.Root == null)
            {
                return binaryTree;
            }
            FizzBuzzTree(binaryTree.Root);
            return binaryTree;
        }

        static void FizzBuzzTree(Node<object> root)
        {
            
        }
    }
}

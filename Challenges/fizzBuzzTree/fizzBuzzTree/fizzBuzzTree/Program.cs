using System;
using Tree.Classes;

namespace fizzBuzzTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static BinaryTree<object> FizzBuzzTree(BinaryTree<object> binaryTree)
        {
            if(binaryTree.Root == null)
            {
                return binaryTree;
            }
            FizzBuzzTree(binaryTree.Root);
            return binaryTree;
        }

        public static void FizzBuzzTree(Node<object> root)
        {
            //Pre-order traversal suffices - we only need a traversal method, not necessarily 
            if (root != null)
            {
                if(Int32.TryParse(root.Value.ToString(), out int value))
                {
                    if(value % 15 == 0)
                    {
                        root.Value = "FizzBuzz";
                    }
                    else if (value % 5 == 0)
                    {
                        root.Value = "Buzz";
                    }
                    else if (value % 3 == 0)
                    {
                        root.Value = "Fizz";
                    }
                }
                if (root.LeftChild != null)
                {
                    FizzBuzzTree(root.LeftChild);
                }
                if (root.RightChild != null)
                {
                    FizzBuzzTree(root.RightChild);
                }
            }
        }
    }
}

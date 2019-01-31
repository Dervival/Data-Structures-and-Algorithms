using System;
using Tree.Classes;

namespace findMaxValue
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static int FindMaxValue(BinaryTree<int> binaryTree)
        {
            if(binaryTree.Root == null)
            {
                return Int32.MinValue;
            }
            return FindMaxValue(binaryTree.Root);
        }

        static int FindMaxValue(Node<int> root)
        {
            int leftValue = Int32.MinValue;
            if(root.LeftChild != null)
            {
                leftValue = FindMaxValue(root.LeftChild);
            }
            int rightValue = Int32.MinValue;
            if (root.RightChild != null)
            {
                rightValue = FindMaxValue(root.RightChild);
            }
            int maxValue = root.Value;
            if(maxValue < leftValue){
                maxValue = leftValue;
            }
            if(maxValue < rightValue)
            {
                maxValue = rightValue;
            }
            return maxValue;
        }
    }
}

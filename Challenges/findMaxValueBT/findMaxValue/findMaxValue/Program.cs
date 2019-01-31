using System;
using Tree.Classes;

namespace findMaxValue
{
    public class Program
    {
        /// <summary>
        /// Given a binary tree, returns the largest integer value in the tree by recursively returning the maximum of a set of values mapping to the root's value, the maximum of the sub-tree to the left of the root, and the maximum of the sub-tree to the right of the root.
        /// </summary>
        /// <param name="binaryTree">The binary tree to be traversed and whose greatest node value is to be returned.</param>
        /// <returns>The largest value in the binary tree.</returns>
        public static int FindMaxValue(BinaryTree<int> binaryTree)
        {
            if(binaryTree.Root == null)
            {
                return Int32.MinValue;
            }
            return FindMaxValue(binaryTree.Root);
        }
        /// <summary>
        /// Given a node, recursively determines the greatest value in the node and the nodes below it by comparing the node's value to the maximum value of all nodes to the left and all nodes to the right of the node.
        /// </summary>
        /// <param name="root">The node to begin recursion from.</param>
        /// <returns>The maximum value contained in the root or nodes below the root.</returns>
        public static int FindMaxValue(Node<int> root)
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

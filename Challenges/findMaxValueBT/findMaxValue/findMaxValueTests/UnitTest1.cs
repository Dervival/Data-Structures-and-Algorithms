using System;
using Xunit;
using findMaxValue;
using Tree.Classes;

namespace findMaxValueTests
{
    public class UnitTest1
    {
        [Fact]
        public void FindMaxValueReturnsInt32MinimumOnEmptyTree()
        {
            BinaryTree<int> emptyTree = new BinaryTree<int>();
            int emptyVal = findMaxValue.Program.FindMaxValue(emptyTree);
            Assert.Equal(Int32.MinValue, emptyVal);
        }

        [Fact]
        public void FindMaxValueReturnsValueOfSingleNode()
        {
            BinaryTree<int> emptyTree = new BinaryTree<int>(10);
            int emptyVal = findMaxValue.Program.FindMaxValue(emptyTree);
            Assert.Equal(10, emptyVal);
        }

        [Fact]
        public void FindMaxValueReturnsMaxValueOnALeaf()
        {
            BinaryTree<int> binaryTree = new BinaryTree<int>(10);
            binaryTree.Root.LeftChild = new Node<int>(15);
            binaryTree.Root.RightChild = new Node<int>(25);
            binaryTree.Root.LeftChild.LeftChild = new Node<int>(0);
            binaryTree.Root.RightChild.LeftChild = new Node<int>(200);
            binaryTree.Root.RightChild.RightChild = new Node<int>(10);
            int maxVal = findMaxValue.Program.FindMaxValue(binaryTree);
            Assert.Equal(200, maxVal);
        }

        [Fact]
        public void FindMaxValueReturnsMaxValueOnAnInternalNode()
        {
            BinaryTree<int> binaryTree = new BinaryTree<int>(10);
            binaryTree.Root.LeftChild = new Node<int>(15);
            binaryTree.Root.RightChild = new Node<int>(500);
            binaryTree.Root.LeftChild.LeftChild = new Node<int>(0);
            binaryTree.Root.RightChild.LeftChild = new Node<int>(200);
            binaryTree.Root.RightChild.RightChild = new Node<int>(10);
            int maxVal = findMaxValue.Program.FindMaxValue(binaryTree);
            Assert.Equal(500, maxVal);
        }

        [Fact]
        public void FindMaxValueReturnsMaxValueWithNegativeValues()
        {
            BinaryTree<int> binaryTree = new BinaryTree<int>(-10);
            binaryTree.Root.LeftChild = new Node<int>(-15);
            binaryTree.Root.RightChild = new Node<int>(-25);
            binaryTree.Root.LeftChild.LeftChild = new Node<int>(-1);
            binaryTree.Root.RightChild.LeftChild = new Node<int>(-200);
            binaryTree.Root.RightChild.RightChild = new Node<int>(-10);
            int maxVal = findMaxValue.Program.FindMaxValue(binaryTree);
            Assert.Equal(-1, maxVal);
        }
    }
}

using System;
using Xunit;
using System.Collections.Generic;
using Tree.Classes;
using StacksAndQueues.Classes;

namespace BreadthFirstTests
{
    public class UnitTest1
    {
        [Fact]
        public void BFPrintWillNotThrowAnExceptionWithNullTree()
        {
            BinaryTree<int> newTree = new BinaryTree<int>();
            breadthFirst.Program.BreadthFirstPrint(newTree);
        }

        [Fact]
        public void BFPrintWillNotThrowAnExceptionWithPerfectTree()
        {
            BinaryTree<int> newTree = new BinaryTree<int>(2);
            newTree.Root.LeftChild = new Tree.Classes.Node<int>(7);
            newTree.Root.RightChild = new Tree.Classes.Node<int>(5);
            breadthFirst.Program.BreadthFirstPrint(newTree);
        }

        [Fact]
        public void BFPrintWillNotThrowAnExceptionWithImperfectTree()
        {
            BinaryTree<int> newTree = new BinaryTree<int>(2);
            newTree.Root.LeftChild = new Tree.Classes.Node<int>(7);
            newTree.Root.RightChild = new Tree.Classes.Node<int>(5);
            newTree.Root.LeftChild.LeftChild = new Tree.Classes.Node<int>(2);
            newTree.Root.LeftChild.RightChild = new Tree.Classes.Node<int>(6);
            newTree.Root.RightChild.RightChild = new Tree.Classes.Node<int>(9);
            newTree.Root.LeftChild.RightChild.LeftChild = new Tree.Classes.Node<int>(5);
            newTree.Root.LeftChild.RightChild.RightChild = new Tree.Classes.Node<int>(11);
            newTree.Root.RightChild.RightChild.LeftChild = new Tree.Classes.Node<int>(4);
            breadthFirst.Program.BreadthFirstPrint(newTree);
        }

        [Fact]
        public void BFListGracefullyRunsOnAnEmptyTree()
        {
            BinaryTree<int> newTree = new BinaryTree<int>();
            List<int> bfList = breadthFirst.Program.BreadthFirstList(newTree);
            List<int> emptyList = new List<int>();
            Assert.Equal(emptyList, bfList);
        }

        [Fact]
        public void BFListRunsAsExpectedOnAPerfectTree()
        {
            BinaryTree<int> newTree = new BinaryTree<int>(2);
            newTree.Root.LeftChild = new Tree.Classes.Node<int>(7);
            newTree.Root.RightChild = new Tree.Classes.Node<int>(5);
            List<int> bfList = breadthFirst.Program.BreadthFirstList(newTree);
            List<int> expectedList = new List<int> { 2, 7, 5 };
            Assert.Equal(expectedList, bfList);
        }

        [Fact]
        public void BFListRunsAsExpectedOnAnImperfectTree()
        {
            BinaryTree<int> newTree = new BinaryTree<int>(2);
            newTree.Root.LeftChild = new Tree.Classes.Node<int>(7);
            newTree.Root.RightChild = new Tree.Classes.Node<int>(5);
            newTree.Root.LeftChild.LeftChild = new Tree.Classes.Node<int>(2);
            newTree.Root.LeftChild.RightChild = new Tree.Classes.Node<int>(6);
            newTree.Root.RightChild.RightChild = new Tree.Classes.Node<int>(9);
            newTree.Root.LeftChild.RightChild.LeftChild = new Tree.Classes.Node<int>(5);
            newTree.Root.LeftChild.RightChild.RightChild = new Tree.Classes.Node<int>(11);
            newTree.Root.RightChild.RightChild.LeftChild = new Tree.Classes.Node<int>(4);
            List<int> bfList = breadthFirst.Program.BreadthFirstList(newTree);
            List<int> expectedList = new List<int> { 2, 7, 5, 2, 6, 9, 5, 11, 4 };
            Assert.Equal(expectedList, bfList);
        }

        [Fact]
        public void BFListRunsAsExpectedOnTreeUsedForWhiteboard()
        {
            BinaryTree<int> newTree = new BinaryTree<int>(1);
            newTree.Root.LeftChild = new Tree.Classes.Node<int>(2);
            newTree.Root.RightChild = new Tree.Classes.Node<int>(3);
            newTree.Root.LeftChild.RightChild = new Tree.Classes.Node<int>(4);
            newTree.Root.LeftChild.RightChild.LeftChild = new Tree.Classes.Node<int>(7);
            newTree.Root.RightChild.LeftChild = new Tree.Classes.Node<int>(5);
            newTree.Root.RightChild.RightChild = new Tree.Classes.Node<int>(6);
            newTree.Root.RightChild.RightChild.LeftChild = new Tree.Classes.Node<int>(8);
            List<int> bfList = breadthFirst.Program.BreadthFirstList(newTree);
            List<int> expectedList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8};
            Assert.Equal(expectedList, bfList);
        }
    }
}

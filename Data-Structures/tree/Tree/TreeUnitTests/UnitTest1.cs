using System;
using Xunit;
using System.Collections.Generic;
using Tree.Classes;

namespace TreeUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanInstantiateTreeFromValue()
        {
            BinaryTree<int> newTree = new BinaryTree<int>(10);
            Assert.True(newTree.Root.Value == 10);
        }

        [Fact]
        public void CanInstantiateTreeFromNode()
        {
            Node<int> newNode = new Node<int>(10);
            BinaryTree<int> newTree = new BinaryTree<int>(newNode);
            Assert.True(newTree.Root.Value == 10);
        }

        [Fact]
        public void CanInstantiateEmptyTreeAndLaterSetItsRoot()
        {
            Node<int> newNode = new Node<int>(10);
            BinaryTree<int> newTree = new BinaryTree<int>();
            newTree.Root = newNode;
            Assert.True(newTree.Root.Value == 10);
        }

        [Fact]
        public void CanInstantiateEmptyTreeAndLaterSetItsRootAndChildren()
        {
            Node<int> newNode = new Node<int>(10);
            Node<int> leftNode = new Node<int>(20);
            BinaryTree<int> newTree = new BinaryTree<int>();
            newTree.Root = newNode;
            newTree.Root.LeftChild = leftNode;
            newTree.Root.RightChild = new Node<int>(200);
            Assert.True(newTree.Root.LeftChild.Value == 20);
            Assert.True(newTree.Root.RightChild.Value == 200);
        }

        [Fact]
        public void PreOrderSearchTraversesAsExpectedOnFullTree()
        {
            BinaryTree<int> binaryTree = new BinaryTree<int>(100);
            binaryTree.Root.LeftChild = new Node<int>(150)
            {
                LeftChild = new Node<int>(250),
                RightChild = new Node<int>(20)
            };
            binaryTree.Root.RightChild = new Node<int>(33)
            {
                LeftChild = new Node<int>(99),
                RightChild = new Node<int>(66)
            };

            List<int> expectedList = new List<int> { 100, 150, 250, 20, 33, 99, 66 };
            List<int> traversalList = binaryTree.PreOrderTraversal();
            Assert.Equal(expectedList, traversalList);
        }

        [Fact]
        public void PreOrderSearchTraversesAsExpectedOnPartialTree()
        {
            BinaryTree<int> binaryTree = new BinaryTree<int>(100);
            binaryTree.Root.LeftChild = new Node<int>(150)
            {
                LeftChild = new Node<int>(250),
                RightChild = new Node<int>(20)
            };
            binaryTree.Root.RightChild = new Node<int>(33)
            {
                RightChild = new Node<int>(66)
            };

            List<int> expectedList = new List<int> { 100, 150, 250, 20, 33, 66 };
            List<int> traversalList = binaryTree.PreOrderTraversal();
            Assert.Equal(expectedList, traversalList);
        }

        [Fact]
        public void PreOrderSearchTraversesAsExpectedOnSecondPartialTree()
        {
            BinaryTree<int> binaryTree = new BinaryTree<int>(100);
            binaryTree.Root.LeftChild = new Node<int>(150);
            binaryTree.Root.RightChild = new Node<int>(33)
            {
                LeftChild = new Node<int>(99),
                RightChild = new Node<int>(66)
            };

            List<int> expectedList = new List<int> { 100, 150, 33, 99, 66 };
            List<int> traversalList = binaryTree.PreOrderTraversal();
            Assert.Equal(expectedList, traversalList);
        }

        [Fact]
        public void PreOrderSearchHandlesAnEmptyTreeGracefully()
        {
            BinaryTree<int> emptyTree = new BinaryTree<int>();
            Assert.Null(emptyTree.PreOrderTraversal());
        }

        [Fact]
        public void InOrderSearchTraversesAsExpectedOnFullTree()
        {
            BinaryTree<int> binaryTree = new BinaryTree<int>(100);
            binaryTree.Root.LeftChild = new Node<int>(150)
            {
                LeftChild = new Node<int>(250),
                RightChild = new Node<int>(20)
            };
            binaryTree.Root.RightChild = new Node<int>(33)
            {
                LeftChild = new Node<int>(99),
                RightChild = new Node<int>(66)
            };

            List<int> expectedList = new List<int> { 250, 150, 20, 100, 99, 33, 66 };
            List<int> traversalList = binaryTree.InOrderTraversal();
            Assert.Equal(expectedList, traversalList);
        }

        [Fact]
        public void InOrderSearchTraversesAsExpectedOnPartialTree()
        {
            BinaryTree<int> binaryTree = new BinaryTree<int>(100);
            binaryTree.Root.LeftChild = new Node<int>(150)
            {
                LeftChild = new Node<int>(250),
                RightChild = new Node<int>(20)
            };
            binaryTree.Root.RightChild = new Node<int>(33)
            {
                RightChild = new Node<int>(66)
            };

            List<int> expectedList = new List<int> { 250, 150, 20, 100, 33, 66 };
            List<int> traversalList = binaryTree.InOrderTraversal();
            Assert.Equal(expectedList, traversalList);
        }

        [Fact]
        public void InOrderSearchTraversesAsExpectedOnSecondPartialTree()
        {
            BinaryTree<int> binaryTree = new BinaryTree<int>(100);
            binaryTree.Root.LeftChild = new Node<int>(150);
            binaryTree.Root.RightChild = new Node<int>(33)
            {
                LeftChild = new Node<int>(99),
                RightChild = new Node<int>(66)
            };

            List<int> expectedList = new List<int> { 150, 100, 99, 33, 66 };
            List<int> traversalList = binaryTree.InOrderTraversal();
            Assert.Equal(expectedList, traversalList);
        }

        [Fact]
        public void InOrderSearchHandlesAnEmptyTreeGracefully()
        {
            BinaryTree<int> emptyTree = new BinaryTree<int>();
            Assert.Null(emptyTree.InOrderTraversal());
        }

        [Fact]
        public void PostOrderSearchTraversesAsExpectedOnFullTree()
        {
            BinaryTree<int> binaryTree = new BinaryTree<int>(100);
            binaryTree.Root.LeftChild = new Node<int>(150)
            {
                LeftChild = new Node<int>(250),
                RightChild = new Node<int>(20)
            };
            binaryTree.Root.RightChild = new Node<int>(33)
            {
                LeftChild = new Node<int>(99),
                RightChild = new Node<int>(66)
            };

            List<int> expectedList = new List<int> { 250, 20, 150, 99, 66, 33, 100};
            List<int> traversalList = binaryTree.PostOrderTraversal();
            Assert.Equal(expectedList, traversalList);
        }

        [Fact]
        public void PostOrderSearchTraversesAsExpectedOnPartialTree()
        {
            BinaryTree<int> binaryTree = new BinaryTree<int>(100);
            binaryTree.Root.LeftChild = new Node<int>(150)
            {
                LeftChild = new Node<int>(250),
                RightChild = new Node<int>(20)
            };
            binaryTree.Root.RightChild = new Node<int>(33)
            {
                RightChild = new Node<int>(66)
            };

            List<int> expectedList = new List<int> { 250, 20, 150, 66, 33, 100 };
            List<int> traversalList = binaryTree.PostOrderTraversal();
            Assert.Equal(expectedList, traversalList);
        }

        [Fact]
        public void PostOrderSearchTraversesAsExpectedOnSecondPartialTree()
        {
            BinaryTree<int> binaryTree = new BinaryTree<int>(100);
            binaryTree.Root.LeftChild = new Node<int>(150);
            binaryTree.Root.RightChild = new Node<int>(33)
            {
                LeftChild = new Node<int>(99),
                RightChild = new Node<int>(66)
            };

            List<int> expectedList = new List<int> { 150, 99, 66, 33, 100 };
            List<int> traversalList = binaryTree.PostOrderTraversal();
            Assert.Equal(expectedList, traversalList);
        }

        [Fact]
        public void PostOrderSearchHandlesAnEmptyTreeGracefully()
        {
            BinaryTree<int> emptyTree = new BinaryTree<int>();
            Assert.Null(emptyTree.PostOrderTraversal());
        }

        [Fact]
        public void AddCanAddToEmptyBinarySearchTree()
        {
            BinarySearchTree newTree = new BinarySearchTree();
            newTree.Add(100);
            Assert.Equal(100, newTree.Root.Value);
        }

        [Fact]
        public void AddCanAddToNonEmptyBinarySearchTree()
        {
            BinarySearchTree newTree = new BinarySearchTree();
            newTree.Add(100);
            newTree.Add(50);
            newTree.Add(75);
            Assert.Equal(50, newTree.Root.LeftChild.Value);
            Assert.Equal(75, newTree.Root.LeftChild.RightChild.Value);
        }

        [Fact]
        public void AddCanAddDuplicateValuesToTheRightInBST()
        {
            BinarySearchTree newTree = new BinarySearchTree();
            newTree.Add(100);
            newTree.Add(50);
            newTree.Add(50);
            Assert.Equal(50, newTree.Root.LeftChild.Value);
            Assert.Equal(50, newTree.Root.LeftChild.RightChild.Value);
        }

        [Fact]
        public void InOrderTraversalOfBSTReturnsOrderedList()
        {
            BinarySearchTree newTree = new BinarySearchTree(100);
            newTree.Add(200);
            newTree.Add(300);
            newTree.Add(999);
            newTree.Add(10);
            newTree.Add(4);
            List<int> treeList = newTree.InOrderTraversal();
            List<int> sortedList = new List<int>(){ 4,10,100,200,300,999};
            Assert.Equal(sortedList, treeList);
        }
    }
}

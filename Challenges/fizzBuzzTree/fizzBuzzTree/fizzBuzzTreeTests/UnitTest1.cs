using System;
using Xunit;
using Tree.Classes;

namespace fizzBuzzTreeTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(5, "Buzz")]
        [InlineData(10, "Buzz")]
        [InlineData(15, "FizzBuzz")]
        [InlineData(6, "Fizz")]
        public void FizzBuzzTreeCanChangeRoot(int value, string fb)
        {
            BinaryTree<object> newTree = new BinaryTree<object>(value);
            fizzBuzzTree.Program.FizzBuzzTree(newTree);
            Assert.True((string)newTree.Root.Value == fb);
        }

        [Theory]
        [InlineData(4)]
        [InlineData(2)]
        [InlineData(98)]
        public void FizzBuzzTreeCanLeaveRootUntouched(int value)
        {
            BinaryTree<object> newTree = new BinaryTree<object>(value);
            fizzBuzzTree.Program.FizzBuzzTree(newTree);
            Assert.True((int)newTree.Root.Value == value);
        }

        [Fact]
        public void FizzBuzzCanModifyLeftChildren()
        {
            BinaryTree<object> binaryTree = new BinaryTree<object>(7);
            binaryTree.Root.LeftChild = new Node<object>(6);
            binaryTree.Root.LeftChild.LeftChild = new Node<object>(2);
            binaryTree.Root.LeftChild.RightChild = new Node<object>(15);
            fizzBuzzTree.Program.FizzBuzzTree(binaryTree);
            Assert.True((string)binaryTree.Root.LeftChild.Value == "Fizz");
            Assert.True((int)binaryTree.Root.LeftChild.LeftChild.Value == 2);
            Assert.True((string)binaryTree.Root.LeftChild.RightChild.Value == "FizzBuzz");
        }

        [Fact]
        public void FizzBuzzCanModifyRightChildren()
        {
            BinaryTree<object> binaryTree = new BinaryTree<object>(7);
            binaryTree.Root.RightChild = new Node<object>(6);
            binaryTree.Root.RightChild.LeftChild = new Node<object>(2);
            binaryTree.Root.RightChild.RightChild = new Node<object>(15);
            fizzBuzzTree.Program.FizzBuzzTree(binaryTree);
            Assert.True((string)binaryTree.Root.RightChild.Value == "Fizz");
            Assert.True((int)binaryTree.Root.RightChild.LeftChild.Value == 2);
            Assert.True((string)binaryTree.Root.RightChild.RightChild.Value == "FizzBuzz");
        }
    }
}

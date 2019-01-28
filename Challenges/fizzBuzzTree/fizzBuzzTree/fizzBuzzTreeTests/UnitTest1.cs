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
    }
}

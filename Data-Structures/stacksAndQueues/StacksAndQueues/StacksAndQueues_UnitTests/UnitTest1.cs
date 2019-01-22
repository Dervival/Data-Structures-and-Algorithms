using System;
using Xunit;
using StacksAndQueues.Classes;

namespace StacksAndQueues_UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanInitializeStackWithValue()
        {
            int testValue = 10;
            Stack newStack = new Stack(testValue);
            Assert.Equal(10, newStack.Top.Value);
        }

        [Fact]
        public void CanInitializeStackWithNode()
        {
            Node newNode = new Node(10);
            Stack newStack = new Stack(newNode);
            Assert.Equal(10, newStack.Top.Value);
        }

        [Fact]
        public void InitializingWithValueEqualsInitializingWithNode()
        {
            Node newNode = new Node(10);
            Stack newStackOne = new Stack(newNode);
            Stack newStackTwo = new Stack(10);
            Assert.True(newStackOne.Top.Value == newStackTwo.Top.Value);
        }

        [Fact]
        public void CanPushValueToEmptyStack()
        {
            Stack newStack = new Stack();
            newStack.Push(10);
            Assert.Equal(10, newStack.Top.Value);
        }

        [Fact]
        public void CanPushValueToNonEmptyStack()
        {
            Stack newStack = new Stack(5);
            newStack.Push(10);
            Assert.Equal(10, newStack.Top.Value);
        }

        [Fact]
        public void StackBeingPushedValuesToHasMostRecentlyPushedValueOnTop()
        {
            Stack newStack = new Stack(5);
            newStack.Push(10);
            newStack.Push(20);
            Assert.Equal(20, newStack.Top.Value);
        }

        [Fact]
        public void CanPushNodeToEmptyStack()
        {
            Stack newStack = new Stack();
            Node newNode = new Node(10);
            newStack.Push(newNode);
            Assert.Equal(10, newStack.Top.Value);
        }

        [Fact]
        public void CanPushNodeToNonEmptyStack()
        {
            Stack newStack = new Stack(5);
            Node newNode = new Node(10);
            newStack.Push(newNode);
            Assert.Equal(10, newStack.Top.Value);
        }

        [Fact]
        public void StackBeingPushedNodesToHasMostRecentlyPushedValueOnTop()
        {
            Stack newStack = new Stack(5);
            Node newNode = new Node(20);
            newStack.Push(10);
            newStack.Push(newNode);
            Assert.Equal(20, newStack.Top.Value);
        }

        [Fact]
        public void StackCanPopValue()
        {
            Stack newStack = new Stack(5);
            newStack.Push(10);
            Node poppedNode = newStack.Pop();
            Assert.Equal(10, poppedNode.Value);
        }

        [Fact]
        public void PopDoesNotMutateEarlierValues()
        {
            Stack newStack = new Stack(5);
            newStack.Push(10);
            Node poppedNode = newStack.Pop();
            Assert.Equal(5, newStack.Top.Value);
        }

        [Fact]
        public void PopThrowsNullReferenceExceptionOnEmptyStack()
        {
            Stack emptyStack = new Stack();
            Assert.Throws<NullReferenceException>(() => emptyStack.Pop());
        }

        [Fact]
        public void StackCanPeekValue()
        {
            Stack newStack = new Stack(5);
            Node poppedNode = newStack.Peek();
            Assert.Equal(5, poppedNode.Value);
        }

        [Fact]
        public void PeekDoesNotPopValuesFromStack()
        {
            Stack newStack = new Stack(5);
            newStack.Push(10);
            Node poppedNode = newStack.Peek();
            Assert.Equal(poppedNode.Value, newStack.Top.Value);
        }

        [Fact]
        public void PeekDoesNotNullReferenceExceptionOnEmptyStack()
        {
            Stack emptyStack = new Stack();
            Node newNode = emptyStack.Peek();
            Assert.Null(newNode);
        }
    }
}

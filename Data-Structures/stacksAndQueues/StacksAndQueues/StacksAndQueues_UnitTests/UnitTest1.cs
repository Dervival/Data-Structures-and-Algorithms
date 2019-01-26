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

        [Fact]
        public void QueueCanBeInstantiatedWithValue()
        {
            Queue testQueue = new Queue(10);
            Assert.Equal(10, testQueue.Front.Value);
        }

        [Fact]
        public void QueueCanBeInstantiatedWithNode()
        {
            Node newNode = new Node(10);
            Queue testQueue = new Queue(newNode);
            Assert.Equal(10, testQueue.Front.Value);
        }

        [Fact]
        public void FrontAndRearMatchWhenQueueIsInstantiated()
        {
            Queue testQueue = new Queue(100);
            Assert.Equal(testQueue.Rear.Value, testQueue.Front.Value);
        }

        [Fact]
        public void EnqueueDoesNotModifyFrontNodeOfNonEmptyQueue()
        {
            Node frontNode = new Node(7);
            Node rearNode = new Node(99);
            Queue testQueue = new Queue(frontNode);
            testQueue.Enqueue(rearNode);
            Assert.True(frontNode.Value == testQueue.Front.Value);
        }

        [Fact]
        public void EnqueueCanQueueNodes()
        {
            Queue testQueue = new Queue(10);
            Node newNode = new Node(100);
            testQueue.Enqueue(newNode);
            Assert.Equal(100, testQueue.Rear.Value);
        }

        [Fact]
        public void EnqueueAddsBehindTheFrontNodeOfQueueWithOneElement()
        {
            Node frontNode = new Node(7);
            Node rearNode = new Node(99);
            Queue testQueue = new Queue(frontNode);
            testQueue.Enqueue(rearNode);
            Assert.True(rearNode.Value == testQueue.Front.Next.Value);
        }

        [Fact]
        public void DequeueReturnsFrontNode()
        {
            Queue testQueue = new Queue(10);
            Node newNode = testQueue.Dequeue();
            Assert.Equal(10, newNode.Value);
        }

        [Fact]
        public void DequeueMutatesFrontNode()
        {
            Queue testQueue = new Queue(10);
            testQueue.Enqueue(5);
            Node newNode = testQueue.Dequeue();
            Assert.False(newNode.Value == testQueue.Front.Value);
        }

        [Fact]
        public void DequeueReturnsNullOnEmptyQueue()
        {
            Queue testQueue = new Queue();
            Assert.Null(testQueue.Dequeue());
        }

        [Fact]
        public void PeekReturnsFrontNode()
        {
            Queue testQueue = new Queue(10);
            Node newNode = testQueue.Peek();
            Assert.Equal(10, newNode.Value);
        }

        [Fact]
        public void PeekDoesNotMutateFrontNode()
        {
            Queue testQueue = new Queue(10);
            testQueue.Enqueue(5);
            Node newNode = testQueue.Peek();
            Assert.True(newNode.Value == testQueue.Front.Value);
        }

        [Fact]
        public void PeekDoesNotThrowsNullReferenceExceptionOnEmptyQueue()
        {
            Queue testQueue = new Queue(0);
            testQueue.Dequeue();
            Node newNode = testQueue.Peek();
            Assert.Null(newNode);
        }
    }
}

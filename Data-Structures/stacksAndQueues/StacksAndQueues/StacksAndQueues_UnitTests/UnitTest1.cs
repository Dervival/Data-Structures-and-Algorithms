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
            Stack<int> newStack = new Stack<int>(testValue);
            Assert.Equal(10, newStack.Top.Value);
        }

        [Fact]
        public void CanInitializeStackWithNode()
        {
            Node<int> newNode = new Node<int>(10);
            Stack<int> newStack = new Stack<int>(newNode);
            Assert.Equal(10, newStack.Top.Value);
        }

        [Fact]
        public void InitializingWithValueEqualsInitializingWithNode()
        {
            Node<int> newNode = new Node<int>(10);
            Stack<int> newStackOne = new Stack<int>(newNode);
            Stack<int> newStackTwo = new Stack<int>(10);
            Assert.True(newStackOne.Top.Value == newStackTwo.Top.Value);
        }

        [Fact]
        public void CanPushValueToEmptyStack()
        {
            Stack<int> newStack = new Stack<int>();
            newStack.Push(10);
            Assert.Equal(10, newStack.Top.Value);
        }

        [Fact]
        public void CanPushValueToNonEmptyStack()
        {
            Stack<int> newStack = new Stack<int>(5);
            newStack.Push(10);
            Assert.Equal(10, newStack.Top.Value);
        }

        [Fact]
        public void StackBeingPushedValuesToHasMostRecentlyPushedValueOnTop()
        {
            Stack<int> newStack = new Stack<int>(5);
            newStack.Push(10);
            newStack.Push(20);
            Assert.Equal(20, newStack.Top.Value);
        }

        [Fact]
        public void CanPushNodeToEmptyStack()
        {
            Stack<int> newStack = new Stack<int>();
            Node<int> newNode = new Node<int>(10);
            newStack.Push(newNode);
            Assert.Equal(10, newStack.Top.Value);
        }

        [Fact]
        public void CanPushNodeToNonEmptyStack()
        {
            Stack<int> newStack = new Stack<int>(5);
            Node<int> newNode = new Node<int>(10);
            newStack.Push(newNode);
            Assert.Equal(10, newStack.Top.Value);
        }

        [Fact]
        public void StackBeingPushedNodesToHasMostRecentlyPushedValueOnTop()
        {
            Stack<int> newStack = new Stack<int>(5);
            Node<int> newNode = new Node<int>(20);
            newStack.Push(10);
            newStack.Push(newNode);
            Assert.Equal(20, newStack.Top.Value);
        }

        [Fact]
        public void StackCanPopValue()
        {
            Stack<int> newStack = new Stack<int>(5);
            newStack.Push(10);
            Node<int> poppedNode = newStack.Pop();
            Assert.Equal(10, poppedNode.Value);
        }

        [Fact]
        public void PopDoesNotMutateEarlierValues()
        {
            Stack<int> newStack = new Stack<int>(5);
            newStack.Push(10);
            Node<int> poppedNode = newStack.Pop();
            Assert.Equal(5, newStack.Top.Value);
        }

        [Fact]
        public void PopThrowsNullReferenceExceptionOnEmptyStack()
        {
            Stack<int> emptyStack = new Stack<int>();
            Assert.Throws<NullReferenceException>(() => emptyStack.Pop());
        }

        [Fact]
        public void StackCanPeekValue()
        {
            Stack<int> newStack = new Stack<int>(5);
            Node<int> poppedNode = newStack.Peek();
            Assert.Equal(5, poppedNode.Value);
        }

        [Fact]
        public void PeekDoesNotPopValuesFromStack()
        {
            Stack<int> newStack = new Stack<int>(5);
            newStack.Push(10);
            Node<int> poppedNode = newStack.Peek();
            Assert.Equal(poppedNode.Value, newStack.Top.Value);
        }

        [Fact]
        public void PeekDoesNotNullReferenceExceptionOnEmptyStack()
        {
            Stack<int> emptyStack = new Stack<int>();
            Node<int> newNode = emptyStack.Peek();
            Assert.Null(newNode);
        }

        [Fact]
        public void QueueCanBeInstantiatedWithValue()
        {
            Queue<int> testQueue = new Queue<int>(10);
            Assert.Equal(10, testQueue.Front.Value);
        }

        [Fact]
        public void QueueCanBeInstantiatedWithNode()
        {
            Node<int> newNode = new Node<int>(10);
            Queue<int> testQueue = new Queue<int>(newNode);
            Assert.Equal(10, testQueue.Front.Value);
        }

        [Fact]
        public void FrontAndRearMatchWhenQueueIsInstantiated()
        {
            Queue<int> testQueue = new Queue<int>(100);
            Assert.Equal(testQueue.Rear.Value, testQueue.Front.Value);
        }

        [Fact]
        public void EnqueueDoesNotModifyFrontNodeOfNonEmptyQueue()
        {
            Node<int> frontNode = new Node<int>(7);
            Node<int> rearNode = new Node<int>(99);
            Queue<int> testQueue = new Queue<int>(frontNode);
            testQueue.Enqueue(rearNode);
            Assert.True(frontNode.Value == testQueue.Front.Value);
        }

        [Fact]
        public void EnqueueCanQueueNodes()
        {
            Queue<int> testQueue = new Queue<int>(10);
            Node<int> newNode = new Node<int>(100);
            testQueue.Enqueue(newNode);
            Assert.Equal(100, testQueue.Rear.Value);
        }

        [Fact]
        public void EnqueueAddsBehindTheFrontNodeOfQueueWithOneElement()
        {
            Node<int> frontNode = new Node<int>(7);
            Node<int> rearNode = new Node<int>(99);
            Queue<int> testQueue = new Queue<int>(frontNode);
            testQueue.Enqueue(rearNode);
            Assert.True(rearNode.Value == testQueue.Front.Next.Value);
        }

        [Fact]
        public void DequeueReturnsFrontNode()
        {
            Queue<int> testQueue = new Queue<int>(10);
            Node<int> newNode = testQueue.Dequeue();
            Assert.Equal(10, newNode.Value);
        }

        [Fact]
        public void DequeueMutatesFrontNode()
        {
            Queue<int> testQueue = new Queue<int>(10);
            testQueue.Enqueue(5);
            Node<int> newNode = testQueue.Dequeue();
            Assert.False(newNode.Value == testQueue.Front.Value);
        }

        [Fact]
        public void DequeueReturnsNullOnEmptyQueue()
        {
            Queue<int> testQueue = new Queue<int>();
            Assert.Null(testQueue.Dequeue());
        }

        [Fact]
        public void PeekReturnsFrontNode()
        {
            Queue<int> testQueue = new Queue<int>(10);
            Node<int> newNode = testQueue.Peek();
            Assert.Equal(10, newNode.Value);
        }

        [Fact]
        public void PeekDoesNotMutateFrontNode()
        {
            Queue<int> testQueue = new Queue<int>(10);
            testQueue.Enqueue(5);
            Node<int> newNode = testQueue.Peek();
            Assert.True(newNode.Value == testQueue.Front.Value);
        }

        [Fact]
        public void PeekDoesNotThrowsNullReferenceExceptionOnEmptyQueue()
        {
            Queue<int> testQueue = new Queue<int>(0);
            testQueue.Dequeue();
            Node<int> newNode = testQueue.Peek();
            Assert.Null(newNode);
        }

        [Fact]
        public void CanIActuallyEnqueueToEmptyQueue()
        {
            Queue<int> newQueue = new Queue<int>();
            newQueue.Enqueue(2);
            int temp = newQueue.Dequeue().Value;
            Assert.True(temp == 2);
        }
    }
}

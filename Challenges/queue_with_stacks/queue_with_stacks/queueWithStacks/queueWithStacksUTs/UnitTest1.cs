using System;
using Xunit;
using StacksAndQueues.Classes;
using queueWithStacks.Classes;

namespace queueWithStacksUTs
{
    public class UnitTest1
    {
        [Fact]
        public void EnqueueChangesAddsValueToTopOfInStack()
        {
            PseudoQueue testPQ = new PseudoQueue();
            testPQ.Enqueue(42);
            Assert.True(testPQ.InStack.Top.Value == 42);
        }

        [Fact]
        public void DequeueReturnsNullIfInStackIsEmpty()
        {
            PseudoQueue nullPQ = new PseudoQueue();
            Node nullNode = nullPQ.Dequeue();
            Assert.Null(nullNode);
        }

        [Fact]
        public void DequeueDoesNotReturnsNullIfInStackIsNotEmpty()
        {
            PseudoQueue testPQ = new PseudoQueue();
            testPQ.Enqueue(99);
            Node testNode = testPQ.Dequeue();
            Assert.NotNull(testNode);
        }

        [Fact]
        public void DequeueReturnsFirstEnqueuedValue()
        {
            PseudoQueue testPQ = new PseudoQueue();
            testPQ.Enqueue(10);
            testPQ.Enqueue(20);
            Node testNode = testPQ.Dequeue();
            Assert.True(testNode.Value == 10);
        }

        /// <summary>
        /// Enqueueing two values, dequeueing the first of those, adding a third; dequeueing should return the second value only
        /// </summary>
        [Fact]
        public void DequeueRemovesFromQueueInExpectedOrder()
        {
            PseudoQueue newPQ = new PseudoQueue();
            newPQ.Enqueue(10);
            newPQ.Enqueue(20);
            newPQ.Dequeue();
            newPQ.Enqueue(30);
            Node testNode = newPQ.Dequeue();
            Assert.True(20 == testNode.Value);
        }

        /// <summary>
        /// Silly little test - can we do a rotation with just re-enqueueing previously dequeued values?
        /// </summary>
        [Fact]
        public void PseudoQueueCanReenqueueDequeuedValuesSanely()
        {
            PseudoQueue newPQ = new PseudoQueue();
            newPQ.Enqueue(10);
            newPQ.Enqueue(20);
            newPQ.Enqueue(30);
            //At this point newPQ should look like null <- 30 <- 20 <- 10 <- "front"
            newPQ.Enqueue(newPQ.Dequeue().Value);
            //Should be null <- 10 <- 30 <- 20 <- "front"
            Node topNode = newPQ.Dequeue();
            Assert.True(topNode.Value == 20);
            topNode = newPQ.Dequeue();
            Assert.True(topNode.Value == 30);
            topNode = newPQ.Dequeue();
            Assert.True(topNode.Value == 10);
        }
    }
}

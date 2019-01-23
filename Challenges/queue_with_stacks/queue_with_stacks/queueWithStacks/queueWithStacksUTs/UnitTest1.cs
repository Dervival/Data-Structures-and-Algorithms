using System;
using Xunit;
using StacksAndQueues.Classes;
using queueWithStacks.Classes;

namespace queueWithStacksUTs
{
    public class UnitTest1
    {
        [Fact]
        public void BigTest()
        {
            PseudoQueue newPQ = new PseudoQueue();
            newPQ.Enqueue(10);
            newPQ.Enqueue(20);
            Node testNode = newPQ.Dequeue();
            Assert.True(10 == testNode.Value);
        }
    }
}

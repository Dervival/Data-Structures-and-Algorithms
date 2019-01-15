using System;
using Xunit;
using LinkedList;
using LinkedList.Classes;

namespace LinkedListUnitTests
{
    public class UnitTest1
    {
        //Testing instantiation (and CountNodes)
        [Fact]
        public void LListCanInstantiateEmptyList()
        {
            LList linkedList = new LList();
            Assert.Equal(0, linkedList.CountNodes());
        }
        [Fact]
        public void LListCanInstantiateListWithInitialNode()
        {
            Node testNode = new Node(10);
            LList linkedList = new LList(testNode);
            Assert.Equal(1, linkedList.CountNodes());
        }

        //Testing insertion of values
        [Fact]
        public void InsertCanInsertValueIntoEmptyList()
        {
            LList linkedList = new LList();
            linkedList.Insert(10);
            Assert.Equal(1, linkedList.CountNodes());
        }
        [Fact]
        public void InsertCanInsertValueIntoNonEmptyList()
        {
            Node testNode = new Node(10);
            LList linkedList = new LList(testNode);
            linkedList.Insert(20);
            Assert.Equal(2, linkedList.CountNodes());
        }
        [Fact]
        public void InsertCanInsertValueIntoListPreviouslyInsertedInto()
        {
            LList linkedList = new LList();
            linkedList.Insert(10);
            linkedList.Insert(20);
            Assert.Equal(2, linkedList.CountNodes());
        }

        //Testing insertion of nodes
        [Fact]
        public void InsertCanInsertNodeIntoEmptyList()
        {
            LList linkedList = new LList();
            Node testNode = new Node(10);
            linkedList.Insert(testNode);
            Assert.Equal(1, linkedList.CountNodes());
        }
        [Fact]
        public void InsertCanInsertNodeIntoNonEmptyList()
        {
            Node testNode = new Node(10);
            LList linkedList = new LList(testNode);
            Node testNodeTwo = new Node(20);
            linkedList.Insert(testNodeTwo);
            Assert.Equal(2, linkedList.CountNodes());
        }
        [Fact]
        public void InsertCanInsertNodeIntoListPreviouslyInsertedInto()
        {
            LList linkedList = new LList();
            Node testNode = new Node(10);
            Node testNodeTwo = new Node(20);
            linkedList.Insert(testNode);
            linkedList.Insert(testNodeTwo);
            Assert.Equal(2, linkedList.CountNodes());
        }

        //Testing includes functionality
        [Fact]
        public void IncludesDoesNotThrowAnExceptionOnEmptyList()
        {
            LList linkedList = new LList();
            Assert.False(linkedList.Includes(10));
        }
        [Fact]
        public void IncludesReturnsTrueForElementInList()
        {
            LList linkedList = new LList();
            linkedList.Insert(10);
            linkedList.Insert(20);
            linkedList.Insert(30);
            Assert.True(linkedList.Includes(20));
        }
        [Fact]
        public void IncludesReturnsFalseForElementNotInList()
        {
            LList linkedList = new LList();
            linkedList.Insert(10);
            linkedList.Insert(20);
            linkedList.Insert(30);
            Assert.False(linkedList.Includes(40));
        }

        //Testing print functionality
        [Fact]
        public void PrintDoesNotThrowAnExceptionOnEmptyList()
        {
            LList linkedList = new LList();
            linkedList.Print();
        }
        [Fact]
        public void PrintDoesNotThrowAnExceptionOnListWithOneElement()
        {
            LList linkedList = new LList();
            linkedList.Insert(10);
            linkedList.Print();
        }
        [Fact]
        public void PrintDoesNotThrowAnExceptionOnListWithMultipleElements()
        {
            LList linkedList = new LList();
            linkedList.Insert(20);
            linkedList.Insert(10);
            linkedList.Print();
        }

        //Testing append functionality
        [Fact]
        public void AppendCanAppendNodeToEmptyList()
        {
            LList linkedList = new LList();
            Node testNode = new Node(10);
            linkedList.Append(testNode);
            Assert.Equal(1, linkedList.CountNodes());
        }
        [Fact]
        public void AppendCanAppendNodeToNonEmptyList()
        {
            Node testNode = new Node(10);
            LList linkedList = new LList(testNode);
            Node testNodeTwo = new Node(20);
            linkedList.Append(testNodeTwo);
            Assert.Equal(2, linkedList.CountNodes());
        }
        [Fact]
        public void AppendAppendsToEndOfList()
        {
            Node testNode = new Node(10);
            LList linkedList = new LList(testNode);
            Node testNodeTwo = new Node(20);
            linkedList.Append(testNodeTwo);
            Assert.Equal(20, linkedList.Head.Next.Value);
        }
        [Fact]
        public void AppendDoesNotAppendToBeginning()
        {
            LList linkedList = new LList();
            Node testNode = new Node(10);
            Node testNodeTwo = new Node(20);
            linkedList.Insert(testNode);
            linkedList.Append(testNodeTwo);
            Assert.NotEqual(20, linkedList.Head.Value);
        }

        //Testing insertbefore functionality

        //Testing insertafter functionality
        //Testing behead functionality
        [Fact]
        public void BeheadDoesNotThrowAnExceptionOnEmptyList()
        {
            LList linkedList = new LList();
            LList linkedListTwo = new LList();
            linkedListTwo.Behead();
            Assert.Equal(linkedList.CountNodes(), linkedListTwo.CountNodes());
        }
        [Fact]
        public void BeheadCanRemoveTheOnlyNodeOfAList()
        {
            LList linkedList = new LList();
            linkedList.Insert(10);
            linkedList.Behead();
            Assert.Equal(0, linkedList.CountNodes());
        }
        [Fact]
        public void BeheadCanRemoveTheFirstNodeFromAList()
        {
            LList linkedList = new LList();
            linkedList.Insert(20);
            linkedList.Insert(10);
            linkedList.Behead();
            Assert.Equal(20, linkedList.Head.Value);
        }


    }
}

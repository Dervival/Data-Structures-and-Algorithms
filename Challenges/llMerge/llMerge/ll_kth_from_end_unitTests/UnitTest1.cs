using System;
using Xunit;
using ll_merge;
using LinkedList.Classes;

namespace ll_kth_from_end_unitTests
{
    public class UnitTest1
    {
        [Fact]
        public void MergeCanMergeTwoEqualLengthLists()
        {
            LList linkedList = new LList();
            // 20 -> 15 -> 10;
            linkedList.Append(20);
            linkedList.Append(15);
            linkedList.Append(10);
            LList linkedListTwo = new LList();
            // 200 -> 150 -> 100;
            linkedListTwo.Append(200);
            linkedListTwo.Append(150);
            linkedListTwo.Append(100);
            Program.MergeLists(linkedList, linkedListTwo);
            // 20 -> 200 -> 15 -> 150 -> 10 -> 100;
            Assert.Equal(6, linkedList.CountNodes());
        }
        [Fact]
        public void MergeCanMergeTwoEqualLengthListsWithCorrectValues()
        {
            LList linkedList = new LList();
            // 20 -> 15 -> 10;
            linkedList.Append(20);
            linkedList.Append(15);
            linkedList.Append(10);
            LList linkedListTwo = new LList();
            // 200 -> 150 -> 100;
            linkedListTwo.Append(200);
            linkedListTwo.Append(150);
            linkedListTwo.Append(100);
            Program.MergeLists(linkedList, linkedListTwo);
            // 20 -> 200 -> 15 -> 150 -> 10 -> 100;
            Assert.Equal(20, linkedList.Head.Value);
            Assert.Equal(200, linkedList.Head.Next.Value);
            Assert.Equal(15, linkedList.Head.Next.Next.Value);
            Assert.Equal(150, linkedList.Head.Next.Next.Next.Value);
            Assert.Equal(10, linkedList.Head.Next.Next.Next.Next.Value);
            Assert.Equal(100, linkedList.Head.Next.Next.Next.Next.Next.Value);
        }
        [Fact]
        public void MergeDeletesSecondLinkedList()
        {
            LList linkedList = new LList();
            // 20 -> 15 -> 10;
            linkedList.Append(20);
            linkedList.Append(15);
            linkedList.Append(10);
            LList linkedListTwo = new LList();
            // 200 -> 150 -> 100;
            linkedListTwo.Append(200);
            linkedListTwo.Append(150);
            linkedListTwo.Append(100);
            Program.MergeLists(linkedList, linkedListTwo);
            // NULL;
            Assert.Equal(0, linkedListTwo.CountNodes());
        }
        [Fact]
        public void MergeWorksWithLL1LongerThanLL2()
        {
            LList linkedList = new LList();
            // 20 -> 15 -> 10;
            linkedList.Append(20);
            linkedList.Append(15);
            linkedList.Append(10);
            LList linkedListTwo = new LList();
            // 200 -> 150;
            linkedListTwo.Append(200);
            linkedListTwo.Append(150);
            Program.MergeLists(linkedList, linkedListTwo);
            // 20 -> 200 -> 15 -> 150 -> 10;
            Assert.Equal(5, linkedList.CountNodes());
        }
        [Fact]
        public void MergeWorksWithLL2LongerThanLL1()
        {
            LList linkedList = new LList();
            // 20 -> 15;
            linkedList.Append(20);
            linkedList.Append(15);
            LList linkedListTwo = new LList();
            // 200 -> 150 -> 100;
            linkedListTwo.Append(200);
            linkedListTwo.Append(150);
            linkedListTwo.Append(100);
            Program.MergeLists(linkedList, linkedListTwo);
            // 20 -> 200 -> 15 -> 150 -> 100;
            Assert.Equal(5, linkedList.CountNodes());
        }
        [Fact]
        public void MergeWorksWithEmptyLL2()
        {
            LList linkedList = new LList();
            // 20 -> 15 -> 10;
            linkedList.Append(20);
            linkedList.Append(15);
            linkedList.Append(10);
            LList linkedListTwo = new LList();
            // Null;
            Program.MergeLists(linkedList, linkedListTwo);
            // 20 -> 15 -> 10;
            Assert.Equal(3, linkedList.CountNodes());
        }
        //[Fact]
        //public void KthFromEndCanReturnBeginning()
        //{
        //    LList linkedList = new LList();
        //    linkedList.Insert(20);
        //    linkedList.Insert(15);
        //    linkedList.Insert(10);
        //    int kth = ll_kth_from_end.Program.LinkedListKthFromEnd(linkedList, 2);
        //    Assert.Equal(10, kth);
        //}

        //[Fact]
        //public void KthFromEndCanReturnMiddleIndexToo()
        //{
        //    LList linkedList = new LList();
        //    linkedList.Insert(20);
        //    linkedList.Insert(999);
        //    linkedList.Insert(15);
        //    linkedList.Insert(-999);
        //    linkedList.Insert(10);
        //    int kth = ll_kth_from_end.Program.LinkedListKthFromEnd(linkedList, 2);
        //    Assert.Equal(15, kth);
        //}

        //[Fact]
        //public void KthFromEndThrowsExceptionOnNegativeK()
        //{
        //    LList linkedList = new LList();
        //    linkedList.Insert(20);
        //    linkedList.Insert(15);
        //    linkedList.Insert(10);
        //    //Credit to https://stackoverflow.com/questions/45017295/assert-an-exception-using-xunit for showing how to use a lambda function with Assert.Throws<T>
        //    Assert.Throws<IndexOutOfRangeException>(() => ll_kth_from_end.Program.LinkedListKthFromEnd(linkedList, -1));
        //}

        //[Fact]
        //public void KthFromEndThrowsExceptionOnTooLargeOfK()
        //{
        //    LList linkedList = new LList();
        //    linkedList.Insert(20);
        //    linkedList.Insert(15);
        //    linkedList.Insert(10);
        //    //Credit to https://stackoverflow.com/questions/45017295/assert-an-exception-using-xunit for showing how to use a lambda function with Assert.Throws<T>
        //    Assert.Throws<IndexOutOfRangeException>(() => ll_kth_from_end.Program.LinkedListKthFromEnd(linkedList, 3));
        //    Assert.Throws<IndexOutOfRangeException>(() => ll_kth_from_end.Program.LinkedListKthFromEnd(linkedList, 4));
        //}
    }
}

using System;
using Xunit;
using ll_kth_from_end;
using LinkedList.Classes;

namespace ll_kth_from_end_unitTests
{
    public class UnitTest1
    {
        [Fact]
        public void KthFromEndCanReturnEnd()
        {
            LList linkedList = new LList();
            // 20->15->10->NULL
            linkedList.Insert(20);
            linkedList.Insert(15);
            linkedList.Insert(10);
            int kth = ll_kth_from_end.Program.LinkedListKthFromEnd(linkedList, 0);
            Assert.Equal(20, kth);
        }

        [Fact]
        public void KthFromEndCanReturnBeginning()
        {
            LList linkedList = new LList();
            linkedList.Insert(20);
            linkedList.Insert(15);
            linkedList.Insert(10);
            int kth = ll_kth_from_end.Program.LinkedListKthFromEnd(linkedList, 2);
            Assert.Equal(10, kth);
        }

        [Fact]
        public void KthFromEndCanReturnMiddleIndexToo()
        {
            LList linkedList = new LList();
            linkedList.Insert(20);
            linkedList.Insert(999);
            linkedList.Insert(15);
            linkedList.Insert(-999);
            linkedList.Insert(10);
            int kth = ll_kth_from_end.Program.LinkedListKthFromEnd(linkedList, 2);
            Assert.Equal(15, kth);
        }

        [Fact]
        public void KthFromEndThrowsExceptionOnNegativeK()
        {
            LList linkedList = new LList();
            linkedList.Insert(20);
            linkedList.Insert(15);
            linkedList.Insert(10);
            //Credit to https://stackoverflow.com/questions/45017295/assert-an-exception-using-xunit for showing how to use a lambda function with Assert.Throws<T>
            Assert.Throws<IndexOutOfRangeException>(() => ll_kth_from_end.Program.LinkedListKthFromEnd(linkedList, -1));
        }

        [Fact]
        public void KthFromEndThrowsExceptionOnTooLargeOfK()
        {
            LList linkedList = new LList();
            linkedList.Insert(20);
            linkedList.Insert(15);
            linkedList.Insert(10);
            //Credit to https://stackoverflow.com/questions/45017295/assert-an-exception-using-xunit for showing how to use a lambda function with Assert.Throws<T>
            Assert.Throws<IndexOutOfRangeException>(() => ll_kth_from_end.Program.LinkedListKthFromEnd(linkedList, 3));
            Assert.Throws<IndexOutOfRangeException>(() => ll_kth_from_end.Program.LinkedListKthFromEnd(linkedList, 4));
        }
    }
}

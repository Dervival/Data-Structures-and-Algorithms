using System;
using Xunit;
using arrayBinarySearch;

namespace arrayBinarySearchTests
{
    public class UnitTest1
    {
        [Fact]
        public void BinarySearchCanFindElementInMiddle()
        {
            //arrange
            int[] testArray = new int[] { 4, 8, 16, 23, 42 };
            int target = 16;
            //act
            int testIndex = Program.BinarySearch(testArray, target);
            //assert
            Assert.Equal(2, testIndex);
        }
        [Fact]
        public void BinarySearchCanFindElementBeforeMiddle()
        {
            //arrange
            int[] testArray = new int[]{ 4, 8, 15, 16, 23, 42 };
            int target = 15;
            //act
            int testIndex = Program.BinarySearch(testArray, target);
            //assert
            Assert.Equal(2, testIndex);
        }
        [Fact]
        public void BinarySearchCanFindElementAfterMiddle()
        {
            //arrange
            int[] testArray = new int[] { 4, 8, 15, 16, 23, 42 };
            int target = 23;
            //act
            int testIndex = Program.BinarySearch(testArray, target);
            //assert
            Assert.Equal(4, testIndex);
        }
        [Fact]
        public void BinarySearchReturnsNegativeOneonFailure()
        {
            //arrange
            int[] testArray = new int[] { 11, 22, 33, 44, 55, 66, 77 };
            int target = 90;
            //act
            int testIndex = Program.BinarySearch(testArray, target);
            //assert
            Assert.Equal(-1, testIndex);
        }
        [Fact]
        public void BinarySearchReturnsNegativeOneWithEmptyArray()
        {
            //arrange
            int[] testArray = new int[] { };
            int target = 1;
            //act
            int testIndex = Program.BinarySearch(testArray, target);
            //assert
            Assert.Equal(-1, testIndex);
        }
    }
}

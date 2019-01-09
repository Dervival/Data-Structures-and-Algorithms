using System;
using Xunit;
using arrayShift;

namespace arrayShiftUnitTests
{
    public class UnitTest1
    {
        //[Fact]
        //public void PassesLinking()
        //{
        //    Assert.Equal(1, Program.TestLink());
        //}

        [Fact]
        public void PassesFirstExample()
        {
            //arrange
            int[] exampleArray = { 2, 4, 6, 8 };
            int exampleInt = 5;
            int[] expectedOutput = { 2, 4, 5, 6, 8 };
            //act
            int[] actualOutput = Program.InsertShiftArray(exampleArray, exampleInt);
            //assert
            Assert.Equal(expectedOutput, actualOutput);
        }

        [Fact]
        public void PassesSecondExample()
        {
            //arrange
            int[] exampleArray = { 4, 8, 15, 23, 42 };
            int exampleInt = 16;
            int[] expectedOutput = { 4, 8, 15, 16, 23, 42 };
            //act
            int[] actualOutput = Program.InsertShiftArray(exampleArray, exampleInt);
            //assert
            Assert.Equal(expectedOutput, actualOutput);
        }

        [Fact]
        public void AcceptsEmptyArray()
        {
            int[] emptyArray = { };
            int exampleInt = 42;
            int[] expectedOutput = { 42 };
            int[] actualOutput = Program.InsertShiftArray(emptyArray, exampleInt);
            //assert
            Assert.Equal(expectedOutput, actualOutput);
        }

        [Fact]
        public void DoesNotRequireSortedInput()
        {
            //arrange
            int[] exampleArray = { 8, 4, 0, 2 };
            int exampleInt = 5;
            int[] expectedOutput = { 8, 4, 5, 0, 2 };
            int[] expectedIfSort = { 0, 2, 4, 5, 8 };
            //act
            int[] actualOutput = Program.InsertShiftArray(exampleArray, exampleInt);
            //assert
            Assert.Equal(expectedOutput, actualOutput);
            Assert.NotEqual(expectedIfSort, actualOutput);
        }
    }
}

using System;
using Xunit;
using arrayShift;

namespace arrayShiftUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void PassesLinking()
        {
            Assert.Equal(1, Program.TestLink());
            //int [] exampleArray
        }

        [Fact]
        public void PassesFirstExample()
        {
            //arrange
            int[] exampleArray = { 2, 4, 6, 8 };
            int exampleInt = 5;
            int[] expectedOutput = { 2, 4, 5, 6, 8 };
            //act
            int[] actualOutput = InsertShiftArray(exampleArray, exampleInt);
            //assert
            Assert.Equal(expectedOutput, actualOutput);
        }
    }
}

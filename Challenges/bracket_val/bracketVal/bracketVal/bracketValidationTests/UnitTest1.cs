using System;
using Xunit;

namespace bracketValidationTests
{
    public class UnitTest1
    {
        [Fact]
        public void EmptyStringIsConsideredBalanced()
        {
            string emptyString = "";
            Assert.True(MultiBracketValidation(emptyString));
        }

        [Theory]
        [InlineData("()")]
        [InlineData("[]")]
        [InlineData("{}")]
        public void SinglePairOfBracketsIsBalanced(string testString)
        {
            Assert.True(MultiBracketValidation(testString));
        }

        [Theory]
        [InlineData("()[]")]
        [InlineData("[]{}")]
        [InlineData("{}[]()")]
        public void MultipleIsolatedPairsOfBracketsAreBalanced(string testString)
        {
            Assert.True(MultiBracketValidation(testString));
        }

        [Theory]
        [InlineData("((()))")]
        [InlineData("({[]})")]
        [InlineData("[({})]")]
        public void MultipleNestedPairsOfBracketsAreBalanced(string testString)
        {
            Assert.True(MultiBracketValidation(testString));
        }

        [Theory]
        [InlineData("{}")]
        [InlineData("{}(){}")]
        [InlineData("()[[Extra Characters]]")]
        [InlineData("(){}[[]]")]
        [InlineData("{}{Code}{Fellows}(())")]
        public void AllExampleTestsFromCanvasPass(string testString)
        {
            Assert.True(MultiBracketValidation(testString));
        }

        [Theory]
        [InlineData("(")]
        [InlineData("{")]
        [InlineData("[")]
        [InlineData(")")]
        [InlineData("}")]
        [InlineData("]")]
        public void SingleUnbalancedBracketDoesNotReturnTrue(string testString)
        {
            Assert.False(MultiBracketValidation(testString));
        }

        [Theory]
        [InlineData("([]")]
        [InlineData("{{}")]
        [InlineData("[()")]
        [InlineData("{})")]
        [InlineData("[]}")]
        [InlineData("[]{}]")]
        public void UnbalancedBracketsDoNotReturnTrue(string testString)
        {
            Assert.False(MultiBracketValidation(testString));
        }

        [Theory]
        [InlineData("[(])")]
        [InlineData("[({}])")]
        [InlineData("(({{[[))]]}}")]
        public void EntertwinedBracketPairsReturnFalse(string testString)
        {
            Assert.False(MultiBracketValidation(testString));
        }

        [Theory]
        [InlineData("[({}]")]
        [InlineData("(](")]
        [InlineData("{(})")]
        public void AllExampleTestsFromCanvasFail(string testString)
        {
            Assert.False(MultiBracketValidation(testString));
        }
    }
}

using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("tacocat", true)]
        [InlineData("level", true)]
        [InlineData("civic", true)]
        [InlineData("madam", true)]
        [InlineData("bacon", false)]
        [InlineData("alfredo", false)]
        [InlineData("flour", false)]
        public void Test1(string word, bool expected)
        {
            var test = new WordSmith();
            var actual = test.IsAPalindrome(word);
            Assert.Equal(expected, actual);
        }
    }
}

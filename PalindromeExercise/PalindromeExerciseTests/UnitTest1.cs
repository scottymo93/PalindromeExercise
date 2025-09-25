using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar",true)]
        [InlineData("truck",false)]
        [InlineData("hannah",true)]
        [InlineData("dadad",true)]
        public void IsPalindromeTest(string word, bool expected)
        {
        WordSmith ws = new WordSmith();
        bool result = ws.IsPalindrome(word);
        Assert.Equal(expected, result);
        }
    }
}

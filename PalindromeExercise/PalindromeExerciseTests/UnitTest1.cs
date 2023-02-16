using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hello", false)]

        public void MyTest(string word, bool expected)
        {
            //arrange
            var palindrometester = new WordSmith();

            //act

            var actual = palindrometester.IsAPalindrome(word);

            //assert

            Assert.Equal(expected, actual);
        }

        
    }
}

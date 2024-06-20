using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hello", false)]
        public void Test1(string word, bool expected)
        {
            //Arrange
            var ws = new WordSmith();
            //Act
            bool actual = ws.IsAPalindrome(word);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}

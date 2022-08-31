using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("tenet", true)]
        [InlineData(null, false)]
        [InlineData("otto", true)]
        [InlineData("Nate", false)]
        [InlineData("HOME", false)]
        [InlineData("nurserun", false)]
        [InlineData("civic", true)]
        [InlineData("evilolive", true)]
        [InlineData("homerun", false)]
        public void PlaindromeTest(string str, bool expected)
        {
            //Arrange
            var test = new WordSmith();
            //Act
            var actual = test.IsAPalindrome(str);
            //Assert
            Assert.Equal(expected, actual);
            
        }
        
    }
}

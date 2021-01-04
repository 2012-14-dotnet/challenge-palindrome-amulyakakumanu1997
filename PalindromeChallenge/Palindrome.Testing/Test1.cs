using System;
using Xunit;
using Palindrome.Domain;

namespace Palindrome.Test 
{
    public class Test1 
    {
        [Fact]
        public void Test1() 
        {
            string word = "racecar";
            bool result = Word.TestPalindrome(word);
            Assert.True(result);
        }
    }
}
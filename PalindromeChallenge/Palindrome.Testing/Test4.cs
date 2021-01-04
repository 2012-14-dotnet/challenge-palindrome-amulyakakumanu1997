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
            string Word = "racecar";
            bool result = Word.TestPalindromeRecursive(Word);
            Assert.False(result);
        }
    }
}
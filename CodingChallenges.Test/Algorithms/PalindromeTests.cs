using CodingChallenges.Algorithms;
using Xunit;

namespace CodingChallenges.Test.Algorithms;

public class PalindromeTests
{
    [Fact]
    public void Test()
    {
        var result = Palindrome.IsPalindrome1("racecar");
        Assert.True(result);
        result = Palindrome.IsPalindrome2("racecar");
        Assert.True(result);

        result = Palindrome.IsPalindrome1("notone");
        Assert.False(result);
        result = Palindrome.IsPalindrome2("notone");
        Assert.False(result);
    }
}
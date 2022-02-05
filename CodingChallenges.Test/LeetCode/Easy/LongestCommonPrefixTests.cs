using CodingChallenges.LeetCode.Easy;
using Xunit;

namespace CodingChallenges.Test.LeetCode.Easy;

public class LongestCommonPrefixTests
{
    private readonly LongestCommonPrefix _longestCommonPrefix;

    public LongestCommonPrefixTests()
    {
        _longestCommonPrefix = new LongestCommonPrefix();
    }

    [Fact]
    public void Test()
    {
        var result = _longestCommonPrefix.Solve(new[] {"ab", "a"});
        
        Assert.Equal("a", result);
    }
}
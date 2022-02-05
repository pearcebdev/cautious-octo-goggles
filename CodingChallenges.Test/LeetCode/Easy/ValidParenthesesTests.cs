using CodingChallenges.LeetCode.Easy;
using Xunit;

namespace CodingChallenges.Test.LeetCode.Easy;

public class ValidParenthesesTests
{
    private readonly ValidParentheses _validParentheses;
    public ValidParenthesesTests()
    {
        _validParentheses = new ValidParentheses();
    }

    [Fact]
    public void Test()
    {
        Assert.False(_validParentheses.IsValid("((([]})"));
        
        Assert.True(_validParentheses.IsValid("()"));
        Assert.True(_validParentheses.IsValid("()[]{}"));
        Assert.False(_validParentheses.IsValid("(]"));
        Assert.False(_validParentheses.IsValid("[])"));
    }
}
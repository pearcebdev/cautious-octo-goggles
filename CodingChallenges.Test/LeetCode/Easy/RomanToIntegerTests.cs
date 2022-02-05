using System;
using CodingChallenges.LeetCode.Easy;
using Xunit;

namespace CodingChallenges.Test.LeetCode.Easy;

public class RomanToIntegerTests
{
    private readonly RomanToInteger _romanToInteger;
    private readonly Random _random;

    public RomanToIntegerTests()
    {
        _romanToInteger = new RomanToInteger();
        _random = new Random();
    }

    [Fact]
    public void RomanToIntegerTest()
    {
        var result = _romanToInteger.Solve("LVIII");
        
        Assert.Equal(58, result);

        result = _romanToInteger.Solve("MCMXCIV");
        
        Assert.Equal(1994, result);

        result = _romanToInteger.SolveWithDictionary("LVIII");
        
        Assert.Equal(58, result);

        result = _romanToInteger.SolveWithDictionary("MCMXCIV");
        
        Assert.Equal(1994, result);
    }
}
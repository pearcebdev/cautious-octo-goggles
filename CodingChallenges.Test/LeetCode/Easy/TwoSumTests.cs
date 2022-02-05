using System;
using CodingChallenges.LeetCode.Easy;
using Xunit;

namespace CodingChallenges.Test.LeetCode.Easy;

public class TwoSumTests
{
    private readonly TwoSum _twoSum;
    public TwoSumTests()
    {
        _twoSum = new TwoSum();
    }
    
    [Fact]
    public void TwoSumTest()
    {
        var rand = new Random();
        for (var i = 0; i < 100; i++)
        {
            var arr = new int[rand.Next(2, (int)Math.Pow(10, 4))];
            var target = rand.Next((int) Math.Pow(-10, 9), (int) Math.Pow(10, 9));
            var a = rand.Next((int) Math.Pow(-10, 9), (int) Math.Pow(10, 9));
            var b = target - a;
            var aIndex = rand.Next(0, arr.Length - 1);
            arr[aIndex] = a;
            var bIndex = rand.Next(aIndex + 1, arr.Length);

            arr[bIndex] = b;

            var result = TwoSum.Solve(arr, target);
            Assert.Equal(new[] {aIndex, bIndex}, result);
            
            result = TwoSum.SolveWithDictionary(arr, target);
            Assert.Equal(new[] {aIndex, bIndex}, result);
        }
        
    }
}
using CodingChallenges.LeetCode.Easy;
using Xunit;

namespace CodingChallenges.Test.LeetCode.Easy;

public class RemoveDuplicatesTests
{

    [Fact]
    public void Test()
    {
        var result = RemoveDuplicatesFromSortedArray.RemoveDuplicates(new[] {0, 0, 1, 1, 1, 2, 2, 3, 3, 4});
        int[] asf = new int[] { };
        result = RemoveDuplicatesFromSortedArray.RemoveDuplicates(asf);
    }
}
namespace CodingChallenges.LeetCode.Easy;

public static class RemoveDuplicatesFromSortedArray
{
    public static int RemoveDuplicates(int[] nums)
    {
        var k = nums.Length > 0 ? 1 : 0;
        foreach (var num in nums)
        {
            if (num > nums[k - 1])
                nums[k++] = num;
        }
        return k;
    }
}
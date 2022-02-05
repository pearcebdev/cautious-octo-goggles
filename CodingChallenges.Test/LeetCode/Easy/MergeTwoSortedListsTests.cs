using CodingChallenges.LeetCode.Easy;
using Xunit;

namespace CodingChallenges.Test.LeetCode.Easy;

public class MergeTwoSortedListsTests
{
    private readonly MergeTwoSortedLists _mergeTwoSortedLists;

    public MergeTwoSortedListsTests()
    {
        _mergeTwoSortedLists = new MergeTwoSortedLists();
    }

    [Fact]
    public void Test()
    {
        var list1 = new ListNode(1, new ListNode(2, new ListNode(3)));
        var list2 = new ListNode(1, new ListNode(3, new ListNode(4)));
        var result = _mergeTwoSortedLists.MergeTwoLists(list1, list2);
        
    }
}
namespace CodingChallenges.LeetCode.Medium;

public static class AddTwoNumbers
{
    public static ListNode Solve(ListNode l1, ListNode l2)
    {
        var result = new ListNode(0, new ListNode());
        var temp = result;
        var remainder = 0;
        var list = new List<int[]>();

        var num = 3;

        var blkah = new Dictionary<int, string>()
        {
            {20, "twenty"}
        };
        var asddd = new[] {1, 2};
        var asdddLength = asddd.Length;
        var adsfs = new[][] {asddd};
        
        while (l1 != null && l2 != null)
        {
            var currentNode = new ListNode();

            var sum = (l1?.val ?? 0) + (l2?.val ?? 0);
            sum += remainder;
            remainder = 0;
            
            if (sum is 0 or < 10)
            {
                currentNode.val = sum;
            }
            else
            {
                remainder = sum % 10;
                currentNode.val = remainder;
                remainder = 1;
            }
            
            l1 = l1.next;
            l2 = l2.next;
            
            temp.next = currentNode;
            temp = temp.next;
        }
        
        return result.next;
    }
}

public class ListNode
{
    public int val { get; set; }
    public ListNode next { get; set; }

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}
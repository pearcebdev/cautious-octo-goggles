namespace CodingChallenges.LeetCode.Easy;

public class MergeTwoSortedLists
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        // Placeholder node to store results of merging as next
        var resultHead = new ListNode();
        var previous = resultHead;
        
        while (list1 != null && list2 != null)
        {
            if (list1.val <= list2.val)
            {
                // list1 value is less, capture list1 as next node in the list
                previous.next = list1;
                // Move list1 as equal to next node in line
                list1 = list1.next;
            }
            else
            {
                // list2 was lesser value, move this in front of list1
                previous.next = list2;
                list2 = list2.next;
            }

            previous = previous.next;
        }

        previous.next = list1 != null ? list1 : list2;
        return resultHead.next;
    }
}

public class ListNode
{
    public int val { get; set; }
    public ListNode? next { get; set; }

    public ListNode(int val = 0, ListNode? next = null)
    {
        val = val;
        next = next;
    }
}
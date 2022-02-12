// See https://aka.ms/new-console-template for more information

using CodingChallenges.Algorithms;
// using CodingChallenges.LeetCode.Easy;
using CodingChallenges.LeetCode.Medium;

Console.WriteLine("Hello, World!");
// Console.WriteLine(7 % 10);

var l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
var l2 = new ListNode(5, new ListNode(6, new ListNode(4)));

var result = AddTwoNumbers.Solve(l1, l2);

while (result != null)
{
    Console.WriteLine(result.val);
    result = result.next;
}
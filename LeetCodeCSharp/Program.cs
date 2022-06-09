using System;
using LeetCode;
using static LeetCodeCSharp.Solution;

namespace LeetCodeCSharp
{
    class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(3, null)));
            ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4, null)));

            var result = solution.AddTwoNumbers(l1, l2);
            

        }
    }
}

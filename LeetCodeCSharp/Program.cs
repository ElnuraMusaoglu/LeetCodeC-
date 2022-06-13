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
            ListNode l1 = new ListNode(1, new ListNode(2, new ListNode(2, null)));
            //ListNode l2 = new ListNode(1, new ListNode(3, new ListNode(4, null)));
            //ListNode l1 = new ListNode(2, null);
            ListNode l2 = new ListNode(1, null);

            var result = solution.IsValid("([{}])");
            

        }
    }
}

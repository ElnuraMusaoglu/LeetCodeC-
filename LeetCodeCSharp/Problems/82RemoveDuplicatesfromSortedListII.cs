using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeCSharp
{
    public partial class Solution
    {
        public ListNode DeleteDuplicates2(ListNode head)
        {
            if (head == null) return head;

            ListNode p = head;
            HashSet<int> visitedMore = new HashSet<int>();
            HashSet<int> visited = new HashSet<int>();

            while (p != null)
            {
                if (visited.Contains(p.val)) visitedMore.Add(p.val);
                if (!visited.Contains(p.val)) visited.Add(p.val);

                p = p.next;
            }

            ListNode result = new ListNode(0, null);
            ListNode current = result;

            foreach (int val in visited)
            {
                if (!visitedMore.Contains(val))
                {
                    current.next = new ListNode(val, null);
                    current = current.next;
                }
            }

            return result.next;
        }
    }
}

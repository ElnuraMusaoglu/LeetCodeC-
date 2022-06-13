using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeCSharp
{
    public partial class Solution
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null) return null;

            ListNode current = head;
            Dictionary<int, ListNode> nonDuplicates = new Dictionary<int, ListNode>();

            while (current != null)
            {
                if(!nonDuplicates.ContainsKey(current.val)) nonDuplicates.Add(current.val, new ListNode(current.val, null));
                current = current.next;
            }

            ListNode result = new ListNode(0, null);
            ListNode temp = result;

            foreach (int key in nonDuplicates.Keys)
            {
                temp.next = nonDuplicates[key];
                temp = temp.next;
            }

            return result.next;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeCSharp
{
    public partial class Solution
    {
        public class ListNode
        {
            public int val;
            public ListNode next;

            public ListNode(int val, ListNode next)
            {
                this.val = val;
                this.next = next;
            }
        }
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode result = new ListNode(0, null);
            int carry = 0;
            ListNode p = l1, q = l2, current = result;
            while (p != null || q != null)
            {
                int i1 = p != null ? p.val : 0;
                int i2 = q != null ? q.val : 0;
                int sum = carry + i1 + i2;

                carry = sum / 10;
                current.next = new ListNode(sum % 10, null);

                current = current.next;
                if (p != null) p = p.next;
                if (q != null) q = q.next;
            }
            current.next = null;
            if (carry > 0) current.next = new ListNode(carry, null);

            return result.next;
        }
    }
}

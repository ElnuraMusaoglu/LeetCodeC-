using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeCSharp
{
    public partial class Solution
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if(list1==null) return list2;
            if(list2==null) return list1;

            ListNode result = new ListNode(-1000, null);
            ListNode p = list1, q = list2, current = result;

            while (p != null || q != null)
            {
                int val1 = p != null ? p.val : 1000;
                int val2 = q != null ? q.val : 1000;

                if (p != null && val1 <= val2)
                {
                    current.next = new ListNode(val1, null);
                    current = current.next;
                    p = p != null ? p.next : null;
                }
                if (q != null && val2 <= val1)
                {
                    current.next = new ListNode(val2, null);
                    current = current.next;
                    q = q != null ? q.next : null;
                }
            }

            return result.next;
        }
    }
}

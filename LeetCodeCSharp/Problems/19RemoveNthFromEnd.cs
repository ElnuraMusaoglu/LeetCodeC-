using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeCSharp
{
    public partial class Solution
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            int length = 0;
            ListNode current = head;

            while (current != null)
            {
                length++;
                current = current.next;
            }

            if (n > 0 && length == 1) return null;
            if (length == n) return head.next;

            current = head;
            for (int i = 0; i < length; i++)
            {
                if (i == length - n - 1)
                {
                    current.next = current.next.next;
                    current = current.next;
                    break;
                }

                current = current.next;
            }
            return head;
        }
    }
}

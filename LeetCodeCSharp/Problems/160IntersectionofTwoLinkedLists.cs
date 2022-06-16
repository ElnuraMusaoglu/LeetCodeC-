using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeCSharp
{
    public partial class Solution
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            ListNode a = headA, b = headB;
            HashSet<ListNode> nodeDic = new HashSet<ListNode>();

            while (a != null)
            {
                if(!nodeDic.Contains(a)) nodeDic.Add(a);
                a = a.next;
            }
            while (b != null)
            {
                if (nodeDic.Contains(b)) return b;
                b = b.next;
            }

            return null;
        }
    }
}

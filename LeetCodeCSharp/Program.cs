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
            TreeNode l1 = new TreeNode(3);
            
            l1.right = new TreeNode(20);
            
            l1.right.right = new TreeNode(7);
            
            l1.right.right.right = new TreeNode(7);
            l1.right.right.right.right = new TreeNode(7);

            TreeNode l2 = new TreeNode(4);
            l2.left = new TreeNode(2);
            l2.right = new TreeNode(6);
            l2.left.left = new TreeNode(1);
            l2.left.right = new TreeNode(2);
            //ListNode l2 = new ListNode(1, new ListNode(3, new ListNode(4, null)));
            //ListNode l1 = new ListNode(2, null);
            //ListNode l2 = new ListNode(1, null);
            // 4,2,7,1,3,6,9

            var result = solution.Convert("PAYPALISHIRING", 4);
            

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeCSharp
{
    public partial class Solution
    {
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null) return true;

            return IsSymmetricUtil(root.left, root.right);
        }

        private bool IsSymmetricUtil(TreeNode left, TreeNode right)
        {

            if (left == null && right == null) return true;
            if (left != null && right != null && left.val == right.val)
                return IsSymmetricUtil(left.left, right.right) && IsSymmetricUtil(left.right, right.left);

            return false;
        }
    }
}

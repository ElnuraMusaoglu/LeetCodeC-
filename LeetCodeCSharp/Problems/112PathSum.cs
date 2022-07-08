using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeCSharp
{
    public partial class Solution
    {
        public bool HasPathSum(TreeNode root, int targetSum)
        {
            if (root == null) return false;
            return has(root, 0, targetSum);
        }

        public bool has(TreeNode root, int cur, int target)
        {
            if (root.left == null && root.right == null)
            {
                return target == cur + root.val;
            }
            cur += root.val;

            bool res = false;
            if (root.left != null)
            {
                res = has(root.left, cur, target);
            }
            if (res) return true;

            if (root.right != null)
            {
                res = has(root.right, cur, target);
            }

            return res;

        }
    }
}

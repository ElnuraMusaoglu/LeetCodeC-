using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeCSharp
{
    public partial class Solution
    {
        public int MinDepth(TreeNode root)
        {
            if (root == null) return 0;
            if (root.right == null && root.left == null) return 1;

            return MinDepthRec(root, 1);
        }

        private int MinDepthRec(TreeNode root, int d)
        {
            if(root == null) return d;

            if (root != null && root.right == null && root.left == null) return d;
            if(root.left == null) return MinDepthRec(root.right, d + 1);
            if(root.right == null) return MinDepthRec(root.left, d + 1);

            return Math.Min(MinDepthRec(root.left, d + 1), MinDepthRec(root.right, d + 1));
        }
    }
}

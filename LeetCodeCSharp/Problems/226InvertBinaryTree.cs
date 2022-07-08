using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeCSharp
{
    public partial class Solution
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null) return root;

            TreeNode temp = root.right;
            root.right = root.left;
            root.left = temp;
            InvertTree(root.left);
            InvertTree(root.right);

            return root;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeCSharp
{
    public partial class Solution
    {
        public IList<int> RightSideView(TreeNode root) // Wrong
        {
            IList<int> result = new List<int>();
            if (root == null) return result;
            result.Add(root.val);
            TreeNode current = root.right;

            while (current != null)
            {
                result.Add(current.val);
                current = current.right;
            }

            return result;
        }
    }
}

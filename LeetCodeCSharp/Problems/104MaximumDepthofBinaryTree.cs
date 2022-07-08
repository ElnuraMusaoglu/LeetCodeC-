using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeCSharp
{
    public partial class Solution
    {
        public int MaxDepth(TreeNode root)
        {
            if(root ==null) return 0;

            return (1+Math.Max(MaxDepth(root.right), MaxDepth(root.left)));

        }
    }
}

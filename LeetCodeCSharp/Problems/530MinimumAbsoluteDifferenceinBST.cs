using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeCSharp
{
    public partial class Solution
    {
        public int GetMinimumDifference(TreeNode root)
        {
            List<int> nums = new List<int>();
            inorder(root, nums);
            int min = Int32.MaxValue;

            for (int i = 0; i < nums.Count - 1; i++)
            {
                int cand = Math.Abs(nums[i + 1] - nums[i]);
                min = Math.Min(min, cand);
            }

            return min;
        }
        private void inorder(TreeNode node, List<int> nums)
        {
            if (node == null)
            {
                return;
            }
            inorder(node.left, nums);
            nums.Add(node.val);
            inorder(node.right, nums);
        }
    }
}

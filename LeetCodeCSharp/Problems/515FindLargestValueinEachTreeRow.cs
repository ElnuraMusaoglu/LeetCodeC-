using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeCSharp
{
    public partial class Solution
    {
        public IList<int> LargestValues(TreeNode root)
        {
            List<int> result = new List<int>();
            if (root == null) return result;

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                int size = queue.Count;
                int maxValue = Int32.MinValue;

                for (int i = 0; i < size; i++)
                {
                    TreeNode current = queue.Dequeue();
                    maxValue = current.val > maxValue ? current.val : maxValue;
                    if (current.left != null) queue.Enqueue(current.left);
                    if (current.right != null) queue.Enqueue(current.right);
                }

                result.Add(maxValue);
            }

            return result;
        }
    }
}

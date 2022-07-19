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

            Queue<TreeNode> queue = new Queue<TreeNode>();
            Queue<int> treeLevel = new Queue<int>();
            queue.Enqueue(root);
            treeLevel.Enqueue(1);

            while (queue.Count > 0)
            {
                TreeNode currentNode = queue.Dequeue();
                int currentLevel = treeLevel.Dequeue();

                if (treeLevel.Count == 0 || treeLevel.Peek() != currentLevel)
                {
                    result.Add(currentNode.val);
                }
                if (currentNode.left != null)
                {
                    queue.Enqueue(currentNode.left);
                    treeLevel.Enqueue(currentLevel + 1);
                }
                if (currentNode.right != null)
                {
                    queue.Enqueue(currentNode.right);
                    treeLevel.Enqueue(currentLevel + 1);
                }
            }

            return result;
        }
    }
}

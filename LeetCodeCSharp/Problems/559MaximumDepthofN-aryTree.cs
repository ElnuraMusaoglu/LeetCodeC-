using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeCSharp
{
    public partial class Solution
    {
        public class Node
        {
            public int val;
            public IList<Node> children;

            public Node() { }

            public Node(int _val)
            {
                val = _val;
            }

            public Node(int _val, IList<Node> _children)
            {
                val = _val;
                children = _children;
            }
        }
        public int MaxDepth(Node root)
        {
            if (root == null) return 0;

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);
            int currentLevel = 0;

            while (queue.Count > 0)
            {
                int queueSize = queue.Count;

                for (int i = 0; i < queueSize; i++)
                {
                    Node currentNode = queue.Dequeue();
                    int size = currentNode.children != null ? currentNode.children.Count : 0;

                    for (int k = 0; k < size; k++)
                    {
                        queue.Enqueue(currentNode.children[k]);
                    }
                }
                currentLevel++;
            }

            return currentLevel;
        }
    }
}

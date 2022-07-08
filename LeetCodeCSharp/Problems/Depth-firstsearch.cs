using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeCSharp
{
    public partial class Solution
    {
        // DFS uses stack as a base.

        public void DFS(TreeNode root)
        {

        }

        public class Graph
        {
            public int V;

            public LinkedList<int>[] adj;
            
            public Graph(int V)
            {
                this.V = V;
                adj = new LinkedList<int>[V];

                for (int i = 0; i < adj.Length; i++)
                    adj[i] = new LinkedList<int>();

            }

            public void addEdge(int v, int w)
            {
                adj[v].AddLast(w);
            }

            public List<int> DFS(int s)
            {
                List<int> result = new List<int>();
                Boolean[] visited = new Boolean[V];
                Stack<int> stack = new Stack<int>();

                stack.Push(s);

                while (stack.Count > 0)
                {
                    s = stack.Peek();
                    stack.Pop();

                    if (!visited[s])
                    {
                        result.Add(s);
                        visited[s] = true;
                    }

                    foreach (int v in adj[s])
                    {
                        if (!visited[v])
                            stack.Push(v);
                    }
                }

                return result;
            }
        }
    }
}

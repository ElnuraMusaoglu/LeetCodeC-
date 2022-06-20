using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeCSharp
{
    public partial class Solution
    {
        public string RemoveDuplicates(string s)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in s)
            {
                if (stack.Count > 0)
                {
                    if (stack.Peek().Equals(c)) stack.Pop();
                    else stack.Push(c);
                }
                else stack.Push(c);
            }

            char[] result = new char[stack.Count];
            
            for (int i = 0; i < result.Length; i++)
            {
                char c = stack.Pop();
                result[result.Length - 1 - i] = c;
            }

            return new string(result);
        }
    }
}

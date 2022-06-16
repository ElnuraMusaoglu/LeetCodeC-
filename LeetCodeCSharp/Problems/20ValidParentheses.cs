using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeCSharp
{
    public partial class Solution
    {
        public bool IsValid(string s)
        {
            HashSet<char> validChars = new HashSet<char>() { '(', ')', '[', ']', '{', '}' };
            Dictionary<char, char> charsDic = new Dictionary<char, char>() { { '(', ')' }, { '[', ']' } , { '{', '}' } };
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (!validChars.Contains(s[i])) return false;

                if (stack.Count > 0)
                {
                    char last = stack.Pop();

                    if (charsDic.ContainsKey(last))
                    {
                        char pair = charsDic[last];

                        if (pair == s[i]) continue;
                        else 
                        {
                            stack.Push(last);
                            stack.Push(s[i]);
                        }
                    }
                    else stack.Push(last);
                }
                else stack.Push(s[i]);
            }

            if (stack.Count == 0) return true;
            return false;
        }
    }
}

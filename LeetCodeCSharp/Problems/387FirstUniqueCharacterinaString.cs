using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeCSharp
{
    public partial class Solution
    {
        public int FirstUniqChar(string s)
        {
            Dictionary<char, int> seen = new Dictionary<char, int>();
            bool[] uniq = new bool[s.Length];

            for (int i = 0; i < s.Length; i++)
            {
                if (seen.ContainsKey(s[i]))
                {
                    uniq[i] = false;
                    uniq[seen[s[i]]] = false;
                }
                else
                {
                    seen.Add(s[i], i);
                    uniq[i] = true;
                }
            }

            for (int i = 0; i < uniq.Length; i++)
            {
                if (uniq[i]) return i;
            }

            return -1;
        }
    }
}

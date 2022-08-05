using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeCSharp
{
    public partial class Solution
    {
        public string Convert(string s, int numRows)
        {
            if (s == null) return "";
            if (numRows == 0) return s;

            int step = numRows * 2 - 2;
            char[] result = new char[s.Length];
            int charIndex = 0;

            for (int i = 0; i < numRows; i++)
            {
                for (int j = i; j < s.Length; j = j + step)
                {
                    result[charIndex] = s[j]; charIndex++;
                    if (i != 0 && i != numRows - 1 && (j + step - 2 * i) < s.Length)
                    {
                        result[charIndex] = s[j + step - 2 * i]; charIndex++;
                    }
                }
            }

            return new string(result);
        }
    }
}

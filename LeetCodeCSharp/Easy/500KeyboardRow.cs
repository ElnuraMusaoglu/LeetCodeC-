using System;
using System.Collections.Generic;

namespace LeetCode
{
    public partial class Solution
    {
        public string[] FindWords(string[] words)
        {
            if (words.Length < 1 || words.Length > 20)
            {
                return new string[0];
            }

            char[] alphabet1 = new char[] { 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p' };
            char[] alphabet2 = new char[] { 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l' };
            char[] alphabet3 = new char[] { 'z', 'x', 'c', 'v', 'b', 'n', 'm' };

            Dictionary<char, int> alp = new Dictionary<char, int>();

            foreach (char c in alphabet1) alp.Add(c, 1);
            foreach (char c in alphabet2) alp.Add(c, 2);
            foreach (char c in alphabet3) alp.Add(c, 3);

            List<string> result = new List<string>();

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length < 1 || words[i].Length > 100)
                {
                    break;
                }

                bool in_same_alp = true;
                string word = words[i].ToLower();
                int first = alp[word[0]];

                for (int j = 1; j < word.Length; j++)
                {
                    if (alp[word[j]] != first)
                    {
                        in_same_alp = false;
                        break;
                    }
                }

                if (in_same_alp)
                {
                    result.Add(words[i]);
                    Console.WriteLine(words[i]);
                }
            }

            return result.ToArray();
        }
    }
}
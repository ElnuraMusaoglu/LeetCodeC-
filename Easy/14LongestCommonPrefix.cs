using System;

namespace LeetCode
{
    public class Program
    {
        public static void Main()
        {
            string[] list = { "leetcode", "leetd", "leed","leeds" };
            Console.WriteLine(LongestCommonPrefix(list).ToString());
        }

        public static String LongestCommonPrefix(String[] strs)
        {
            if (strs == null || strs.Length == 0) return "";
            if (strs.Length == 1) return strs[0];
            int minLen = Int32.MaxValue;
            foreach (String str in strs)
                minLen = Math.Min(minLen, str.Length);
            int low = 1;
            int high = minLen;
            while (low <= high)
            {
                int middle = (low + high) / 2;
                if (isCommonPrefix(strs, middle))
                    low = middle + 1;
                else
                    high = middle - 1;
            }
            return strs[0].Substring(0, (low + high) / 2);
        }

        private static bool isCommonPrefix(String[] strs, int len)
        {
            String str1 = strs[0].Substring(0, len);
            for (int i = 1; i < strs.Length; i++)
                if (!strs[i].StartsWith(str1))
                    return false;
            return true;
        }
    }
}
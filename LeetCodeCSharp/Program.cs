using System;
using LeetCode;

namespace LeetCodeCSharp
{
    class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            int[] list = {3,3};
            int[] result = solution.TwoSum(list, 6);
            Console.WriteLine(result[0]);
            Console.WriteLine(result[1]);

        }
    }
}

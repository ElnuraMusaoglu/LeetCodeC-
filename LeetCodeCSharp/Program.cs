using System;
using LeetCode;

namespace LeetCodeCSharp
{
    class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();
            string[] list = {"Hello","Alaska","Dad","Peace"};
            Console.WriteLine(solution.FindWords(list).ToString());
        }
    }
}

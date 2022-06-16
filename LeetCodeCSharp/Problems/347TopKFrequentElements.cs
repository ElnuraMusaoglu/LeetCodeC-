using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodeCSharp
{
    public partial class Solution
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            if (nums == null || nums.Length < 2) return nums;

            Dictionary<int, int> numCount = new Dictionary<int, int>();
            foreach (int num in nums)
            {
                if (numCount.ContainsKey(num)) numCount[num] = numCount[num] + 1;
                else numCount.Add(num, 1);
            }

            int[] result = numCount.OrderByDescending(x => x.Value).Select(item => item.Key).Take(k).ToArray();

            return result;
        }
    }
}

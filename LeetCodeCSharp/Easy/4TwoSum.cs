using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public partial class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            if (nums.Length < 2 || nums.Length > 10000)
            {
                return new int[0];
            }

            if (target < -1000000000 || target > 1000000000)
            {
                return new int[0];
            }

            Dictionary<int, int> nums_dic = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!nums_dic.ContainsKey(i) && (nums[i] >= -1000000000 && nums[i] <= 1000000000))
                    nums_dic.Add(i, nums[i]);
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums_dic.ContainsKey(i))
                {
                    int diff = target - nums[i];
                    if (nums_dic.ContainsValue(diff))
                    {
                        int key2 = nums_dic.FirstOrDefault(x => x.Value == diff).Key;
                        if (i != key2)
                        {
                            if (i > key2)
                            {
                                return new int[] { key2, i };
                            }
                            return new int[] { i, key2 };
                        }
                    }
                }
            }

            return new int[0];
        }
    }
}
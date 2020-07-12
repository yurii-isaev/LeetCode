using System;
using System.Collections.Generic;

namespace Leetcode.TwoSum
{
    public static class Solution
    {
        /*
         1. Two Sum (https://leetcode.com/problems/two-sum/):
         
         Description:
         Given an array of integers nums and an integer target,
         return indices of the two numbers such that they add up to target.
         You may assume that each input would have exactly one solution,
         and you may not use the same element twice.
         You can return the answer in any order.
         
         Example:
         Input: nums = [2,7,11,15], target = 9
         Output: [0,1]
         Output: Because nums[0] + nums[1] == 9, we return [0, 1].
         */

        // ---------------------------------------------------------------------- //

        // Time complexity: O(n). 
        // Space complexity: O(1).
        // Data input: x ->     performance: 50 ns;  memory: 32 B.
        // Data input: x * 2 -> performance: 90 ns;  memory: 32 B.
        // Data input: x * 3 -> performance: 460 ns; memory: 32 B. = n^2
        public static int[] GetTwoSum(int[] nums, int target)
        {
            for (var i = 0; i < nums.Length; i++)
            {
                for (var j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new[] {i, j};
                    }
                }
            }

            return Array.Empty<int>();
        }

        // Time complexity: O(n). 
        // Space complexity: O(n).
        // Data input: x ->     performance: 250 ns; memory: 376 B.
        // Data input: x * 2 -> performance: 270 ns; memory: 616 B. 
        // Data input: x * 3 -> performance: 700 ns; memory: 896 B.
        public static int[] GetTwoSumByDictionary(int[] nums, int target)
        {
            var dict = new Dictionary<int, int>(nums.Length);

            for (var i = 0; i < nums.Length; dict[nums[i]] = i++)
            {
                if (dict.ContainsKey(target - nums[i]))
                {
                    return new[]
                    {
                        dict[target - nums[i]], i
                    };
                }

                // if (!map.ContainsKey(nums[i])) map.Add(nums[i], i);
                //dict[nums[i]] = i;
            }

            return Array.Empty<int>();
        }
    }
}

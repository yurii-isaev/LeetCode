using System;
using System.Collections.Generic;
using System.Linq;

namespace Leetcode.LongestHarmoniousSubsequence
{
    public static class Solution
    {
        /*
         594. Longest Harmonious Subsequence (https://leetcode.com/problems/longest-harmonious-subsequence/):
         
         Description:
         We define a harmonious array as an array
         where the difference between its maximum value and its minimum value is exactly 1.
         
         Given an integer array nums, return the length of its longest harmonious subsequence
         among all its possible subsequences.
        
         A subsequence of array is a sequence that can be derived from ray by deleting some or
         no elements without changing the order of the remaining elements.
        
         Example 1:
         Input: nums = [1,3,2,2,5,2,3,7]
         Output: 5
         Explanation: The longest harmonious subsequence is [3,2,2,2,3].
        
         Example 2:
         Input: nums = [1,2,3,4]
         Output: 2
        
         Example 3:
         Input: nums = [1,1,1,1]
         Output: 0
         */

        // ---------------------------------------------------------------------- //

        // Time complexity:  O(n). 
        // Space complexity: O(n).
        // Data input: x ->     performance: 0.6 us; memory: 400 B.
        // Data input: x * 2 -> performance: 1.1 us; memory: 400 B.
        // Data input: x * 4 -> performance: 2.1 us; memory: 768 B.
        // Data input: x * 8 -> performance: 3.2 us; memory: 792 B.
        public static int FindLhs1(int[] nums)
        {
            var maxCount = 0;
            var dict = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i])) dict[nums[i]]++;
                else dict.Add(nums[i], 1);
            }

            foreach (var key in dict.Keys)
            {
                var count = 0;
                if (dict.ContainsKey(key + 1))
                {
                    count = dict[key] + dict[key + 1];
                }

                maxCount = Math.Max(maxCount, count);
            }

            return maxCount;
        }

        // Time complexity:  O(n). 
        // Space complexity: O(n).
        // Data input: x ->     performance: 0.7 us; memory: 376 B.
        // Data input: x * 2 -> performance: 1.2 us; memory: 376 B.
        // Data input: x * 4 -> performance: 2.1 us; memory: 768 B.
        // Data input: x * 8 -> performance: 3.2 us; memory: 768 B.
        public static int FindLhs2(int[] nums)
        {
            var dict = new Dictionary<int, int>();
            var ans = 0;
            foreach (var num in nums)
            {
                dict[num] = dict.ContainsKey(num) ? dict[num] + 1 : 1;
            }

            foreach (KeyValuePair<int, int> kv in dict)
            {
                if (dict.ContainsKey(kv.Key - 1))
                {
                    ans = Math.Max(ans, kv.Value + dict[kv.Key - 1]);
                }
            }

            return ans;
        }

        // Time complexity:  O(n). 
        // Space complexity: O(n).
        // Data input: x ->     performance: 0.8 us; memory: 376 B.
        // Data input: x * 2 -> performance: 1.5 us; memory: 376 B.
        // Data input: x * 4 -> performance: 3.5 us; memory: 768 B.
        // Data input: x * 8 -> performance: 7.3 us; memory: 768 B.
        public static int FindLhs3(int[] nums)
        {
            var dict = new Dictionary<int, int>();
            var maxLen = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i])) dict[nums[i]]++;
                else dict.Add(nums[i], 1);

                maxLen = Math.Max(maxLen, Math.Max(dict.ContainsKey(nums[i] + 1)
                    ? dict[nums[i] + 1] + dict[nums[i]]
                    : 0, dict.ContainsKey(nums[i] - 1)
                    ? dict[nums[i] - 1] + dict[nums[i]]
                    : 0));
            }

            return maxLen;
        }

        // Time complexity:  O(n). 
        // Space complexity: O(n).
        // Data input: x ->     performance: 1.4 us; memory: 1008 B.
        // Data input: x * 2 -> performance: 2.6 us; memory: 1344 B.
        // Data input: x * 4 -> performance: 5 us;   memory: 2240 B.
        // Data input: x * 8 -> performance: 7.8 us; memory: 2632 B.
        public static int FindLhs4(int[] nums)
        {
            var counter = nums.GroupBy(n => n).ToDictionary(g => g.Key, g => g.Count());
            var res = 0;

            foreach (var num in nums)
            {
                if (counter.ContainsKey(num + 1))
                {
                    res = Math.Max(res, counter[num] + counter[num + 1]);
                }
            }

            return res;
        }
    }
}

using System.Collections.Generic;

namespace Leetcode.MissingRanges
{
    public static class Solution
    {
        /*
         163. Missing Ranges (https://leetcode.com/problems/missing-ranges/):
         
         Description:
         Given a sorted integer array nums,
         where the range of elements are in the inclusive range [lower, upper],
         return its missing ranges.
         
         Example: 
         Input: nums = [0, 1, 3, 50, 75], lower = 0 and upper = 99.
         Output: ["2", "4->49", "51->74", "76->99"].
         */

        // ---------------------------------------------------------------------- //

        // Time complexity:  O(n). 
        // Space complexity: O(n).
        // Data input: x ->     performance: 370 ns; memory: 408 B.
        // Data input: x * 2 -> performance: 800 ns; memory: 856 B.
        public static List<string> FindMissingRanges(int[] nums, int lower, int upper)
        {
            var ranges = new List<string>();
            var len = nums.Length;

            if (len == 0)
            {
                if (lower <= upper)
                    ranges.Add(GetRange(lower, upper));

                return ranges;
            }

            if (lower < nums[0])
                ranges.Add(GetRange(lower, nums[0] - 1));

            for (var i = 1; i < len; i++)
            {
                if (nums[i] > nums[i - 1] && nums[i - 1] != nums[i] - 1)
                    ranges.Add(GetRange(nums[i - 1] + 1, nums[i] - 1));
            }

            if (upper > nums[len - 1])
                ranges.Add(GetRange(nums[len - 1] + 1, upper));

            return ranges;
        }

        private static string GetRange(int lower, int upper)
        {
            if (lower == upper) return lower + "";
            return lower + "->" + upper;
        }

        // Time complexity:  O(n). 
        // Space complexity: O(n).
        // Data input: x ->     performance: 370 ns; memory: 360 B.
        // Data input: x * 2 -> performance: 800 ns; memory: 792 B.
        public static List<string> FindMissingRangesByFun(int[] nums, int lower, int upper)
        {
            if (nums == null) return new List<string>();

            static string Range(int lower, int upper) => lower == upper
                ? lower.ToString()
                : lower + "->" + upper;

            var result = new List<string>();
            var next = lower;

            foreach (var num in nums)
            {
                if (lower == int.MaxValue) return result;
                if (num < next) continue;
                if (num == next)
                {
                    next++;
                    continue;
                }

                result.Add(Range(next, num - 1));
                if (num == int.MaxValue) return result;
                next = num + 1;
            }

            if (next <= upper) result.Add(Range(next, upper));

            return result;
        }
    }
}

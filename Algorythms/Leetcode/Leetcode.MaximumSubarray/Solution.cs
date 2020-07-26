using System;

namespace Leetcode.MaximumSubarray
{
    public static class Solution
    {
        /*
         53. Maximum Subarray (https://leetcode.com/problems/maximum-subarray/):
         
         Description:
         Given an integer array nums, find the contiguous subarray (containing at least one number)
         which has the largest sum and return its sum.
         A subarray is a contiguous part of an array.
         
         Example:
         Input: nums = [-2,1,-3,4,-1,2,1,-5,4]
         Output: 6
         Explanation: [4,-1,2,1] has the largest sum = 6.
         */

        // ---------------------------------------------------------------------- //

        // Time complexity:  O(n). 
        // Space complexity: O(1).
        // Data input: x ->     performance: 20 ns; memory: _ B.
        // Data input: x * 2 -> performance: 40 ns; memory: _ B.
        // Data input: x * 4 -> performance: 60 ns; memory: _ B.
        public static int FindMaxSubArrayByForEach(int[] nums)
        {
            if (nums == null || nums.Length == 0) return 0;
            if (nums.Length == 1) return nums[0];
            var curSum = 0;
            var maxSum = nums[0];

            foreach (var num in nums)
            {
                curSum += num;
                if (num > curSum) curSum = num;
                if (curSum > maxSum) maxSum = curSum;
            }

            return maxSum;
        }

        // Time complexity:  O(n). 
        // Space complexity: O(1).
        // Data input: x ->     performance: 20 ns; memory: _ B.
        // Data input: x * 2 -> performance: 40 ns; memory: _ B.
        // Data input: x * 4 -> performance: 80 ns; memory: _ B.
        public static int FindMaxSubArray(int[] nums)
        {
            if (nums == null || nums.Length == 0) return 0;
            if (nums.Length == 1) return nums[0];
            var max = nums[0];
            var sum = -1;

            foreach (var num in nums)
            {
                sum = sum < 0 ? num : sum + num;
                max = Math.Max(max, sum);
            }

            return max;
        }

        // Time complexity:  O(n). 
        // Space complexity: O(1).
        // Data input: x ->     performance: 20 ns; memory: _ B.
        // Data input: x * 2 -> performance: 50 ns; memory: _ B.
        // Data input: x * 4 -> performance: 90 ns; memory: _ B.
        public static int FindMaxSubArrayByFor(int[] nums)
        {
            if (nums == null || nums.Length == 0) return 0;
            if (nums.Length == 1) return nums[0];
            var cur = nums[0];
            var max = nums[0];

            for (var i = 1; i < nums.Length; i++)
            {
                cur = Math.Max(nums[i], cur + nums[i]);
                max = Math.Max(max, cur);
            }

            return max;
        }
    }
}

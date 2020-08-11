using System;
using System.Linq;

namespace Leetcode.SingleNumber
{
    public static class Solution
    {
        /*
         136. Single Number (https://leetcode.com/problems/single-number/):
         
         Description:
         Given a non-empty array of integers nums, every element appears twice except for one.
         Find that single one.
         You must implement a solution with a linear runtime complexity and use only constant extra space.
         
         Example:
         Input: nums = [4,1,2,1,2].
         Output: 4.
         */

        // ---------------------------------------------------------------------- //

        // Time complexity:  O(n). 
        // Space complexity: O(1).
        // Data input: x ->     performance: 10 ns; memory: _ B.
        // Data input: x * 2 -> performance: 20 ns; memory: _ B. 
        public static int SingleNumberByBitwise(int[] nums)
        {
            var res = 0;
            if (nums == null || nums.Length == 0) return res;
            foreach (var num in nums) res ^= num;
            return res;
        }

        // Time complexity:  O(n).  
        // Space complexity: O(1).
        // Data input: x ->     performance: 70 ns;  memory: _ B.
        // Data input: x * 2 -> performance: 120 ns; memory: _ B.
        public static int SingleNumber(int[] nums)
        {
            if (nums == null || nums.Length == 0) return 0;
            if (nums.Length == 1) return nums[0];
            Array.Sort(nums);

            for (var i = 1; i < nums.Length - 1;)
            {
                if (nums[i] == nums[i - 1])
                {
                    i += 2;
                    if (i >= nums.Length) return nums[i - 1];
                }
                else
                {
                    return nums[i - 1];
                }
            }

            return 0;
        }

        // Time complexity:  O(n). 
        // Space complexity: O(1).
        // Data input: x ->     performance: 110 ns; memory: 32 B.
        // Data input: x * 2 -> performance: 190 ns; memory: 32 B.
        public static int SingleNumberByLinq(int[] nums)
        {
            if (nums == null || nums.Length == 0) return 0;
            return nums.Aggregate(0, (res, num) => res ^ num);
        }
    }
}

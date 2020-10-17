using System;
using System.Collections.Generic;
using System.Linq;

namespace Leetcode.ArrayPartition
{
    public static class Solution
    {
        /*
         561. Array Partition (https://leetcode.com/problems/array-partition/):
         
         Description:
         Given an integer array nums of 2n integers, group these integers into n pairs
         (a1, b1), (a2, b2), ..., (an, bn) such that the sum of min(ai, bi) for all i is maximized.
         Return the maximized sum.
         
         Input: nums = [1,4,3,2]
         Output: 4
         
         ---------------------------------
         Explanation:
         All possible pairings (ignoring the ordering of elements) are:
         1. (1, 4), (2, 3) -> min(1, 4) + min(2, 3) = 1 + 2 = 3
         2. (1, 3), (2, 4) -> min(1, 3) + min(2, 4) = 1 + 2 = 3
         3. (1, 2), (3, 4) -> min(1, 2) + min(3, 4) = 1 + 3 = 4
         So the maximum possible sum is 4.
         */

        // ---------------------------------------------------------------------- //

        // Time complexity:  O(n).
        // Space complexity: O(1).
        // Data input: x ->     performance: 45 ns;  memory: _ В.
        // Data input: x * 2 -> performance: 65 ns;  memory: _ В.
        // Data input: x * 4 -> performance: 150 us; memory: _ В.
        public static int ArrayPairSum1(int[] nums)
        {
            var sum = 0;
            Array.Sort(nums);

            for (var i = 0; i < nums.Length; i += 2)
            {
                sum += nums[i];
            }

            return sum;
        }

        // Time complexity:  O(n).
        // Space complexity: O(n).
        // Data input: x ->     performance: 120 ns; memory: 80 В.
        // Data input: x * 2 -> performance: 160 ns; memory: 104 В.
        // Data input: x * 4 -> performance: 300 us; memory: 152 В.
        public static int ArrayPairSum2(int[] nums)
        {
            var list = new List<int>(nums);
            list.Sort();
            var sum = 0;

            for (var i = 0; i < nums.Length;  i += 2)
            {
                sum += list[i];
            }

            return sum;
        }
        
        // Time complexity:  O(n).
        // Space complexity: O(1).
        // Data input: x ->     performance: 180 ns; memory: 104 В.
        // Data input: x * 2 -> performance: 280 ns; memory: 104 В.
        // Data input: x * 4 -> performance: 520 us; memory: 104 В.
        public static int ArrayPairSum3(int[] nums) {
            Array.Sort(nums);
            return nums.Where((x, i) => i % 2 == 0).Sum();
        }

        // Time complexity:  O(n).
        // Space complexity: O(n).
        // Data input: x ->     performance: 530 ns; memory: 544 В.
        // Data input: x * 2 -> performance: 850 ns; memory: 616 В.
        // Data input: x * 4 -> performance: 1.8 us; memory: 760 В.
        public static int ArrayPairSum4(int[] nums)
        {
            return nums.OrderBy(x => x).Where((x, i) => i % 2 == 0).Sum();
        }
    }
}
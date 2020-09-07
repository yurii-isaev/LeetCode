using System;
using System.Linq;

namespace Leetcode.MoveZeroes
{
    public static class Solution
    {
        /*
         283. Move Zeroes (https://leetcode.com/problems/move-zeroes/):
         
         Description:
         Given an integer array nums,
         move all 0's to the end of it while maintaining the relative order of the non-zero elements.
         Note that you must do this in-place without making a copy of the array.
         
         Example:
         Input: nums = [0,1,0,3,12].
         Output: [1,3,12,0,0].
         */

        // ---------------------------------------------------------------------- //

        // Time complexity:  O(n). 
        // Space complexity: O(1).
        // Data input: x ->     performance: 10 ns; memory: _ B.
        // Data input: x * 2 -> performance: 15 us; memory: _ B.
        // Data input: x * 4 -> performance: 25 us; memory: _ B.
        // Data input: x * 6 -> performance: 35 us; memory: _ B.
        // public static void MoveZeroes1(int[] nums)
        public static int[] MoveZeroes1(int[] nums)
        {
            var zeroIndex = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                    nums[zeroIndex++] = nums[i];
            }

            Array.Fill(nums, 0, zeroIndex, nums.Length - zeroIndex);

            return nums;
        }

        // Time complexity: O(n). 
        // Space complexity:   O(1).
        // Data input: x ->     performance: 10 ns; memory: _ B.
        // Data input: x * 2 -> performance: 15 us; memory: _ B.
        // Data input: x * 4 -> performance: 25 us; memory: _ B.
        // Data input: x * 6 -> performance: 30 us; memory: _ B.
        // public static void MoveZeroes2(int[] nums)
        public static int[] MoveZeroes2(int[] nums)
        {
            if (nums.Length == 0) return new int[] {};
            var insertIndex = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                    nums[insertIndex++] = nums[i];
            }

            for (var j = insertIndex; j < nums.Length; j++)
                nums[j] = 0;

            return nums;
        }

        // Time complexity:  O(n). 
        // Space complexity: O(1).
        // Data input: x ->     performance: 10 ns; memory: _ B.
        // Data input: x * 2 -> performance: 20 us; memory: _ B.
        // Data input: x * 4 -> performance: 40 us; memory: _ B.
        // Data input: x * 6 -> performance: 50 us; memory: _ B. B.
        // public static void MoveZeroes3(int[] nums)
        public static int[] MoveZeroes3(int[] nums)
        {
            if (nums == null || nums.Length == 0) return new int[] {};
            var zeros = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    zeros++;
                }
                else
                {
                    if (zeros <= 0) continue;
                    nums[i - zeros] = nums[i];
                    nums[i] = 0;
                }
            }

            return nums;
        }

        // Time complexity:  O(n). 
        // Space complexity: O(n).
        // Data input: x ->     performance: 300 ns; memory: 440 B.
        // Data input: x * 2 -> performance: 400 us; memory: 496 B.
        // Data input: x * 4 -> performance: 800 us; memory: 624 B.
        // Data input: x * 6 -> performance: 900 us; memory: 704 B.
        //public static void MoveZeroesByLinq(int[] nums) 
        public static int[] MoveZeroesByLinq(int[] nums)
        {
            var result = nums.OrderBy(x => x == 0).ToArray();
            for (var i = 0; i < nums.Length; i++) nums[i] = result[i];

            return nums;
        }
    }
}

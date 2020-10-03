using System;
using System.Linq;

namespace Leetcode.MaxConsecutiveOnes
{
    public static class Solution
    {
        /*
         485. Max Consecutive Ones (https://leetcode.com/problems/max-consecutive-ones/):
         
         Description:
         Given a binary array nums, return the maximum number of consecutive 1's in the array.
         
         Example:
         Input: nums = [1,1,0,1,1,1]
         Output: 3
         
         ---------------------------------
         Explanation:
         The first two digits or the last three digits are consecutive 1s.
         The maximum number of consecutive 1s is 3.
         */

        // ---------------------------------------------------------------------- //

        // Time complexity:  O(n).
        // Space complexity: O(1).
        // Data input: x ->     performance: 15 ns; memory: _ B.
        // Data input: x * 2 -> performance: 30 ns; memory: _ B.
        // Data input: x * 4 -> performance: 60 ns; memory: _ B.
        public static int FindMaxConsecutiveOnes1(int[] nums)
        {
            var max = 0;
            var curr = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    if (curr > max) max = curr;
                    curr = 0;
                }
                else curr++;
            }

            return max > curr ? max : curr;
        }

        // Time complexity:  O(n). 
        // Space complexity: O(1).
        // Data input: x ->     performance: 20 ns; memory: _ B.
        // Data input: x * 2 -> performance: 40 ns; memory: _ B.
        // Data input: x * 4 -> performance: 80 ns; memory: _ B.
        public static int FindMaxConsecutiveOnes2(int[] nums)
        {
            var tempMax = 0;
            var totalMax = 0;
            foreach (var num in nums)
            {
                tempMax = (num == 0) ? 0 : tempMax + 1;
                totalMax = Math.Max(totalMax, tempMax);
            }

            return totalMax;
        }

        // Time complexity:  O(n). 
        // Space complexity: O(1).
        // Data input: x ->     performance: 30 ns;  memory: _ B.
        // Data input: x * 2 -> performance: 60 ns;  memory: _ B.
        // Data input: x * 4 -> performance: 120 ns; memory: _ B.
        public static int FindMaxConsecutiveOnes3(int[] nums)
        {
            var n = nums.Length;
            if (n == 0) return 0;
            var max = nums[0] == 1 ? 1 : 0;
            var cur = 1;

            for (var i = 1; i < n; i++)
            {
                if (nums[i - 1] == nums[i] && nums[i] == 1)
                {
                    cur++;
                }
                else
                {
                    cur = 1;
                }

                if (nums[i] == 1)
                {
                    max = Math.Max(max, cur);
                }
            }

            return max;
        }

        // Time complexity:  O(n). 
        // Space complexity: O(1).
        // Data input: x ->     performance: 650 ns; memory: _ B.
        // Data input: x * 2 -> performance: 1.1 us; memory: _ B.
        // Data input: x * 4 -> performance:   2 us; memory: _ B.
        public static int FindMaxConsecutiveOnes4(int[] nums)
        {
            return string.Join("", nums).Split('0').Max(x => x.Length);
        }
    }
}

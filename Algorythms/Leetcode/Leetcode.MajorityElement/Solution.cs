using System.Linq;

namespace Leetcode.MajorityElement
{
    public static class Solution
    {
        /*
         169. Majority Element (https://leetcode.com/problems/majority-element/):
         
         Description:
         Given an array nums of size n, return the majority element.
         The majority element is the element that appears more than n/2 times.
         You may assume that the majority element always exists in the array.
         
         Example:
         Input: nums = [3,2,3].
         Output: 3.
         */

        // ---------------------------------------------------------------------- //

        // Time complexity:  O(n). 
        // Space complexity: O(1).
        // Data input: x ->     performance: 20 ns; memory: _ B.
        // Data input: x * 2 -> performance: 40 ns; memory: _ B.
        public static int FindMajorityElementByCount(int[] nums)
        {
            if (nums == null || nums.Length == 0) return -1;
            var res = nums[0];
            var count = 1;
            var hasMajority = true;

            for (var i = 1; i < nums.Length; i++)
            {
                var cur = nums[i];
                if (hasMajority)
                {
                    if (cur == res) count++;
                    else count--;
                    hasMajority = count > 0;
                }
                else
                {
                    count = 1;
                    hasMajority = true;
                    res = nums[i];
                }
            }

            return res;
        }

        // Time complexity:  O(n). 
        // Space complexity: O(1).
        // Data input: x ->     performance: 20 ns; memory: _ B. 
        // Data input: x * 2 -> performance: 40 ns; memory: _ B. 
        public static int FindMajorityElement(int[] nums)
        {
            if (nums == null || nums.Length == 0) return -1;
            var res = nums[0];
            var counter = 0;

            foreach (var num in nums)
            {
                if (counter == 0) res = num;
                counter += num == res ? 1 : -1;
            }

            return res;
        }

        // Time complexity:  O(n). 
        // Space complexity: O(n).
        // Data input: x ->     performance: 900 ns; memory:  960 B.
        // Data input: x * 2 -> performance: 1.7 us; memory: 1624 B.
        public static int FindMajorityElementByLinq(int[] nums)
        {
            if (nums == null || nums.Length == 0) return -1;

            return nums.GroupBy(x => x)
                .OrderByDescending(gp => gp.Count())
                .First().Key;
        }
    }
}

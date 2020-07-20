using System;
using System.Linq;

namespace Leetcode.RemoveElement
{
    public static class Solution
    {
        /*
        27. Remove Element (https://leetcode.com/problems/remove-element/):
        
        Description:
        Given an integer array nums and an integer val, remove all occurrences of val in nums in-place.
        The relative order of the elements may be changed.
        Return k after placing the final result in the first k slots of nums.
        Do not allocate extra space for another array.
        You must do this by modifying the input array in-place with O(1) extra memory.
        
        Example:
        Input: nums = [3,2,2,3], val = 3
        Output: 2, nums = [2,2,_,_]
        */

        // ---------------------------------------------------------------------- //

        // Time complexity:  O(n).
        // Space complexity: O(1).
        // Data input: x ->     performance: 10 ns; memory: _ B.
        // Data input: x * 2 -> performance: 20 ns; memory: _ B.
        // Data input: x * 3 -> performance: 30 ns; memory: _ B.
        public static int RemoveElementByForeach(int[] nums, int val)
        {
            var i = -1;
            foreach (var num in nums)
            {
                if (num != val) nums[++i] = num;
            }

            return i + 1;
        }

        // Time complexity:  O(n).
        // Space complexity: O(1).
        // Data input: x ->     performance: 20 ns; memory: _ B.
        // Data input: x * 2 -> performance: 40 ns; memory: _ B.
        // Data input: x * 3 -> performance: 60 ns; memory: _ B.
        public static int RemoveElementByFor(int[] nums, int val)
        {
            var count = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[count++] = nums[i];
                }
            }

            Array.Resize(ref nums, count);
            return nums.Length != 0 ? count : 0;
        }

        // Time complexity:  O(n).
        // Space complexity: O(n).
        // Data input: x ->     performance: 370 ns; memory: 472 B.
        // Data input: x * 2 -> performance: 490 us; memory: 648 B. 
        // Data input: x * 3 -> performance: 550 us; memory: 768 B. 
        public static int RemoveElementByLinq(int[] nums, int val)
        {
            var res = nums.ToList().Where(x => x != val).ToArray();
            Array.Clear(nums, 0, nums.Length);
            Array.Copy(res, nums, res.Length);
            return res.Length;
        }
    }
}

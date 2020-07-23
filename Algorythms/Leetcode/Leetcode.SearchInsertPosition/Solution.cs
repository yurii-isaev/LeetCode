using System;
using System.Linq;

namespace Leetcode.SearchInsertPosition
{
    public static class Solution
    {
        /*
         35. Search Insert Position (https://leetcode.com/problems/search-insert-position/):
         
         Description:
         Given a sorted array of distinct integers, and a target value,
         return the index if the target is found.
         If not, return the index where it would be if it were inserted in order.
         You must write an algorithm with O(log n) runtime complexity.
         
         Example:
         Input: nums = [1,3,5,6], target = 5.
         Output: 2.
         */
        
        // ---------------------------------------------------------------------- //

        // Time complexity:  O(log n).
        // Space complexity: O(1).
        // Data input: x ->     performance:  5 ns; memory: _ B.
        // Data input: x * 2 -> performance:  5 ns; memory: _ B. 
        // Data input: x * 4 -> performance: 10 ns; memory: _ B.
        public static int SearchInsert(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0) return 0;
            var start = 0;
            var end = nums.Length - 1;
            
            while (start < end)
            {
                var mid = (start + end) / 2;

                if (target > nums[mid]) start = mid + 1;
                else if (target < nums[mid]) end = mid - 1;
                else return mid;
            }

            if (start == end && target > nums[start])
                return start + 1;
            
            return start;
        }

        // Time complexity:  O(log n).
        // Space complexity: O(1).
        // Data input: x ->     performance: 15 ns; memory: _ B.
        // Data input: x * 2 -> performance: 15 ns; memory: _ B.
        // Data input: x * 4 -> performance: 30 ns; memory: _ B.
        public static int SearchInsertByBinarySearch(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0) return 0;
            var res = Array.BinarySearch(nums, target);
            return res < 0 ? ~res : res;
        }

        // Time complexity:  O(n). 
        // Space complexity: O(1).
        // Data input: x ->     performance:  8 ns; memory: _ B. 
        // Data input: x * 2 -> performance: 10 ns; memory: _ B. 
        // Data input: x * 4 -> performance: 20 ns; memory: _ B. 
        public static int SearchInsertByFor(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0) return 0;
            
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] >= target) return i;
            }

            return nums.Length;
        }

        // Time complexity:  O(n). 
        // Space complexity: O(1).
        // Data input: x ->     performance: 160 ns; memory: 192 B.
        // Data input: x * 2 -> performance: 240 ns; memory: 192 B.
        // Data input: x * 4 -> performance: 490 ns; memory: 192 B.
        public static int SearchInsertByLinq(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0) return 0;
            return nums.TakeWhile(x => (x < target)).Count();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace Leetcode.ContainsDuplicate
{
    public static class Solution
    {
        /*
        217. Contains Duplicate (https://leetcode.com/problems/contains-duplicate/):
        
        Description:
        Given an integer array nums,
        return true if any value appears at least twice in the array,
        and return false if every element is distinct.
        
        Example:
        Input: nums = [1,2,3,1].
        Output: true.
        */

        // ---------------------------------------------------------------------- //
        
        // Time complexity:  O(n). 
        // Space complexity: O(1).
        // Data input: x ->     performance:  70 ns; memory: _ B.
        // Data input: x * 2 -> performance: 140 ns; memory: _ B.
        public static bool IsContainsDuplicateByFor(int[] nums)
        {
            if (nums == null || nums.Length == 0 || nums.Length == 1) return false;
            Array.Sort(nums);

            for (var i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == nums[i + 1]) return true;
            }

            return false;
        }

        // Time complexity:  O(n). 
        // Space complexity: O(n).
        // Data input: x ->     performance: 200 ns; memory: 216 B.
        // Data input: x * 2 -> performance: 380 ns; memory: 368 B.
        public static bool IsContainsDuplicateByList(int[] nums)
        {
            if (nums == null || nums.Length == 0 || nums.Length == 1) return false;
            var list = new List<int>();

            foreach (var num in nums)
            {
                if (list.IndexOf(num) != -1) return true;
                else list.Add(num);
            }

            return false;
        }

        // Time complexity:  O(n). 
        // Space complexity: O(n).
        // Data input: x ->     performance: 360 ns; memory: 328 B.
        // Data input: x * 2 -> performance: 540 ns; memory: 520 B.
        public static bool IsContainsDuplicateByHashSet(int[] nums)
        {
            if (nums == null || nums.Length == 0 || nums.Length == 1) return false;
            return new HashSet<int>(nums).Count != nums.Length;
        }

        // Time complexity:  O(n). 
        // Space complexity: O(n).
        // Data input: x ->     performance: 340 ns; memory:  664 B.
        // Data input: x * 2 -> performance: 870 ns; memory: 1312 B.
        public static bool IsContainsDuplicateByForeach(int[] nums)
        {
            if (nums == null || nums.Length == 0 || nums.Length == 1) return false;
            var set = new HashSet<int>();

            foreach (var num in nums)
            {
                if (!set.Add(num)) return true;
            }

            return false;
        }

        // Time complexity:  O(n). 
        // Space complexity: O(n).
        // Data input: x ->     performance: 400 ns; memory:  608 B.
        // Data input: x * 2 -> performance: 800 ns; memory: 1160 B.
        public static bool IsContainsDuplicateByLinq(int[] nums)
        {
            if (nums == null || nums.Length == 0 || nums.Length == 1) return false;
            return nums.Length != nums.Distinct().Count();
        }

        // Time complexity:  O(n). 
        // Space complexity: O(n).
        // Data input: x ->     performance: 410 ns; memory: 768 B.
        // Data input: x * 2 -> performance: 840 ns; memory: 1560 B.
        public static bool IsContainsDuplicateByDictionary(int[] nums)
        {
            if (nums == null || nums.Length == 0 || nums.Length == 1) return false;
            var dict = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i])) return true;
                else dict.Add(nums[i], i);
            }

            return false;
        }
    }
}

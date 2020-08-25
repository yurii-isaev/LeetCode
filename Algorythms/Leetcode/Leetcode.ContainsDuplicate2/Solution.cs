using System.Collections.Generic;

namespace Leetcode.ContainsDuplicate2
{
    public static class Solution
    {
        /*
        219. Contains Duplicate II (https://leetcode.com/problems/contains-duplicate/):
        
        Description:
        Given an integer array nums and an integer k,
        return true if there are two identical numbers of different indices i and j in the array, 
        and the maximum distance between them is no more than the number k,
        nums[i] == nums[j] and abs(i - j) <= k.
        
        Example:
        Input: nums = [1,2,3,1], k = 3.
        Output: true.
        */

        // ---------------------------------------------------------------------- //

        // Time complexity:  O(n). 
        // Space complexity: O(n).
        // Data input: x ->     performance: 450 ns; memory: 168 B.
        // Data input: x * 2 -> performance: 930 ns; memory: 336 B.
        public static bool IsContainsDuplicateBySet(int[] nums, int k)
        {
            //if (nums == null || nums.Length == 0 || nums[0] == 0) return false;
            //if (k >= nums.Length) return false;
            var set = new HashSet<int>();

            for (var i = 0; i < nums.Length; i++)
            {
                if (set.Contains(nums[i]))
                {
                    return true;
                }
                else
                {
                    set.Add(nums[i]);
                }

                if (i >= k) set.Remove(nums[i - k]);
            }

            return false;
        }

        // Time complexity:  O(n). 
        // Space complexity: O(n).
        // Data input: x ->     performance: 450 ns; memory:  768 B.
        // Data input: x * 2 -> performance: 900 ns; memory: 1560 B.
        public static bool IsContainsDuplicateByDict(int[] nums, int k)
        {
            //if (nums == null || nums.Length == 0 || nums[0] == 0) return false;
            //if (k >= nums.Length) return false;
            var dict = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]) && i - dict[nums[i]] <= k)
                {
                    return true;
                }
                else
                {
                    dict[nums[i]] = i;
                }
            }

            return false;
        }
    }
}

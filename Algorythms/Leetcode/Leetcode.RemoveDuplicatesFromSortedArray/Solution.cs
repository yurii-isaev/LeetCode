using System.Collections.Generic;

namespace Leetcode.RemoveDuplicatesFromSortedArray
{
    public static class Solution
    {
        /*
         26. Remove Duplicates from Sorted Array
          (https://leetcode.com/problems/remove-duplicates-from-sorted-array/):
         
         Description:
         Given an integer array nums sorted in non-decreasing order,
         remove the duplicates in-place such that each unique element appears only once.
         The relative order of the elements should be kept the same.
         Return k after placing the final result in the first k slots of nums.
         Do not allocate extra space for another array.
         You must do this by modifying the input array in-place with O(1) extra memory.
         
         Example:
         Input: nums = [0,0,1,1,1,2,2,3,3,4]
         Output: 5, nums = [0,1,2,3,4,_,_,_,_,_]
         Explanation: Your function should return k = 5,
         with the first five elements of nums being 0, 1, 2, 3, and 4 respectively.
         It does not matter what you leave beyond the returned k (hence they are underscores).
         */

        //----------------------------------------------------------------------//

        // Time complexity:  O(n).
        // Space complexity: O(1).
        // Data input: x ->     performance: 15 ns; memory: _ B.
        // Data input: x * 2 -> performance: 30 us; memory: _ B.
        // Data input: x * 3 -> performance: 50 us; memory: _ B.
        public static int RemoveDuplicatesByFor(int[] nums)
        {
            if (nums == null || nums.Length == 0) return 0;
            if (nums.Length == 1) return 1;
            var k = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[k] == nums[i]) continue;
                k++;
                nums[k] = nums[i];
            }

            return k + 1;
        }

        // Time complexity:  O(n).
        // Space complexity: O(1).
        // Data input: x ->     performance: 20 ns; memory: _ B.
        // Data input: x * 2 -> performance: 30 ns; memory: _ B.
        // Data input: x * 3 -> performance: 50 ns; memory: _ B.
        public static int RemoveDuplicatesByForeach(int[] nums)
        {
            var k = 0;
            foreach (var num in nums)
            {
                if (nums[k] != num) nums[++k] = num;
            }

            return nums.Length != 0 ? k + 1 : 0;
        }

        // Time complexity:  O(n). 
        // Space complexity: O(n).
        // Data input: x ->     performance: 330 ns; memory: 328 B.
        // Data input: x * 2 -> performance: 560 ns; memory: 520 B.
        // Data input: x * 3 -> performance: 860 us; memory: 976 B.
        public static int RemoveDuplicatesByHashSet(int[] nums)
        {
            var hashSet = new HashSet<int>(nums);
            hashSet.CopyTo(nums);
            return hashSet.Count;
        }
    }
}

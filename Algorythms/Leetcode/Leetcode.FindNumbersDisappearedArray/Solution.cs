using System.Collections.Generic;
using System.Linq;

namespace Leetcode.FindNumbersDisappearedArray
{
    public static class Solution
    {
        /*
         448. Find All Numbers Disappeared in an Array
         (https://leetcode.com/problems/find-all-numbers-disappeared-in-an-array/):
         
         Description:
         Given an array nums of n integers where nums[i] is in the range [1, n],
         return an array of all the integers in the range [1, n] that do not appear in nums.
         
         Example 1:
         Input: nums = [4,3,2,7,8,2,3,1].
         Output: [5,6].
         
         Example 2:
         Input: nums = [1,1].
         Output: [2].
        */

        // ---------------------------------------------------------------------- //
        
        // Time complexity:  O(n). 
        // Space complexity: O(n).
        // Data input: x ->     performance:  60 ns; memory:  72 B.
        // Data input: x * 2 -> performance: 120 ns; memory: 128 B.
        public static IList<int> FindDisappearedNumbers1(int[] nums)
        {
            var list = new List<int>();

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] != i + 1)
                {
                    if (nums[i] == nums[nums[i] - 1]) continue;

                    int temp = nums[nums[i] - 1];
                    nums[nums[i] - 1] = nums[i];
                    nums[i] = temp;
                    i--;
                }
            }

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] != i + 1) list.Add(i + 1);
            }

            return list;
        }

        // Time complexity:  O(n). 
        // Space complexity: O(n).
        // Data input: x ->     performance:  70 ns;  memory: 72 B.
        // Data input: x * 2 -> performance: 180 us; memory: 128 B.
        public static IList<int> FindDisappearedNumbers2(int[] nums)
        {
            var list = new List<int>();

            for (var i = 0; i < nums.Length; i++)
            {
                var x = (nums[i] > 0 ? nums[i] : -nums[i]) - 1;
                nums[x] = nums[x] > 0 ? -nums[x] : nums[x];
            }

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0) list.Add(i + 1);
            }

            return list;
        }

        // Time complexity:  O(n). 
        // Space complexity: O(n).
        // Data input: x ->     performance: 60 ns;  memory: 136 B.
        // Data input: x * 2 -> performance: 130 ns; memory: 232 B.
        public static IList<int> FindDisappearedNumbers3(int[] nums)
        {
            var count = new List<int>();
            var temp = new int[nums.Length];

            foreach (var t in nums) temp[t - 1] = 1;

            for (var i = 0; i < nums.Length; i++)
            {
                if (temp[i] != 1) count.Add(i + 1);
            }

            return count;
        }

        // Time complexity:  O(n). 
        // Space complexity: O(n).
        // Data input: x ->     performance: 140 ns; memory: 72 B.
        // Data input: x * 2 -> performance: 330 ns; memory: 128 B.
        public static IList<int> FindDisappearedNumbers4(int[] nums)
        {
            var list = new List<int>();

            for (var i = 1; i <= nums.Length; i++)
            {
                if (!nums.Contains(i)) list.Add(i);
            }

            return list;
        }

        // Time complexity:  O(n). 
        // Space complexity: O(n).
        // Data input: x ->     performance: 700 ns; memory: 808 B.
        // Data input: x * 2 -> performance: 1.3 us; memory: 1456 B.
        public static IList<int> FindDisappearedNumbers5(int[] nums)
        {
            var temp = new int[nums.Length];
            for (var i = 0; i < temp.Length; i++) temp[i] = i + 1;

            return temp.Except(nums).ToList();
        }
    }
}

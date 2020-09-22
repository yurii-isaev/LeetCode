using System;
using System.Collections.Generic;
using System.Linq;

namespace Leetcode.ThirdMaximumNumber
{
    public static class Solution
    {
        /*
         414. Third Maximum Number (https://leetcode.com/problems/third-maximum-number/):
         
         Description:
         Given an integer array nums, return the third distinct maximum number in this array.
         If the third maximum does not exist, return the maximum number.
         
         Example1:
         Input: nums = [3,2,1].
         Output: 1.
         Explanation:
         The first distinct maximum is 3.
         The second distinct maximum is 2.
         The third distinct maximum is 1.
         
         Example2:
         Input: nums = [1,2].
         Output: 2.
         Explanation:
         The first distinct maximum is 2.
         The second distinct maximum is 1.
         The third distinct maximum does not exist, so the maximum (2) is returned instead.
        */

        // ---------------------------------------------------------------------- //

        // Time complexity:  O(n). 
        // Space complexity: O(1).
        // Data input: x ->     performance: 20 ns; memory: _ B.
        // Data input: x * 2 -> performance: 40 ns; memory: _ B.
        public static int ThirdMax(int[] nums)
        {
            int m = 0, m2 = 0, m3 = 0, c = 0;

            foreach (var n in nums)
            {
                if (c == 0 || n > m)
                {
                    m3 = m2;
                    m2 = m;
                    m = n;
                }
                else if (n < m && (c == 1 || n > m2))
                {
                    m3 = m2;
                    m2 = n;
                }
                else if (n < m2 && (c == 2 || n > m3))
                {
                    m3 = n;
                }
                else
                {
                    continue;
                }

                c++;
            }

            return c > 2 ? m3 : m;
        }

        // Time complexity:  O(n).  
        // Space complexity: O(n).
        // Data input: x ->     performance: 450 ns; memory: 392 B.
        // Data input: x * 2 -> performance: 740 ns; memory: 624 B.
        public static int ThirdMaxByArray(int[] nums)
        {
            if (nums == null || nums.Length == 0) return 0;

            var array = nums.ToHashSet().ToArray();
            Array.Sort(array);
            var len = array.Length;

            if (len > 0 && len < 3) return array[len - 1];
            else return array[len - 3];
        }

        // Time complexity:  O(n).  
        // Space complexity: O(n).
        // Data input: x ->     performance: 520 ns; memory: 448 B.
        // Data input: x * 2 -> performance: 1.2 us; memory: 848 B.
        public static int ThirdMaxBySortedSet(int[] nums)
        {
            var uniqueNumbers = new SortedSet<int>();
            for (var i = 0; i < nums.Length; i++)
            {
                uniqueNumbers.Add(nums[i]);
            }

            var result = uniqueNumbers.Max;
            if (uniqueNumbers.Count > 2)
            {
                for (var i = 0; i < 2; i++)
                {
                    uniqueNumbers.Remove(uniqueNumbers.Max);
                }

                return uniqueNumbers.Max;
            }

            return result;
        }

        // Time complexity:  O(n).  
        // Space complexity: O(n).
        // Data input: x ->     performance: 630 ns; memory: 640 B.
        // Data input: x * 2 -> performance: 1.3 us; memory: 1056 B.
        public static int ThirdMaxByLinqSortedSet(int[] nums)
        {
            if (nums == null || nums.Length == 0) return 0;

            var sortedSet = new SortedSet<int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));
            foreach (var num in nums) sortedSet.Add(num);
            return sortedSet.Count() > 2 ? sortedSet.ElementAt(2) : sortedSet.ElementAt(0);
        }

        // Time complexity:  O(n).  
        // Space complexity: O(n).
        // Data input: x ->     performance: 1.2 us; memory: 1192 B.
        // Data input: x * 2 -> performance: 1.8 us; memory: 1904 B.
        public static int ThirdMaxByLinq(int[] nums)
        {
            if (nums == null || nums.Length == 0) return 0;

            var temp = nums.OrderByDescending(x => x).Distinct().ToList();
            return temp.Count >= 3 ? temp[2] : temp[0];
        }
    }
}

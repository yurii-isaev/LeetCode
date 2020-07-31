using System;
using System.Linq;

namespace Leetсode.MergeSortedArray
{
    public static class Solution
    {
        /*
         88. Merge Sorted Array (https://leetcode.com/problems/merge-sorted-array/):
         
         Description:
         You are given two integer arrays nums1 and nums2, sorted in non-decreasing order,
         and two integers m and n, representing the number of elements in nums1 and nums2 respectively.
         Merge nums1 and nums2 into a single array sorted in non-decreasing order.
         The final sorted array should not be returned by the function, but instead be stored inside the array nums1.
         To accommodate this, nums1 has a length of m + n,
         where the first m elements denote the elements that should be merged,
         and the last n elements are set to 0 and should be ignored. nums2 has a length of n.
         
         Example:
         Input: nums1 = [1,2,3,0,0,0], m = 3, nums2 = [2,5,6], n = 3
         Output: [1,2,2,3,5,6]
         Explanation: The arrays we are merging are [1,2,3] and [2,5,6].
         The result of the merge is [1,2,2,3,5,6] with the underlined elements coming from nums1.
         */

        // ---------------------------------------------------------------------- //

        // Time complexity:  O(n). 
        // Space complexity: O(1).
        // Data input: x ->     performance: 20 ns; memory: _ B.
        // Data input: x * 2 -> performance: 30 ns; memory: _ B.
        public static int[] MergeByWhile(int[] nums1, int m, int[] nums2, int n)
        {
            m--;
            n--;
            var i = m + n + 1;
            while (m >= 0 && n >= 0)
            {
                if (nums1[m] > nums2[n]) nums1[i--] = nums1[m--];
                else nums1[i--] = nums2[n--];
            }

            while (m >= 0)
            {
                nums1[i--] = nums1[m--];
            }

            while (n >= 0)
            {
                nums1[i--] = nums2[n--];
            }

            return nums1;
        }

        // Time complexity:  O(n). 
        // Space complexity: O(1).
        // Data input: x ->     performance:  60 ns; memory: _ B.
        // Data input: x * 2 -> performance: 120 ns; memory: _ B.
        public static int[] MergeByFor(int[] nums1, int m, int[] nums2, int n)
        {
            var j = 0;
            for (var i = m; i < nums1.Length; i++)
            {
                nums1[i] = nums2[j];
                j++;
            }

            Array.Sort(nums1);
            return nums1;
        }

        // Time complexity:  O(n). 
        // Space complexity: O(1).
        // Data input: x ->     performance:  70 ns; memory: _ B. 
        // Data input: x * 2 -> performance: 120 ns; memory: _ B.
        public static int[] MergeByArray(int[] nums1, int m, int[] nums2, int n)
        {
            Array.Copy(nums2, 0, nums1, nums1.Length - n, n);
            Array.Sort(nums1);
            return nums1;
        }

        // Time complexity:  O(n). 
        // Space complexity: O(n).
        // Data input: x ->     performance: 545 ns; memory: 400 B.
        // Data input: x * 2 -> performance: 1.1 us; memory: 520 B.
        public static int[] MergeByLinq(int[] nums1, int m, int[] nums2, int n)
        {
            for (int i = m, j = 0; i < m + n && j < n; i++, j++)
                nums1[i] = nums2[j];

            var r = (from n1 in nums1 orderby n1 select n1).Take(m + n);
            var k = 0;
            foreach (var v in r) nums1[k++] = v;
            return nums1;
        }
    }
}

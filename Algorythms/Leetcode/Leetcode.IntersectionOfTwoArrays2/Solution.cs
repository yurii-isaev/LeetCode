using System;
using System.Collections.Generic;
using System.Linq;

namespace Leetcode.IntersectionOfTwoArrays2
{
    public static class Solution
    { 
        /*
       349. Intersection of Two Arrays II
       (https://leetcode.com/problems/intersection-of-two-arrays-ii/):
       
       Description:
       Given two integer arrays nums1 and nums2, return an array of their intersection.
       Each element in the result must appear as many times as it shows in both arrays
       and you may return the result in any order.
       
       Example:
       Input: nums1 = [1,2,2,1], nums2 = [2,2].
       Output: [2,2].
       */ 
        
        // ---------------------------------------------------------------------- //

        // Time complexity:  O(n). 
        // Space complexity: O(n).
        // Data input: x ->     performance: 170 ns; memory:  64 B.
        // Data input: x * 2 -> performance: 300 ns; memory: 104 B.
        public static int[] Intersect(int[] nums1, int[] nums2)
        {
            Array.Sort(nums1);
            Array.Sort(nums2);

            int i = 0, j = 0, k = 0;
            while (i < nums1.Length && j < nums2.Length)
            {
                if (nums1[i] < nums2[j])
                {
                    ++i;
                }
                else if (nums1[i] > nums2[j])
                {
                    ++j;
                }
                else
                {
                    nums1[k++] = nums1[i++];
                    ++j;
                }
            }

            return CopyOfRange(nums1, 0, k);
        }

        private static int[] CopyOfRange(int[] src, int start, int end)
        {
            var len = end - start;
            var dest = new int[len];
            Array.Copy(src, start, dest, 0, len);
            return dest;
        }

        // Time complexity:  O(n). 
        // Space complexity: O(n).
        // Data input: x ->     performance: 270 ns; memory: 280 B.
        // Data input: x * 2 -> performance: 470 ns; memory: 472 B.
        public static int[] IntersectByList(int[] nums1, int[] nums2)
        {
            var list = new List<int>();
            Array.Sort(nums1);
            Array.Sort(nums2);

            int i1 = 0, i2 = 0;

            while (i1 < nums1.Length && i2 < nums2.Length)
            {
                if (nums1[i1] == nums2[i2])
                {
                    list.Add(nums1[i1]);
                    i1++;
                    i2++;
                }
                else if (nums1[i1] < nums2[i2]) i1++;
                else i2++;
            }

            return list.ToArray();
        }

        // Time complexity:  O(n). 
        // Space complexity: O(n).
        // Data input: x ->     performance: 640 ns; memory: 544 B.
        // Data input: x * 2 -> performance: 1.1 us; memory: 760 B.
        public static int[] IntersectByLinq(int[] nums1, int[] nums2)
        {
            return nums1.ToList().Where(nums2.ToList().Remove).ToArray();
        }

        // Time complexity: O(n). 
        // Space complexity: O(n).
        // Data input: x ->     performance: 1 us; memory: 1120 B.
        // Data input: x * 2 -> performance: 2.1 ns; memory: 2048 B.
        public static int[] IntersectByLinqDictionary(int[] nums1, int[] nums2)
        {
            var map = new Dictionary<int, int>();

            foreach (var i in nums2)
            {
                map[i] = map.GetValueOrDefault(i) + 1;
            }

            return nums1.Where(n => map.GetValueOrDefault(n) > 0 && (map[n] = map[n] - 1) >= 0).ToArray();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace Leetcode.IntersectionOfTwoArrays
{
    public static class Solution
    {
        /*
        349. Intersection of Two Arrays
        (https://leetcode.com/problems/intersection-of-two-arrays/):
        
        Description:
        Given two integer arrays nums1 and nums2, return an array of their intersection.
        Each element in the result must be unique and you may return the result in any order.
        
        Example:
        Input: nums1 = [4,9,5], nums2 = [9,4,9,8,4].
        Output: [9,4].
        Explanation: [4,9] is also accepted.
        */

        // ---------------------------------------------------------------------- //

        // Time complexity:  O(n). 
        // Space complexity: O(n).
        // Data input: x ->     performance: 280 ns; memory: 280 B.
        // Data input: x * 2 -> performance: 550 ns; memory: 472 B.
        public static int[] IntersectionByList(int[] nums1, int[] nums2)
        {
            var list = new List<int>();

            foreach (var item in nums1)
            {
                if (Array.IndexOf(nums2, item) < 0) continue;
                if (!list.Contains(item)) list.Add(item);
            }

            return list.ToArray();
        }

        // Time complexity:  O(n). 
        // Space complexity: O(n).
        // Data input: x ->     performance: 680 ns; memory: 424 B.
        // Data input: x * 2 -> performance: 1.2 us; memory: 656 B.
        public static int[] IntersectionByHashSet(int[] nums1, int[] nums2)
        {
            var set = new HashSet<int>(nums1);
            set.IntersectWith(nums2);
            return set.ToArray();
        }

        // Time complexity:  O(n). 
        // Space complexity: O(n).
        // Data input: x ->     performance: 1.1 us; memory: 1344 B.
        // Data input: x * 2 -> performance: 1.6 us; memory: 2264 B.
        public static int[] IntersectionByLinq(int[] nums1, int[] nums2)
        {
            var set = nums1.ToHashSet();
            return nums2.Where(set.Contains).Reverse().Distinct().ToArray();
        }

        // Time complexity:  O(n). 
        // Space complexity: O(n).
        // Data input: x ->     performance: 1.1 us; memory: 1312 B.
        // Data input: x * 2 -> performance: 2.1 us; memory: 2456 B.
        public static int[] IntersectionByLinqIntersect(int[] nums1, int[] nums2)
        {
            return nums1.Intersect(nums2).Distinct().ToArray();
        }
    }
}

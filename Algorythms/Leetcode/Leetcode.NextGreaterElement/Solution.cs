using System.Collections.Generic;
using System.Linq;

namespace Leetcode.NextGreaterElement
{
    public static class Solution
    {
        /*
         496. Next Greater Element I (https://leetcode.com/problems/next-greater-element-i/):
         
         Description:
         The next greater element of some element x in an array is the first greater element
         that is to the right of x in the same array.
         You are given two distinct 0-indexed integer arrays nums1 and nums2, where nums1 is a subset of nums2.
         
         For each 0 <= i < nums1.length, find the index j such that nums1[i] == nums2[j]
         and determine the next greater element of nums2[j] in nums2. If there is no next greater element,
         then the answer for this query is -1.
        
         Return an array ans of length nums1.length such that ans[i] is the next greater element as described above.
        
         Example:
         Input: nums1 = [4,1,2], nums2 = [1,3,4,2].
         Output: [-1,3,-1].
        
         ---------------------------------
         Explanation:
         The next greater element for each value of nums1 is as follows:
         - 4 is underlined in nums2 = [1,3,4,2]. There is no next greater element, so the answer is -1.
         - 1 is underlined in nums2 = [1,3,4,2]. The next greater element is 3.
         - 2 is underlined in nums2 = [1,3,4,2]. There is no next greater element, so the answer is -1.
         */

        // ---------------------------------------------------------------------- //
        
        // Time complexity:  O(n).
        // Space complexity: O(n).
        // Data input: x ->     performance:  60 ns; memory:  48 В.
        // Data input: x * 2 -> performance: 120 ns; memory:  64 В.
        // Data input: x * 4 -> performance: 220 ns; memory: 104 В.
        public static int[] NextGreaterElement1(int[] nums1, int[] nums2)
        {
            var res = new int[nums1.Length];

            for (var i = 0; i < nums1.Length; i++)
            {
                var foundInt = false;
                var next = -1;

                for (var j = 0; j < nums2.Length; j++)
                {
                    if (nums1[i] == nums2[j] && !foundInt)
                    {
                        foundInt = true;
                        continue;
                    }

                    if (foundInt && nums2[j] > nums1[i])
                    {
                        next = nums2[j];
                        break;
                    }
                }

                res[i] = next;
            }

            return res;
        }

        // Time complexity:  O(n^2).
        // Space complexity: O(1).
        // Data input: x ->     performance: 60 ns;  memory: _ В.
        // Data input: x * 2 -> performance: 240 ns; memory: _ В.
        // Data input: x * 4 -> performance: 800 ns; memory: _ В.
        public static int[] NextGreaterElement2(int[] nums1, int[] nums2)
        {
            for (var i = 0; i < nums1.Length; i++)
            {
                var found = false;
                var bigValue = -1;

                for (var j = 0; j < nums2.Length; j++)
                {
                    if (nums1[i] == nums2[j])
                    {
                        found = true;
                        continue;
                    }

                    if (found)
                    {
                        if (nums2[j] > nums1[i])
                        {
                            bigValue = nums2[j];
                            break;
                        }
                    }
                }

                nums1[i] = bigValue;
            }

            return nums1;
        }


        // Time complexity:  O(n).
        // Space complexity: O(n).
        // Data input: x ->     performance: 330 ns; memory: 496 В.
        // Data input: x * 2 -> performance: 520 ns; memory: 512 В.
        // Data input: x * 4 -> performance:   1 us; memory: 608 В.
        public static int[] NextGreaterElement3(int[] nums1, int[] nums2)
        {
            var map = new Dictionary<int, int>();
            var stack = new Stack<int>();

            for (var i = 0; i < nums2.Length; i++)
            {
                while (stack.Count > 0 && stack.Peek() < nums2[i]) map[stack.Pop()] = nums2[i];
                stack.Push(nums2[i]);
            }

            var res = new int [nums1.Length];
            for (var j = 0; j < nums1.Length; j++)
            {
                res[j] = map.ContainsKey(nums1[j]) ? map[nums1[j]] : -1;
            }

            return res;
        }

        // Time complexity:  O(n).
        // Space complexity: O(n).
        // Data input: x ->     performance: 620 ns; memory:  992 В.
        // Data input: x * 2 -> performance: 980 ns; memory: 1328 В.
        // Data input: x * 4 -> performance:   2 us; memory: 2184 В.
        public static int[] NextGreaterElement4(int[] nums1, int[] nums2)
        {
            var dict = new Dictionary<int, int>();
            var stack = new Stack<int>();

            foreach (var n in nums2)
            {
                while (stack.Any() && stack.Peek() < n)
                {
                    dict[stack.Pop()] = n;
                }

                stack.Push(n);
            }

            return nums1.Select(x => dict.GetValueOrDefault(x, -1)).ToArray();
        }
    }
}

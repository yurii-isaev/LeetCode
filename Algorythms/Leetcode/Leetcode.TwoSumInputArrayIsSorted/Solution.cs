using System;

namespace Leetcode.TwoSumInputArrayIsSorted
{
    public static class Solution
    {
        /*
         167. Two Sum II - Input array is sorted (https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/):
         
         Description:
         Given a 1-indexed array of integers numbers that is already sorted in non-decreasing order,
         find two numbers such that they add up to a specific target number.
         Return the indices of the two numbers, index1 and index2, as an integer array [index1, index2] of length 2.
         The tests are generated such that there is exactly one solution.
         You may not use the same element twice.
         
         Example:
         Input: numbers = [2,7,11,15], target = 9
         Output: [1,2]
         Explanation:
         The sum of 2 and 7 is 9. Therefore, index1 = 1, index2 = 2. We return [1, 2].
         */

        //----------------------------------------------------------------------//

        // Time complexity:  O(n). 
        // Space complexity: O(1).
        // Recommended for search the end of an array.
        // Data input: x ->     performance: 20 ns; memory: 32 B.
        // Data input: x * 2 -> performance: 30 ns; memory: 32 B.
        public static int[] GetTwoSumByBinarySearch(int[] numbers, int target)
        {
            if (numbers.Length <= 1) return Array.Empty<int>();
            
            var res = new int[2];
            var start = 0;
            var end = numbers.Length - 1;

            while (start < end)
            {
                var sum = numbers[start] + numbers[end];
                if (target > sum)
                {
                    start++;
                }
                else if (target < sum)
                {
                    end--;
                }
                else
                {
                    res[0] = start + 1;
                    res[1] = end + 1;
                    return res;
                }
            }

            return Array.Empty<int>();
        }
    }
}

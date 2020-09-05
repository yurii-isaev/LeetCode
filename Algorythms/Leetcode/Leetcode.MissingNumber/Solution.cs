using System;
using System.Linq;

namespace Leetcode.MissingNumber
{
    public static class Solution
    {
        /*
       268. Missing Number (https://leetcode.com/problems/missing-number/):
       
       Description:
       Given an array containing distinct numbers in a range,
       return the only number in the range that is not in the array.
       
       Constraints:
       n == nums.length;
       1 <= n <= 104;
       0 <= nums[i] <= n;
       All the numbers of nums are unique.

       Example:
       Input: nums = [0,1].
       Output: 2.
       Explanation: n = 2 since there are 2 numbers, so all numbers are in the range [0,2].
       2 is the missing number in the range since it does not appear in nums.
       */

        // ---------------------------------------------------------------------- //

        // Time complexity:  O(n). 
        // Space complexity: O(1).
        // Data input: x ->     performance:  7 ns; memory: _
        // Data input: x * 2 -> performance: 10 ns; memory: _
        // Data input: x * 4 -> performance: 20 ns; memory: _
        // Data input: x * 6 -> performance: 60 ns; memory: 56 B.
        public static int MissingNumber1(int[] nums)
        {
            var result = nums.Length;

            for (var i = 0; i < nums.Length; i++)
            {
                result -= nums[i] - i;
            }

            return result;
        }

        // Time complexity:  O(n). 
        // Space complexity: O(n).
        // Data input: x ->     performance: 20 ns; memory: 32 B.
        // Data input: x * 2 -> performance: 30 us; memory: 40 B.
        // Data input: x * 4 -> performance: 50 us; memory: 48 B.
        // Data input: x * 6 -> performance: 60 us; memory: 56 B.
        public static int MissingNumber2(int[] nums)
        {
            var app = new bool[nums.Length + 1];

            foreach (var t in nums)
            {
                app[t] = true;
            }

            for (var i = 0; i < app.Length; i++)
            {
                if (!app[i]) return i;
            }

            return 0;
        }

        // Time complexity:  O(n). 
        // Space complexity: O(1).
        // Data input: x ->     performance:  50 ns; memory: _
        // Data input: x * 2 -> performance:  70 ns; memory: _
        // Data input: x * 4 -> performance: 130 ns; memory: _
        // Data input: x * 6 -> performance: 190 ns; memory: 32 B.
        public static int MissingNumber3(int[] nums)
        {
            Array.Sort(nums);
            int i;

            for (i = 0; i < nums.Length; i++)
            {
                if (nums[i] != i) break;
            }

            return i;
        }

        // Time complexity:  O(n). 
        // Space complexity: O(1).
        // Data input: x ->     performance: 50 ns;  memory: 32 B.
        // Data input: x * 2 -> performance: 80 ns;  memory: 32 B.
        // Data input: x * 4 -> performance: 140 ns; memory: 32 B.
        // Data input: x * 6 -> performance: 200 ns; memory: 32 B.
        public static int MissingNumber4(int[] nums)
        {
            return nums.Length * (nums.Length + 1) / 2 - nums.Sum();
        }

        // Time complexity:  O(n). 
        // Space complexity: O(1).
        // Data input: x ->     performance: 170 ns; memory: 192 B.
        // Data input: x * 2 -> performance: 260 ns; memory: 192 B.
        // Data input: x * 4 -> performance: 410 ns; memory: 192 B.
        // Data input: x * 6 -> performance: 560 ns; memory: 192 B.
        public static int MissingNumberByLinq(int[] nums)
        {
            return nums.Select((t, i) => (nums.Length - i - t)).Sum();
        }
    }
}

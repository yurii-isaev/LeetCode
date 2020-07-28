using System;
using System.Linq;
using System.Numerics;

namespace Leetcode.PlusOne
{
    public static class Solution
    {
        /*
         66. Plus One (https://leetcode.com/problems/plus-one/):
         
         Description:
         You are given a large integer represented as an integer array digits,
         where each digits[i] is the ith digit of the integer.
         The digits are ordered from most significant to least significant in left-to-right order.
         The large integer does not contain any leading 0's.
         Increment the large integer by one and return the resulting array of digits.
         
         Example:
         Input: digits = [1,2,3].
         Output: [1,2,4].
         Explanation: The array represents the integer 123.
         Incrementing by one gives 123 + 1 = 124.
         */
        
        //---------------------------------------------------------------------------------------//

        // Time complexity:  O(log n). 
        // Space complexity: O(1).
        // Data input: x ->     performance: 7.043 ns; memory: _
        // Data input: x * 2 -> performance: 6.900 ns; memory: _ 
        // Data input: x * 3 -> performance: 6.751 ns; memory: _ 
        public static int[] PlusOne1(int[] digits)
        {
            if (digits == null || digits.Length == 0) return Array.Empty<int>();
            
            for (var i = digits.Length - 1; i >= 0; --i)
            {
                if (digits[i] == 9)
                {
                    digits[i] = 0;
                }
                else
                {
                    digits[i] = digits[i] + 1;
                    return digits;
                }
            }

            var result = new int[digits.Length + 1];
            result[0] = 1;
            Array.Copy(digits, 0, result, 1, digits.Length);

            return result;
        }

        // Time complexity:  O(log n). 
        // Space complexity: O(1).
        // Data input: x ->     performance: 8.734 ns; memory: _
        // Data input: x * 2 -> performance: 8.796 ns; memory: _
        // Data input: x * 3 -> performance: 8.789 ns; memory: _
        public static int[] PlusOne2(int[] digits)
        {
            if (digits == null || digits.Length == 0) return Array.Empty<int>();
            var res = 1;
            
            for (var i = digits.Length - 1; i >= 0; i--)
            {
                var num = digits[i] + res;
                digits[i] = num % 10;

                if (0 == (res = num / 10))
                    return digits;
            }

            return new[] {res}.Concat(digits).ToArray();
        }

        // Time complexity:  O(log n). 
        // Space complexity: O(1).
        // Data input: x ->     performance: 7.889 ns; memory: _
        // Data input: x * 2 -> performance: 7.854 ns; memory: _
        // Data input: x * 4 -> performance: 7.890 ns; memory: _
        public static int[] PlusOne3(int[] digits)
        {
            if (digits == null || digits.Length == 0) return Array.Empty<int>();
            var len = digits.Length;

            for (var i = len - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }

                // else -> digits[i] == 9
                digits[i] = 0;
            }

            // if -> digits[i] == 9
            var nums = new int[len + 1];
            nums[0] = 1;
            
            return nums;
        }

        // Time complexity:  O(n). 
        // Space complexity: O(2n).
        // Data input: x ->     performance:  4 us; memory:   776 B.
        // Data input: x * 2 -> performance:  9 us; memory:  2928 B.
        // Data input: x * 4 -> performance: 33 us; memory: 15840 B.
        public static int[] PlusOneByLinq(int[] digits)
        {
            if (digits == null || digits.Length == 0) return Array.Empty<int>();
            
            return (BigInteger.Parse(string.Join(string.Empty, digits)) + 1)
                .ToString()
                .Select(x => int.Parse(x.ToString()))
                .ToArray();
        }
    }
}

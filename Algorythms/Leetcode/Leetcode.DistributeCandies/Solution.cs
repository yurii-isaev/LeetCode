using System;
using System.Collections.Generic;
using System.Linq;

namespace Leetcode.DistributeCandies
{
    public static class Solution
    {
        /*
         575. Distribute Candies (https://leetcode.com/problems/distribute-candies/):
         
         Description:
         Given the integer array candyType of length n,
         return the maximum number of different types of candies she can eat if she only eats n / 2 of them.
         
         Example 1:
         Input: candyType = [1,1,2,2,3,3]
         Output: 3
         Explanation: Alice can only eat 6 / 2 = 3 candies.
         Since there are only 3 types, she can eat one of each type.
         
         Example 2:
         Input: candyType = [1,1,2,3]
         Output: 2
         Explanation: Alice can only eat 4 / 2 = 2 candies.
         Whether she eats types [1,2], [1,3], or [2,3], she still can only eat 2 different types.
         
         Example 3:
         Input: candyType = [6,6,6,6]
         Output: 1
         Explanation: Alice can only eat 4 / 2 = 2 candies.
         Even though she can eat 2 candies, she only has 1 type.
         */

        // ---------------------------------------------------------------------- //
        
        // Time complexity:  O(n). 
        // Space complexity: O(n).
        // Data input: x ->     performance: 210 ns; memory: 264 B.
        // Data input: x * 2 -> performance: 370 ns; memory: 424 B.
        // Data input: x * 4 -> performance: 590 ns; memory: 616 B.
        // Data input: x * 8 -> performance: 920 ns; memory: 904 B.
        public static int DistributeCandies1(int[] candyType)
        {
            var types = new HashSet<int>(candyType);
            return Math.Min(candyType.Length / 2, types.Count);
        }

        // Time complexity:  O(n). 
        // Space complexity: O(n).
        // Data input: x ->     performance: 270 ns; memory:  232 B.
        // Data input: x * 2 -> performance: 570 ns; memory:  424 B.
        // Data input: x * 4 -> performance: 1.1 us; memory:  816 B.
        // Data input: x * 8 -> performance: 2.3 us; memory: 3440 B.
        public static int DistributeCandies2(int[] candyType)
        {
            var dict = new Dictionary<int, int>();

            foreach (var can in candyType)
            {
                if (dict.ContainsKey(can)) dict[can]++;
                else dict[can] = 1;
            }

            var sistersCandies = dict.Sum(x => x.Value) / 2;

            return Math.Min(sistersCandies, dict.Count);
        }

        // Time complexity:  O(n). 
        // Space complexity: O(n).
        // Data input: x ->     performance: 215 ns; memory:  312 B.
        // Data input: x * 2 -> performance: 340 ns; memory:  312 B.
        // Data input: x * 4 -> performance: 670 ns; memory:  608 B.
        // Data input: x * 8 -> performance: 1.4 us; memory: 2224 B.
        public static int DistributeCandies3(int[] candyType)
        {
            var n = candyType.Length / 2;
            var t = candyType.Distinct().Count();
            if (n >= t) return t;
            return n;
        }

        // Time complexity:  O(n). 
        // Space complexity: O(n).
        // Data input: x ->     performance: 240 ns; memory:  312 B.
        // Data input: x * 2 -> performance: 370 ns; memory:  312 B.
        // Data input: x * 4 -> performance: 700 ns; memory:  608 B.
        // Data input: x * 8 -> performance: 1.4 us; memory: 2224 B.
        public static int DistributeCandies4(int[] candyType)
        {
            return Math.Min(candyType.Distinct().Count(), candyType.Count() / 2);
        }
    }
}
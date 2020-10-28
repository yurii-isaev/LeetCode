using System;
using System.Linq;

namespace Leetcode.RangeAddition2
{
    public static class Solution
    {
        /*
         598. Range Addition II (https://leetcode.com/problems/range-addition-ii/):
         
         Description:
         You are given an m x n matrix M initialized with all 0's and an array of operations ops,
         where ops[i] = [ai, bi] means M[x][y] should be incremented by one for all 0 <= x < ai and 0 <= y < bi.
         Count and return the number of maximum integers in the matrix after performing all the operations.
        
         Example 1:
         Input: m = 3, n = 3, ops = [[2,2],[3,3]]
         Output: 4
         Explanation: The maximum integer in M is 2, and there are four of it in M. So return 4.
         
         Example 2:
         Input: m = 3, n = 3, ops = [[2,2],[3,3],[3,3],[3,3],[2,2],[3,3],[3,3],[3,3],[2,2],[3,3],[3,3],[3,3]]
         Output: 4
         
         Example 3:
         Input: m = 3, n = 3, ops = []
         Output: 9
         */

        // ---------------------------------------------------------------------- //
        
        // Time complexity:  O(n). 
        // Space complexity: O(n).
        // Data input: x ->     performance:  5 ns; memory: _ B.
        // Data input: x * 2 -> performance: 10 ns; memory: _ B.
        // Data input: x * 4 -> performance: 20 ns; memory: _ B.
        public static int MaxCount1(int m, int n, int[][] ops)
        {
            int min1 = m, min2 = n;

            for (var i = 0; i < ops.Length; i++)
            {
                if (ops[i][0] < min1) min1 = ops[i][0];
                if (ops[i][1] < min2) min2 = ops[i][1];
            }

            return min1 * min2;
        }

        // Time complexity:  O(n). 
        // Space complexity: O(n).
        // Data input: x ->     performance:  8 ns; memory: _ B.
        // Data input: x * 2 -> performance: 15 ns; memory: _ B.
        // Data input: x * 4 -> performance: 25 us; memory: _ B.
        public static int MaxCount2(int m, int n, int[][] ops)
        {
            if (ops == null || ops.Length == 0) return m * n;
            int min1 = m, min2 = n;

            foreach (var op in ops)
            {
                min1 = Math.Min(min1, op[0]);
                min2 = Math.Min(min2, op[1]);
            }

            return min1 * min2;
        }

        // Time complexity:  O(n). 
        // Space complexity: O(n).
        // Data input: x ->     performance: 20 ns; memory: _ B.
        // Data input: x * 2 -> performance: 30 ns; memory: _ B.
        // Data input: x * 4 -> performance: 60 us; memory: _ B.
        public static int MaxCount3(int m, int n, int[,] ops)
        {
            int min1 = int.MaxValue, min2 = int.MaxValue;

            for (var i = 0; i < ops.GetLength(0); i++)
            {
                min1 = Math.Min(min1, ops[i, 0]);
                min2 = Math.Min(min2, ops[i, 1]);
            }

            return ops.GetLength(0) == 0 ? m * n : min1 * min2;
        }

        // Time complexity:  O(n). 
        // Space complexity: O(n).
        // Data input: x ->     performance: 100 ns; memory: 64 B.
        // Data input: x * 2 -> performance: 150 ns; memory: 64 B.
        // Data input: x * 4 -> performance: 220 ns; memory: 64 B.
        public static int MaxCount4(int m, int n, int[][] ops)
        {
            if (ops.Length == 0) return m * n;
            return ops.Min(op => op[0]) * ops.Min(op => op[1]);
        }

        // Time complexity:  O(n). 
        // Space complexity: O(n).
        // Data input: x ->     performance: 250 ns; memory: 96 B.
        // Data input: x * 2 -> performance: 300 ns; memory: 96 B.
        // Data input: x * 4 -> performance: 380 ns; memory: 96 B.
        public static int MaxCount5(int m, int n, int[][] ops)
        {
            return ops.Length == 0 ? m * n : ops.Select(o => o[0]).Min() * ops.Select(o => o[1]).Min();
        }
    }
}
using System;
using System.Collections.Generic;

namespace Leetсode.PascalTriangle2
{
    public static class Solution
    {
        /*
         119. Pascal's Triangle II (https://leetcode.com/problems/pascals-triangle-ii/):
         
         Description:
         Given an integer rowIndex, return the rowIndex (0-indexed) row of the Pascal's triangle.
         
         Example:
         Input: rowIndex = 3
         Output: [1,3,3,1]
         */

        // ---------------------------------------------------------------------- //
        
        // Time complexity:  O(n). 
        // Space complexity: O(n).
        // Data input: 10 -> performance:  80 ns;  memory: 72 B.
        // Data input: 20 -> performance: 280 ns; memory: 112 B.
        public static IList<int> GetRow(int rowIndex)
        {
            var res = new int[rowIndex + 1];
            res[0] = 1;
            
            for (var i = 1; i <= rowIndex; i++)
            {
                for (var k = i; k > 0; k--)
                    res[k] += res[k - 1];
            }

            return res;
        }

        // Time complexity:  O(n). 
        // Space complexity: O(n).
        // Data input: 10 -> performance: 180 ns; memory: 104 B.
        // Data input: 20 -> performance: 350 ns; memory: 114 B.
        public static IList<int> GetRowByList(int rowIndex)
        {
            IList<int> row = new List<int>(Math.Max(rowIndex + 1, 1));
            if (rowIndex < 0) return row;
            row.Add(1);
            
            for (var i = 0; i < rowIndex; i++)
            {
                long x = rowIndex - i;
                row.Add((int) (row[i] * x / (i + 1)));
            }

            return row;
        }

        // Time complexity:  O(n).
        // Space complexity: O(n).
        // Data input: 10 -> performance: 180 ns; memory: 176 B.
        // Data input: 20 -> performance: 570 ns; memory: 256 B.
        public static IList<int> GetRowByDp(int rowIndex)
        {
            var res = new int[rowIndex + 1];
            res[0] = 1;
            
            for (var row = 1; row < rowIndex + 1; row++)
            {
                for (var column = rowIndex - 1; column > 0; column--)
                    res[column] = res[column] + res[column - 1];
                res[rowIndex] = 1;
            }

            return new List<int>(res);
        }

        // Time complexity:  O(n). 
        // Space complexity: O(n).
        // Data input: 10 -> performance:   1 us; memory: 1376 B.
        // Data input: 20 -> performance: 3.4 us; memory: 4296 B.
        public static IList<int> GetRowByRecursion(int rowIndex)
        {
            var res = new List<int> {1};
            switch (rowIndex)
            {
                case 0: return res;
                case 1:
                    res.Add(1);
                    return res;
            }

            var prevList = GetRowByRecursion(rowIndex - 1);
            for (var i = 1; i < rowIndex; i++)
            {
                var numb = prevList[i - 1] + prevList[i];
                res.Add(numb);
            }

            res.Add(1);
            return res;
        }
    }
}

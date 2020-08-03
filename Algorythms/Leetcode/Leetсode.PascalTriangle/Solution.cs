using System.Collections.Generic;

namespace Leetсode.PascalTriangle
{
    public static class Solution
    {
        /*
         118. Pascal's Triangle (https://leetcode.com/problems/pascals-triangle/):
         
         Description:
         Given an integer numRows,
         return the first numRows of Pascal's triangle.
         
         Example:
         Input: numRows = 5.
         Output: [[1],[1,1],[1,2,1],[1,3,3,1],[1,4,6,4,1]]
         */
        
        //---------------------------------------------------------------------------------------//

        // Time complexity:  O(n). 
        // Space complexity: O(n).
        // Data input: 10 -> performance: 1.7 us; memory:  584 B.
        // Data input: 20 -> performance: 6.8 us; memory: 1544 B.
        public static IList<IList<int>> GenerateByDp(int numRows)
        {
            // Dynamic programming approach.
            IList<IList<int>> res = new int[numRows][];
            if (numRows == 0 || numRows == 31) return res;
            // Vertical iteration.
            for (var i = 1; i <= numRows; i++)
            {
                var currentRow = new int[i];
                currentRow[0] = 1;
                currentRow[i - 1] = 1;
                // Horizontal iteration.            
                for (var j = 2; j <= i - 1; j++)
                    currentRow[j - 1] = res[i - 2][j - 2] + res[i - 2][j - 1];
                res[i - 1] = currentRow;
            }

            return res;
        }

        // Time complexity:  O(n).
        // Space complexity: O(n).
        // Data input: 10 -> performance: 1.4 us; memory: 936 B.
        // Data input: 20 -> performance: 4.8 us; memory: 2216 B.
        public static IList<IList<int>> Generate(int numRows)
        {
            var res = new List<IList<int>>(numRows);
            if (numRows == 0 || numRows == 31) return res;
            
            for (var num = 1; num <= numRows; num++)
            {
                var list = new List<int>(num);
                for (var i = 0; i < num; i++)
                {
                    if (i == 0 || i == num - 1) list.Add(1);
                    else list.Add(res[num - 2][i] + res[num - 2][i - 1]);
                }

                res.Add(list);
            }

            return res;
        }

        // Time complexity:  O(n).
        // Space complexity: O(n).
        // Data input: 10 -> performance:  1.6 us; memory:  848 B.
        // Data input: 20 -> performance:  4.9 us; memory: 2008 B.
        public static IList<IList<int>> GenerateByRecursion(int numRows)
        {
            var res = new List<IList<int>>();
            if (numRows == 0 || numRows == 31) return res;
            GenerateByRecursion(numRows, res);
            return res;
        }

        private static void GenerateByRecursion(int numRows, IList<IList<int>> result)
        {
            if (numRows == 1)
            {
                result.Add(new List<int>() {1});
                return;
            }

            GenerateByRecursion(numRows - 1, result);
            var workingResult = new int[numRows];
            result.Add(workingResult);
            // First and last element of row is always 1
            workingResult[0] = 1;
            workingResult[numRows - 1] = 1;
            if (numRows <= 2) return;
            var previousResult = result[numRows - 2];
            for (var i = 1; i < numRows - 1; i++)
                workingResult[i] = previousResult[i - 1] + previousResult[i];
        }

        // Time complexity:  O(n).
        // Space complexity: O(n).
        // Data input: 10 -> performance: 2.6 us; memory: 1560 B.
        // Data input: 20 -> performance: 8.3 us; memory: 4608 B.
        public static IList<IList<int>> GenerateByList(int numRows)
        {
            var res = new List<IList<int>>();
            if (numRows == 0 || numRows == 31) return res;
            var row = new List<int> {1};
            res.Add(row);
            if (numRows == 1) return res;
            
            for (var i = 1; i < numRows; i++)
            {
                row = new List<int> {1}; //start
                var prevRow = res[i - 1];
                for (var j = 0; j < prevRow.Count - 1; j++)
                    row.Add(prevRow[j] + prevRow[j + 1]); //middle
                row.Add(1); //end
                res.Add(row);
            }

            return res;
        }
    }
}

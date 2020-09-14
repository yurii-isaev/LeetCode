using System.Collections.Generic;

namespace Leetcode.RangeSumQuery2DImmutable
{
    /*
    304. Range Sum Query 2D - Immutable
    (https://leetcode.com/problems/range-sum-query-2d-immutable/):
    
    Description:
    Given a 2D matrix matrix,
    calculate the sum of the elements of matrix inside the rectangle defined
    by its upper left corner (row1, col1) and lower right corner (row2, col2).
    
    Your NumArray object will be instantiated and called as such:
    NumArray obj = new NumArray(nums);
    int param_1 = obj.SumRange(left,right);
    
    Explanation:
    NumMatrix numMatrix = new NumMatrix([
    [3, 0, 1, 4, 2],
    [5, 6, 3, 2, 1],
    [1, 2, 0, 1, 5],
    [4, 1, 0, 1, 7],
    [1, 0, 3, 0, 5]]);
    
    numMatrix.sumRegion(2,1,4,3); // return 8 (i.e sum of the red rectangle)
    umMatrix.sumRegion(1,1,2,2);  // return 11 (i.e sum of the green rectangle)
    numMatrix.sumRegion(1,2,2,4); // return 12 (i.e sum of the blue rectangle)
    */

    // ---------------------------------------------------------------------- //

    // Time complexity:  O(n). 
    // Space complexity: O(1).
    // Data input: x ->     performance: 20 ns; memory: 24 B.
    // Data input: x * 2 -> performance: 30 ns; memory: 24 B.
    public class NumMatrix
    {
        private readonly int[][] _matrix;

        public NumMatrix(int[][] matrix) => _matrix = matrix;

        public int SumRegion(int row1, int col1, int row2, int col2)
        {
            var sum = 0;
            for (var row = row1; row <= row2; row++)
            {
                for (var col = col1; col <= col2; col++)
                {
                    sum += _matrix[row][col];
                }
            }

            return sum;
        }
    }

    // Time complexity:  O(n). 
    // Space complexity: O(n).
    // Data input: x ->     performance: 450 ns; memory: 328 B.
    // Data input: x * 2 -> performance: 780 ns; memory: 448 B.
    public class NumMatrixByDp
    {
        private readonly int[][] _matrix;

        public NumMatrixByDp(IReadOnlyList<int[]> matrix)
        {
            if (matrix.Count == 0 || matrix[0].Length == 0) return;
            _matrix = new int[matrix.Count][];

            for (var i = 0; i < matrix.Count; i++)
            {
                _matrix[i] = new int[matrix[0].Length + 1];

                for (var j = 0; j < matrix[0].Length; j++)
                {
                    _matrix[i][j + 1] = _matrix[i][j] + matrix[i][j];
                }
            }
        }

        public int SumRegion(int row1, int col1, int row2, int col2)
        {
            var sum = 0;
            for (var row = row1; row <= row2; row++)
                sum += _matrix[row][col2 + 1] - _matrix[row][col1];

            return sum;
        }
    }
}

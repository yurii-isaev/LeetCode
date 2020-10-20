using System.Collections.Generic;
using System.Linq;

namespace Leetcode.ReshapeMatrix
{
    public static class Solution
    {
        /*
         566. Reshape the Matrix (https://leetcode.com/problems/reshape-the-matrix/):
         
         Description:
         You are given an m x n matrix mat and two integers r and c representing the number of rows and
         the number of columns of the wanted reshaped matrix.
        
         Example 1:
         Input: mat = [[1,2],[3,4]], r = 1, c = 4
         Output: [[1,2,3,4]]
         Explanation:
         The row-traversing of nums is [1,2,3,4].
         The new reshaped matrix is a 1 * 4 matrix, fill it row by row by using the previous list.
        
         Example 2:
         Input: mat = [[1,2],[3,4]], r = 2, c = 4
         Output: [[1,2],[3,4]]
         Explanation:
         There is no way to reshape a 2 * 2 matrix to a 2 * 4 matrix. So output the original matrix.
         */

        // ---------------------------------------------------------------------- //

        // Time complexity:  O(n). 
        // Space complexity: O(n).
        // Data input: x ->     performance: 30 ns; memory:  72 B.
        // Data input: x * 2 -> performance: 60 ns; memory: 120 B.
        public static int[][] MatrixReshape1(int[][] mat, int r, int c)
        {
            var result = mat;

            if (mat.Length * mat[0].Length == r * c && !(mat.Length == r && mat[0].Length == c))
            {
                result = new int[r][];
                var newRowIndex = 0;
                var row = 0;
                var col = 0;

                while (newRowIndex < r)
                {
                    var newRow = new int[c];
                    for (var i = 0; i < c; ++i)
                    {
                        newRow[i] = mat[row][col];
                        col++;

                        if (col == mat[0].Length)
                        {
                            col = 0;
                            ++row;
                        }
                    }

                    result[newRowIndex] = newRow;
                    newRowIndex++;
                }
            }

            return result;
        }

        // Time complexity:  O(n). 
        // Space complexity: O(n).
        // Data input: x ->     performance:  50 ns; memory:  72 B.
        // Data input: x * 2 -> performance: 100 ns; memory: 120 B.
        public static int[][] MatrixReshape2(int[][] mat, int r, int c)
        {
            var m = mat.Length;
            var n = mat[0].Length;

            if (r * c != m * n) return mat;

            var res = new int[r][];

            for (var i = 0; i < res.Length; i++)
            {
                res[i] = new int[c];

                for (var j = 0; j < c; j++)
                {
                    res[i][j] = mat[(i * c + j) / n][(i * c + j) % n];
                }
            }

            return res;
        }

        // Time complexity:  O(n). 
        // Space complexity: O(n).
        // Data input: x ->     performance:  80 ns; memory: 72 B.
        // Data input: x * 2 -> performance: 170 ns; memory: 120 B.
        public static int[][] MatrixReshape3(int[][] mat, int r, int c)
        {
            var n = mat[0].Length;
            if (r * c != mat.Length * n) return mat;
            var result = new int[r][];

            for (var i = 0; i < r; i++) result[i] = new int[c];
            for (var i = 0; i < r * c; i++) result[i / c][i % c] = mat[i / n][i % n];

            return result;
        }

        // Time complexity:  O(n). 
        // Space complexity: O(n).
        // Data input: x ->     performance:  90 ns; memory: 152 B.
        // Data input: x * 2 -> performance: 190 ns; memory: 256 B.
        public static int[][] MatrixReshape4(int[][] mat, int r, int c)
        {
            if (mat.Length * mat[0].Length != r * c) return mat;

            var result = new int[r][];
            var queue = new Queue<int>();

            for (var i = 0; i < mat.Length; i++)
            {
                for (var j = 0; j < mat[0].Length; j++)
                {
                    queue.Enqueue(mat[i][j]);
                }
            }

            for (var i = 0; i < r; i++)
            {
                result[i] = new int[c];
                for (var j = 0; j < c; j++)
                {
                    result[i][j] = queue.Dequeue();
                }
            }

            return result;
        }

        // Time complexity:  O(n). 
        // Space complexity: O(n).
        // Data input: x ->     performance: 220 ns; memory: 232 B.
        // Data input: x * 2 -> performance: 390 ns; memory: 344 B.
        public static int[][] MatrixReshape5(int[][] mat, int r, int c)
        {
            var n = mat.Length;
            var m = mat[0].Length;

            if (r * c != m * n) return mat;

            var result = new int[r][];
            for (var i = 0; i < result.Length; i++)
            {
                result[i] = new int[c];
            }

            var count = 0;
            foreach (var num in mat.SelectMany(x => x))
            {
                result[count / c][count % c] = num;
                count++;
            }

            return result;
        }
    }
}

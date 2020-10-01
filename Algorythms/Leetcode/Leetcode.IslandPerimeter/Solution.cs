namespace Leetcode.IslandPerimeter
{
    public static class Solution
    {
        /*
         463. Island Perimeter (https://leetcode.com/problems/island-perimeter/):
         
         Description:
         You are given row x col grid representing a map where
         grid[i][j] = 1 represents land and grid[i][j] = 0 represents water.
         Grid cells are connected horizontally/vertically (not diagonally).
         The grid is completely surrounded by water,
         and there is exactly one island (i.e., one or more connected land cells).
         Determine the perimeter of the island.
         
         Example:
         Input: grid = [[0,1,0,0],
                        [1,1,1,0],
                        [0,1,0,0],
                        [1,1,0,0]].
         Output: 16.
         
         ---------------------------------
         Explanation: The perimeter is the 16 yellow stripes in the image above.
         */

        // ---------------------------------------------------------------------- //

        // Time complexity:  O(n). 
        // Space complexity: O(1).
        // Data input: x ->     performance: 35 ns; memory: _ B.
        // Data input: x * 2 -> performance: 80 ns; memory: _ B.
        public static int IslandPerimeter1(int[][] grid)
        {
            var count = 0;
            var n = 0;

            for (var i = 0; i < grid.Length; i++)
            {
                for (var j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        count++;

                        if (i > 0 && grid[i - 1][j] == 1) n++;
                        if (j > 0 && grid[i][j - 1] == 1) n++;
                    }
                }
            }

            return 4 * count - 2 * n;
        }

        // Time complexity:  O(n). 
        // Space complexity: O(1).
        // Data input: x ->     performance: 35 ns; memory: _ B.
        // Data input: x * 2 -> performance: 90 ns; memory: _ B.
        public static int IslandPerimeter2(int[][] grid)
        {
            var perimeter = 0;

            for (var i = 0; i < grid.Length; i++)
            {
                var prevCol = -1;
                var prevRow = -1;

                for (var j = 0; j < grid[i].Length; j++)
                {
                    var ctr = 0;
                    if (grid[i][j] != 0)
                    {
                        ctr = 4;
                        if (i != 0) prevRow = i - 1;
                        if (j != 0) prevCol = j - 1;
                        if (prevCol >= 0 && grid[i][prevCol] == 1) ctr -= 2;
                        if (prevRow >= 0 && grid[prevRow][j] == 1) ctr -= 2;
                    }

                    perimeter += ctr;
                }
            }

            return perimeter;
        }
    }
}

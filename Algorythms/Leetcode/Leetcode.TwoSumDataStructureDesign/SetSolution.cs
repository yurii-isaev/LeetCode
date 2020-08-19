using System.Collections.Generic;

namespace Leetcode.TwoSumDataStructureDesign
{
    public static class SetSolution
    {
        private static readonly HashSet<int> NumsSet;
        private static readonly HashSet<int> ResultSet;

        static SetSolution()
        {
            NumsSet = new HashSet<int>();
            ResultSet = new HashSet<int>();
        }

        // Time complexity:  O(n). 
        // Space complexity: O(1).
        // Data input: x ->  performance: 30 ns; memory: _ B.
        public static void Add(int number)
        {
            foreach (var num in NumsSet) ResultSet.Add(num + number);
            NumsSet.Add(number);
        }

        // Time complexity:  O(n).
        // Space complexity: O(1).
        // Data input: x ->  performance: 2 ns; memory: _ B.
        public static bool IsFind(int target)
        {
            return ResultSet.Contains(target);
        }
    }
}
using System.Collections.Generic;

namespace Leetcode.TwoSumDataStructureDesign
{
    public static class DictionarySolution
    {
        /*
         170. Two Sum III - Data structure design
         (https://leetcode.com/problems/two-sum-iii-data-structure-design/):
         
         Description:
         Design and implement a TwoSum class.
         It should support the following operations: add and find.
         add - Add the number to an internal data structure.
         find - Find if there exists any pair of numbers which sum is equal to the value.

        For example:
        add(1); add(3); add(5);
        find(4) -> true;
        find(7) -> false.
        */
        
        // ---------------------------------------------------------------------- //

        public static Dictionary<int, int> Map;

        static DictionarySolution() => Map = new Dictionary<int, int>();

        // Time complexity:  O(n). 
        // Space complexity: O(1).
        // Data input: x ->  performance: 30 ns; memory: _ B.
        public static void Add(int number)
        {
            if (Map.ContainsKey(number))
            {
                Map[number]++;
            }
            else
            {
                Map.Add(number, 1);
            }
        }

        // Time complexity:  O(log n). 
        // Space complexity: O(1).
        // Data input: x ->  performance: 5 ns; memory: _ B.
        public static bool IsFind1(int target)
        {
            if (target == 0) return false;
            
            var start = 0;
            var end = Map.Count - 1;
        
            while (start < end)
            {
                if (Map[start] + Map[end] == target) return true;
                if (Map[start] + Map[end] > target) end--;
                else start++;
            }
        
            return false;
        }
        
        // Time complexity:  O(n).
        // Space complexity: O(1).
        // Data input: x ->  performance: 8 ns; memory: _ B.
        public static bool IsFind2(int value)
        {
            foreach (var i in Map.Keys)
            {
                var valueToFind = value - i;

                if (valueToFind == i && Map[i] > 1)
                {
                    return true;
                }

                if (valueToFind != i && Map.ContainsKey(valueToFind))
                {
                    return true;
                }
            }

            return false;
        }
    }
}

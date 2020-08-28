using System.Collections.Generic;

namespace Leetcode.SummaryRanges
{
    public static class Solution
    {
        /*
        228. Summary Ranges (https://leetcode.com/problems/summary-ranges/):
        
        Description:
        Given a sorted unique integer array nums.
        The range is the set of all integers in the continuous sequence [a->b].
        Return the smallest sorted list of ranges that exactly cover all the numbers in the array.
        
        Conditions:
        Each range [a,b] in the list should be output as:
        "a->b" if a != b
        "a" if a == b
        
        Example:
        Input: nums = [0,1,2,4,5,7]
        Output: ["0->2","4->5","7"]
        */

        // ---------------------------------------------------------------------- //

        // Time complexity:  O(n). 
        // Space complexity: O(n).
        // Data input: x ->     performance: 400 ns; memory: 272 B.
        // Data input: x * 2 -> performance: 800 ns; memory: 520 B.
        public static IList<string> SummaryRanges1(int[] nums)
        {
            //if (nums.Length == 0) return new List<string>();
            var result = new List<string>();

            for (int i = 0, j = 0; i < nums.Length; j = ++i)
            {
                while (i + 1 < nums.Length && nums[i + 1] - nums[i] == 1)
                {
                    i++;
                }

                if (j == i)
                {
                    result.Add(nums[j].ToString());
                }
                else
                {
                    result.Add(nums[j] + "->" + nums[i]);
                }
            }

            return result;
        }

        // Time complexity:  O(n). 
        // Space complexity: O(n).
        // Data input: x ->     performance: 830 ns; memory: 416 B.
        // Data input: x * 2 -> performance: 1.7 us; memory: 808 B.
        public static IList<string> SummaryRanges2(int[] nums)
        {
            if (nums.Length == 0) return new List<string>();
            var res = new List<string>();
            var min = nums[0];

            for (var i = 1; i < nums.Length; ++i)
            {
                if (nums[i] == nums[i - 1] + 1) continue;
                Add(res, min, nums[i - 1]);
                min = nums[i];
            }

            Add(res, min, nums[^1]);

            return res;
        }

        private static void Add(ICollection<string> res, int min, int max)
        {
            res.Add(min == max ? min.ToString() : $"{min}->{max}");
        }
    }
}

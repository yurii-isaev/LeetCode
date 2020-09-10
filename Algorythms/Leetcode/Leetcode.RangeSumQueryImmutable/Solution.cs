using System.Collections.Generic;
using System.Linq;

namespace Leetcode.RangeSumQueryImmutable
{
    /*
     303. Range Sum Query - Immutable (https://leetcode.com/problems/range-sum-query-immutable/):
     
     Description:
     Given an integer array nums, handle multiple queries of the following type:
     Calculate the sum of the elements of nums between indices left and right inclusive where left <= right.
     
     Your NumArray object will be instantiated and called as such:
     NumArray obj = new NumArray(nums);
     int param_1 = obj.SumRange(left,right);
     
     Example:
     Input: ["NumArray", "sumRange", "sumRange", "sumRange"].
     [[[-2, 0, 3, -5, 2, -1]], [0, 2], [2, 5], [0, 5]].
     Output: [null, 1, -1, -3].
     
     Explanation:
     NumArray numArray = new NumArray([-2, 0, 3, -5, 2, -1]);
     numArray.sumRange(0, 2); // return (-2) + 0 + 3 = 1
     numArray.sumRange(2, 5); // return 3 + (-5) + 2 + (-1) = -1
     numArray.sumRange(0, 5); // return (-2) + 0 + 3 + (-5) + 2 + (-1) = -3
     */

    // ---------------------------------------------------------------------- //

    // Time complexity:  O(n). 
    // Space complexity: O(1).
    // Data input: x ->     performance: 15 ns; memory: 24 B.
    // Data input: x * 2 -> performance: 20 ns; memory: 24 B.
    // Data input: x * 4 -> performance: 35 ns; memory: 24 B.
    public class NumArray
    {
        private readonly int[] _nums;

        public NumArray(int[] nums) => _nums = nums;

        public int SumRange(int i, int j)
        {
            var sum = 0;

            for (var a = i; a <= j; a++)
            {
                sum += _nums[a];
            }

            return sum;
        }
    }

    // Time complexity:  O(n). 
    // Space complexity: O(1).
    // Data input: x ->     performance: 15 ns; memory: 24 B.
    // Data input: x * 2 -> performance: 20 ns; memory: 24 B.
    // Data input: x * 4 -> performance: 30 ns; memory: 24 B.
    public class NumArray2
    {
        private readonly int[] _nums;

        public NumArray2(int[] nums) => _nums = nums;

        public int SumRange(int left, int right)
        {
            if (left < 0) return 0;
            if (right > _nums.Length) return 0;
            var sum = 0;

            for (var i = left; i <= right; i++)
            {
                sum += _nums[i];
            }

            return sum;
        }
    }

    // Time complexity:  O(n). 
    // Space complexity: O(n).
    // Data input: x ->     performance:  90 ns; memory: 112 B.
    // Data input: x * 2 -> performance: 120 ns; memory: 128 B.
    // Data input: x * 4 -> performance: 200 ns; memory: 168 B.
    public class NumArray3
    {
        private readonly int[] _nums;

        public NumArray3(int[] nums) => _nums = nums;

        // arr[i..j] would get the subarray of elements from i to j, but not including.
        // the item at index j, so we offset the j by the adding one to include it in our addition operation.
        public int SumRange(int i, int j) => _nums[i..(j + 1)].Sum();
    }

    // Time complexity:  O(n). 
    // Space complexity: O(1).
    // Data input: x ->     performance: 200 ns; memory: 120 B.
    // Data input: x * 2 -> performance: 260 ns; memory: 120 B.
    // Data input: x * 4 -> performance: 380 ns; memory: 120 B.
    public class NumArrayByLinq
    {
        private readonly int[] _nums;

        public NumArrayByLinq(int[] nums) => _nums = nums;

        public int SumRange(int i, int j) => _nums.Skip(i).Take(j - i + 1).Sum();
    }

    // Time complexity:  O(n). 
    // Space complexity: O(n).
    // Data input: x ->     performance: 200 ns; memory: 248 B.
    // Data input: x * 2 -> performance: 250 ns; memory: 304 B.
    // Data input: x * 4 -> performance: 360 ns; memory: 424 B.
    public class NumArrayByListLinq
    {
        private readonly List<int> _nums;

        public NumArrayByListLinq(IEnumerable<int> nums) => _nums = new List<int>(nums);

        public int SumRange(int left, int right) => _nums.GetRange(left, (right - left + 1)).Sum();
    }
}

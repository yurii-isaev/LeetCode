using Leetcode.MaximumSubarray;
using NUnit.Framework;

namespace Leetcode.Tests
{
    [TestFixture]
    public class MaximumSubarrayTests
    {
        private readonly int[] _arr1 = {};
        private readonly int[] _arr2 = {0};
        private readonly int[] _arr3 = {1};
        private readonly int[] _arr4 = {5, 4, -1, 7, 8};
        private readonly int[] _arr5 = {-2, 1, -3, 4, -1, 2, 1, -5, 4};
        private readonly int[] _arr6 = {-2, 1, -3, 4, -1, 2, 1, -5, 4, 6};
        private readonly int[] _arr7 = {-2, 1, -3, 4, -1, 2, 1, -5, 4, 6, 3, 8, 4, -1, 5, -6, 2, 9, 0, 7};

        [Test]
        public void FindMaxSubArrayByForEach_BasicTests()
        {
            Assert.AreEqual(0, Solution.FindMaxSubArrayByForEach(_arr1));
            Assert.AreEqual(0, Solution.FindMaxSubArrayByForEach(_arr2));
            Assert.AreEqual(1, Solution.FindMaxSubArrayByForEach(_arr3));
            Assert.AreEqual(23, Solution.FindMaxSubArrayByForEach(_arr4));
            Assert.AreEqual(6, Solution.FindMaxSubArrayByForEach(_arr5));
            Assert.AreEqual(11, Solution.FindMaxSubArrayByForEach(_arr6));
            Assert.AreEqual(42, Solution.FindMaxSubArrayByForEach(_arr7));
        }

        [Test]
        public void FindMaxSubArray_BasicTests()
        {
            Assert.AreEqual(0, Solution.FindMaxSubArray(_arr1));
            Assert.AreEqual(0, Solution.FindMaxSubArrayByFor(_arr2));
            Assert.AreEqual(1, Solution.FindMaxSubArrayByFor(_arr3));
            Assert.AreEqual(23, Solution.FindMaxSubArrayByFor(_arr4));
            Assert.AreEqual(6, Solution.FindMaxSubArrayByFor(_arr5));
            Assert.AreEqual(11, Solution.FindMaxSubArrayByFor(_arr6));
            Assert.AreEqual(42, Solution.FindMaxSubArrayByFor(_arr7));
        }

        [Test]
        public void FindMaxSubArrayByFor_BasicTests()
        {
            Assert.AreEqual(0, Solution.FindMaxSubArrayByFor(_arr1));
            Assert.AreEqual(0, Solution.FindMaxSubArrayByFor(_arr2));
            Assert.AreEqual(1, Solution.FindMaxSubArrayByFor(_arr3));
            Assert.AreEqual(23, Solution.FindMaxSubArrayByFor(_arr4));
            Assert.AreEqual(6, Solution.FindMaxSubArrayByFor(_arr5));
            Assert.AreEqual(11, Solution.FindMaxSubArrayByFor(_arr6));
            Assert.AreEqual(42, Solution.FindMaxSubArrayByFor(_arr7));
        }
    }
}

using Leetcode.ArrayPartition;
using NUnit.Framework;

namespace Leetcode.Tests
{
    [TestFixture]
    public class ArrayPartitionTests
    {
        private readonly int[] _nums1 = {1};
        private readonly int[] _nums2 = {1, 1};
        private readonly int[] _nums3 = {1, 4, 3, 2};
        private readonly int[] _nums4 = {6, 2, 6, 5, 1, 2};

        [Test]
        public void ArrayPairSum1_BasicTests()
        {
            Assert.AreEqual(1, Solution.ArrayPairSum1(_nums1));
            Assert.AreEqual(1, Solution.ArrayPairSum1(_nums2));
            Assert.AreEqual(4, Solution.ArrayPairSum1(_nums3));
            Assert.AreEqual(9, Solution.ArrayPairSum1(_nums4));
        }

        [Test]
        public void ArrayPairSum2_BasicTests()
        {
            Assert.AreEqual(1, Solution.ArrayPairSum2(_nums1));
            Assert.AreEqual(1, Solution.ArrayPairSum2(_nums2));
            Assert.AreEqual(4, Solution.ArrayPairSum2(_nums3));
            Assert.AreEqual(9, Solution.ArrayPairSum2(_nums4));
        }

        [Test]
        public void ArrayPairSum3_BasicTests()
        {
            Assert.AreEqual(1, Solution.ArrayPairSum3(_nums1));
            Assert.AreEqual(1, Solution.ArrayPairSum3(_nums2));
            Assert.AreEqual(4, Solution.ArrayPairSum3(_nums3));
            Assert.AreEqual(9, Solution.ArrayPairSum3(_nums4));
        }

        [Test]
        public void ArrayPairSum4_BasicTests()
        {
            Assert.AreEqual(1, Solution.ArrayPairSum4(_nums1));
            Assert.AreEqual(1, Solution.ArrayPairSum4(_nums2));
            Assert.AreEqual(4, Solution.ArrayPairSum4(_nums3));
            Assert.AreEqual(9, Solution.ArrayPairSum4(_nums4));
        }
    }
}

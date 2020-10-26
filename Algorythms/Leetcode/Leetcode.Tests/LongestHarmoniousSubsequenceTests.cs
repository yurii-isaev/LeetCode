using Leetcode.LongestHarmoniousSubsequence;
using NUnit.Framework;

namespace Leetcode.Tests
{
    [TestFixture]
    public class LongestHarmoniousSubsequenceTests
    {
        private readonly int[] _nums1 = {1};
        private readonly int[] _nums2 = {2, 1};
        private readonly int[] _nums3 = {1, 1, 1, 1};
        private readonly int[] _nums4 = {1, 2, 3, 4};
        private readonly int[] _nums5 = {1, 3, 2, 2, 5, 2, 3, 7};

        [Test]
        public void FindLhs1_BasicTests()
        {
            Assert.AreEqual(0, Solution.FindLhs1(_nums1));
            Assert.AreEqual(2, Solution.FindLhs1(_nums2));
            Assert.AreEqual(0, Solution.FindLhs1(_nums3));
            Assert.AreEqual(2, Solution.FindLhs1(_nums4));
            Assert.AreEqual(5, Solution.FindLhs1(_nums5));
        }

        [Test]
        public void FindLhs2_BasicTests()
        {
            Assert.AreEqual(0, Solution.FindLhs2(_nums1));
            Assert.AreEqual(2, Solution.FindLhs2(_nums2));
            Assert.AreEqual(0, Solution.FindLhs2(_nums3));
            Assert.AreEqual(2, Solution.FindLhs2(_nums4));
            Assert.AreEqual(5, Solution.FindLhs2(_nums5));
        }

        [Test]
        public void FindLhs3_BasicTests()
        {
            Assert.AreEqual(0, Solution.FindLhs3(_nums1));
            Assert.AreEqual(2, Solution.FindLhs3(_nums2));
            Assert.AreEqual(0, Solution.FindLhs3(_nums3));
            Assert.AreEqual(2, Solution.FindLhs3(_nums4));
            Assert.AreEqual(5, Solution.FindLhs3(_nums5));
        }

        [Test]
        public void FindLhs4_BasicTests()
        {
            Assert.AreEqual(0, Solution.FindLhs4(_nums1));
            Assert.AreEqual(2, Solution.FindLhs4(_nums2));
            Assert.AreEqual(0, Solution.FindLhs4(_nums3));
            Assert.AreEqual(2, Solution.FindLhs4(_nums4));
            Assert.AreEqual(5, Solution.FindLhs4(_nums5));
        }
    }
}

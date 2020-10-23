using Leetcode.DistributeCandies;
using NUnit.Framework;

namespace Leetcode.Tests
{
    [TestFixture]
    public class DistributeCandiesTests
    {
        private readonly int[] _arr1 = {1};
        private readonly int[] _arr2 = {2, 2, 2};
        private readonly int[] _arr3 = {6, 6, 6, 6};
        private readonly int[] _arr4 = {1, 1, 2, 3};
        private readonly int[] _arr5 = {1, 2, 3, 4};
        private readonly int[] _arr6 = {1, 1, 2, 2, 3, 3};

        [Test]
        public void DistributeCandies1_BasicTests()
        {
            Assert.AreEqual(0, Solution.DistributeCandies1(_arr1));
            Assert.AreEqual(1, Solution.DistributeCandies1(_arr2));
            Assert.AreEqual(1, Solution.DistributeCandies1(_arr3));
            Assert.AreEqual(2, Solution.DistributeCandies1(_arr4));
            Assert.AreEqual(2, Solution.DistributeCandies1(_arr5));
            Assert.AreEqual(3, Solution.DistributeCandies1(_arr6));
        }

        [Test]
        public void DistributeCandies2_BasicTests()
        {
            Assert.AreEqual(0, Solution.DistributeCandies2(_arr1));
            Assert.AreEqual(1, Solution.DistributeCandies2(_arr2));
            Assert.AreEqual(1, Solution.DistributeCandies2(_arr3));
            Assert.AreEqual(2, Solution.DistributeCandies2(_arr5));
            Assert.AreEqual(3, Solution.DistributeCandies2(_arr6));
        }

        [Test]
        public void DistributeCandies3_BasicTests()
        {
            Assert.AreEqual(0, Solution.DistributeCandies3(_arr1));
            Assert.AreEqual(1, Solution.DistributeCandies3(_arr2));
            Assert.AreEqual(1, Solution.DistributeCandies3(_arr3));
            Assert.AreEqual(2, Solution.DistributeCandies3(_arr5));
            Assert.AreEqual(3, Solution.DistributeCandies3(_arr6));
        }

        [Test]
        public void DistributeCandies4_BasicTests()
        {
            Assert.AreEqual(0, Solution.DistributeCandies4(_arr1));
            Assert.AreEqual(1, Solution.DistributeCandies4(_arr2));
            Assert.AreEqual(1, Solution.DistributeCandies4(_arr3));
            Assert.AreEqual(2, Solution.DistributeCandies4(_arr5));
            Assert.AreEqual(3, Solution.DistributeCandies4(_arr6));
        }
    }
}

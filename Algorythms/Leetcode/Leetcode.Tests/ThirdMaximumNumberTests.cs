using Leetcode.ThirdMaximumNumber;
using NUnit.Framework;

namespace Leetcode.Tests
{
    [TestFixture]
    public class ThirdMaximumNumberTests
    {
        private readonly int[] _arr = {};
        private readonly int[] _arr1 = {1};
        private readonly int[] _arr2 = {1, 2};
        private readonly int[] _arr3 = {3, 2, 1};
        private readonly int[] _arr4 = {2, 2, 3, 1};

        [Test]
        public void ThirdMax_BasicTests()
        {
            Assert.AreEqual(0, Solution.ThirdMax(_arr));
            Assert.AreEqual(1, Solution.ThirdMax(_arr1));
            Assert.AreEqual(2, Solution.ThirdMax(_arr2));
            Assert.AreEqual(1, Solution.ThirdMax(_arr3));
            Assert.AreEqual(1, Solution.ThirdMax(_arr4));
        }

        [Test]
        public void ThirdMaxByArray_BasicTests()
        {
            Assert.AreEqual(0, Solution.ThirdMaxByArray(_arr));
            Assert.AreEqual(1, Solution.ThirdMaxByArray(_arr1));
            Assert.AreEqual(2, Solution.ThirdMaxByArray(_arr2));
            Assert.AreEqual(1, Solution.ThirdMaxByArray(_arr3));
            Assert.AreEqual(1, Solution.ThirdMaxByArray(_arr4));
        }

        [Test]
        public void ThirdMaxBySortedSet_BasicTests()
        {
            Assert.AreEqual(0, Solution.ThirdMaxBySortedSet(_arr));
            Assert.AreEqual(1, Solution.ThirdMaxBySortedSet(_arr1));
            Assert.AreEqual(2, Solution.ThirdMaxBySortedSet(_arr2));
            Assert.AreEqual(1, Solution.ThirdMaxBySortedSet(_arr3));
            Assert.AreEqual(1, Solution.ThirdMaxBySortedSet(_arr4));
        }

        [Test]
        public void ThirdMaxByLinqSortedSet_BasicTests()
        {
            Assert.AreEqual(0, Solution.ThirdMaxByLinqSortedSet(_arr));
            Assert.AreEqual(1, Solution.ThirdMaxByLinqSortedSet(_arr1));
            Assert.AreEqual(2, Solution.ThirdMaxByLinqSortedSet(_arr2));
            Assert.AreEqual(1, Solution.ThirdMaxByLinqSortedSet(_arr3));
            Assert.AreEqual(1, Solution.ThirdMaxByLinqSortedSet(_arr4));
        }

        [Test]
        public void ThirdMaxByLinq_BasicTests()
        {
            Assert.AreEqual(0, Solution.ThirdMaxByLinq(_arr));
            Assert.AreEqual(1, Solution.ThirdMaxByLinq(_arr1));
            Assert.AreEqual(2, Solution.ThirdMaxByLinq(_arr2));
            Assert.AreEqual(1, Solution.ThirdMaxByLinq(_arr3));
            Assert.AreEqual(1, Solution.ThirdMaxByLinq(_arr4));
        }
    }
}

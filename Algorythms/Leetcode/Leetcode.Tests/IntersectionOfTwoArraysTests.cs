using Leetcode.IntersectionOfTwoArrays;
using NUnit.Framework;

namespace Leetcode.Tests
{
    [TestFixture]
    public class IntersectionOfTwoArraysTests
    {
        private readonly int[] _arr = {1};
        private readonly int[] _arr1 = {1, 2, 2, 1};
        private readonly int[] _arr2 = {2, 2};
        private readonly int[] _expectedArr1 = {2};

        private readonly int[] _arr3 = {4, 9, 5};
        private readonly int[] _arr4 = {9, 4, 9, 8, 4};
        private readonly int[] _expectedArr2 = {4, 9};

        [Test]
        public void IntersectionByList_BasicTests()
        {
            Assert.AreEqual(_arr, Solution.IntersectionByList(_arr, _arr));
            Assert.AreEqual(_expectedArr1, Solution.IntersectionByList(_arr1, _arr2));
            Assert.AreEqual(_expectedArr2, Solution.IntersectionByList(_arr3, _arr4));
        }

        [Test]
        public void IntersectionByHashSet_BasicTests()
        {
            Assert.AreEqual(_arr, Solution.IntersectionByList(_arr, _arr));
            Assert.AreEqual(_expectedArr1, Solution.IntersectionByHashSet(_arr1, _arr2));
            Assert.AreEqual(_expectedArr2, Solution.IntersectionByHashSet(_arr3, _arr4));
        }

        [Test]
        public void IntersectionByLinq_BasicTests()
        {
            Assert.AreEqual(_arr, Solution.IntersectionByList(_arr, _arr));
            Assert.AreEqual(_expectedArr1, Solution.IntersectionByLinq(_arr1, _arr2));
            Assert.AreEqual(_expectedArr2, Solution.IntersectionByLinq(_arr3, _arr4));
        }

        [Test]
        public void IntersectionByLinqIntersect_BasicTests()
        {
            Assert.AreEqual(_arr, Solution.IntersectionByList(_arr, _arr));
            Assert.AreEqual(_expectedArr1, Solution.IntersectionByLinqIntersect(_arr1, _arr2));
            Assert.AreEqual(_expectedArr2, Solution.IntersectionByLinqIntersect(_arr3, _arr4));
        }
    }
}

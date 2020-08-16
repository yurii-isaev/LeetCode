using Leetcode.MajorityElement;
using NUnit.Framework;

namespace Leetcode.Tests
{
    [TestFixture]
    public class MajorityElementTests
    {
        private readonly int[] _arr1 = {};
        private readonly int[] _arr2 = {0};
        private readonly int[] _arr3 = {1};
        private readonly int[] _arr4 = {1, 1};
        private readonly int[] _arr5 = {2, 3, 2};
        private readonly int[] _arr6 = {3, 2, 3};
        private readonly int[] _arr7 = {6, 5, 5};
        private readonly int[] _arr8 = {1, 2, 3, 5, 5, 4};
        private readonly int[] _arr9 = {2, 2, 1, 1, 1, 2, 2};

        [Test]
        public void FindMajorityElementByCount_BasicTests()
        {
            Assert.AreEqual(-1, Solution.FindMajorityElementByCount(_arr1));
            Assert.AreEqual(0, Solution.FindMajorityElementByCount(_arr2));
            Assert.AreEqual(1, Solution.FindMajorityElementByCount(_arr3));
            Assert.AreEqual(1, Solution.FindMajorityElementByCount(_arr4));
            Assert.AreEqual(2, Solution.FindMajorityElementByCount(_arr5));
            Assert.AreEqual(3, Solution.FindMajorityElementByCount(_arr6));
            Assert.AreEqual(5, Solution.FindMajorityElementByCount(_arr7));
            Assert.AreEqual(5, Solution.FindMajorityElementByCount(_arr8));
            Assert.AreEqual(2, Solution.FindMajorityElementByCount(_arr9));
        }

        [Test]
        public void FindMajorityElement_BasicTests()
        {
            Assert.AreEqual(-1, Solution.FindMajorityElement(_arr1));
            Assert.AreEqual(0, Solution.FindMajorityElement(_arr2));
            Assert.AreEqual(1, Solution.FindMajorityElement(_arr3));
            Assert.AreEqual(1, Solution.FindMajorityElement(_arr4));
            Assert.AreEqual(2, Solution.FindMajorityElement(_arr5));
            Assert.AreEqual(3, Solution.FindMajorityElement(_arr6));
            Assert.AreEqual(5, Solution.FindMajorityElement(_arr7));
            Assert.AreEqual(5, Solution.FindMajorityElement(_arr8));
            Assert.AreEqual(2, Solution.FindMajorityElement(_arr9));
        }

        [Test]
        public void FindMajorityElementByLinq_BasicTests()
        {
            Assert.AreEqual(-1, Solution.FindMajorityElementByLinq(_arr1));
            Assert.AreEqual(0, Solution.FindMajorityElementByLinq(_arr2));
            Assert.AreEqual(1, Solution.FindMajorityElementByLinq(_arr3));
            Assert.AreEqual(1, Solution.FindMajorityElementByLinq(_arr4));
            Assert.AreEqual(2, Solution.FindMajorityElementByLinq(_arr5));
            Assert.AreEqual(3, Solution.FindMajorityElementByLinq(_arr6));
            Assert.AreEqual(5, Solution.FindMajorityElementByLinq(_arr7));
            Assert.AreEqual(5, Solution.FindMajorityElementByLinq(_arr8));
            Assert.AreEqual(2, Solution.FindMajorityElementByLinq(_arr9));
        }
    }
}

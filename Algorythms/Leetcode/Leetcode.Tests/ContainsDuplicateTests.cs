using Leetcode.ContainsDuplicate;
using NUnit.Framework;

namespace Leetcode.Tests
{
    [TestFixture]
    public class ContainsDuplicateTests
    {
        private readonly int[] _arr1 = {};
        private readonly int[] _arr2 = {1, 2, 3, 1};
        private readonly int[] _arr3 = {1, 2, 3, 4};
        private readonly int[] _arr4 = {1, 1, 1, 3, 3, 4, 3, 2, 4, 2};

        [Test]
        public void IsContainsDuplicateByForTest_BasicTests()
        {
            Assert.AreEqual(false, Solution.IsContainsDuplicateByFor(_arr1));
            Assert.AreEqual(true, Solution.IsContainsDuplicateByFor(_arr2));
            Assert.AreEqual(false, Solution.IsContainsDuplicateByFor(_arr3));
            Assert.AreEqual(true, Solution.IsContainsDuplicateByFor(_arr4));
        }

        [Test]
        public void IsContainsDuplicateByListTest_BasicTests()
        {
            Assert.AreEqual(false, Solution.IsContainsDuplicateByList(_arr1));
            Assert.AreEqual(true, Solution.IsContainsDuplicateByList(_arr2));
            Assert.AreEqual(false, Solution.IsContainsDuplicateByList(_arr3));
            Assert.AreEqual(true, Solution.IsContainsDuplicateByList(_arr4));
        }

        [Test]
        public void IsContainsDuplicateByHashSetTest_BasicTests()
        {
            Assert.AreEqual(false, Solution.IsContainsDuplicateByHashSet(_arr1));
            Assert.AreEqual(true, Solution.IsContainsDuplicateByHashSet(_arr2));
            Assert.AreEqual(false, Solution.IsContainsDuplicateByHashSet(_arr3));
            Assert.AreEqual(true, Solution.IsContainsDuplicateByHashSet(_arr4));
        }

        [Test]
        public void IsContainsDuplicateByForeachTest_BasicTests()
        {
            Assert.AreEqual(false, Solution.IsContainsDuplicateByForeach(_arr1));
            Assert.AreEqual(true, Solution.IsContainsDuplicateByForeach(_arr2));
            Assert.AreEqual(false, Solution.IsContainsDuplicateByForeach(_arr3));
            Assert.AreEqual(true, Solution.IsContainsDuplicateByForeach(_arr4));
        }

        [Test]
        public void IsContainsDuplicateByLinqTest_BasicTests()
        {
            Assert.AreEqual(false, Solution.IsContainsDuplicateByLinq(_arr1));
            Assert.AreEqual(true, Solution.IsContainsDuplicateByLinq(_arr2));
            Assert.AreEqual(false, Solution.IsContainsDuplicateByLinq(_arr3));
            Assert.AreEqual(true, Solution.IsContainsDuplicateByLinq(_arr4));
        }

        [Test]
        public void IsContainsDuplicateByDictionaryTest_BasicTests()
        {
            Assert.AreEqual(false, Solution.IsContainsDuplicateByDictionary(_arr1));
            Assert.AreEqual(true, Solution.IsContainsDuplicateByDictionary(_arr2));
            Assert.AreEqual(false, Solution.IsContainsDuplicateByDictionary(_arr3));
            Assert.AreEqual(true, Solution.IsContainsDuplicateByDictionary(_arr4));
        }
    }
}

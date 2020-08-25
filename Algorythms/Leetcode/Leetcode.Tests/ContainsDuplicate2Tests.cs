using Leetcode.ContainsDuplicate2;
using NUnit.Framework;

namespace Leetcode.Tests
{
    public class ContainsDuplicate2Tests
    {
        private static readonly int[] Arr1 = {};
        private static readonly int[] Arr2 = {0};
        private static readonly int[] Arr3 = {1};
        private static readonly int[] Arr4 = {1, 1};
        private static readonly int[] Arr5 = {1, 2, 3};
        private static readonly int[] Arr6 = {1, 2, 3, 1};
        private static readonly int[] Arr7 = {1, 2, 3, 4};
        private static readonly int[] Arr8 = {1, 1, 1, 3, 3, 4, 3, 2, 4, 2};

        [Test]
        public void IsContainsDuplicateBySetTest_BasicTests()
        {
            Assert.AreEqual(false, Solution.IsContainsDuplicateBySet(Arr1, 0));
            Assert.AreEqual(false, Solution.IsContainsDuplicateBySet(Arr2, 0));
            Assert.AreEqual(false, Solution.IsContainsDuplicateBySet(Arr3, 1));
            Assert.AreEqual(true, Solution.IsContainsDuplicateBySet(Arr4, 1));
            Assert.AreEqual(true, Solution.IsContainsDuplicateBySet(Arr4, 2));
            Assert.AreEqual(false, Solution.IsContainsDuplicateBySet(Arr5, 1));
            Assert.AreEqual(true, Solution.IsContainsDuplicateBySet(Arr6, 3));
            Assert.AreEqual(false, Solution.IsContainsDuplicateBySet(Arr6, 2));
            Assert.AreEqual(false, Solution.IsContainsDuplicateBySet(Arr7, 1));
            Assert.AreEqual(true, Solution.IsContainsDuplicateBySet(Arr8, 1));
        }

        [Test]
        public void IsContainsDuplicateByDictTest_BasicTests()
        {
            Assert.AreEqual(false, Solution.IsContainsDuplicateByDict(Arr1, 0));
            Assert.AreEqual(false, Solution.IsContainsDuplicateByDict(Arr2, 0));
            Assert.AreEqual(false, Solution.IsContainsDuplicateByDict(Arr3, 1));
            Assert.AreEqual(true, Solution.IsContainsDuplicateByDict(Arr4, 1));
            Assert.AreEqual(true, Solution.IsContainsDuplicateByDict(Arr4, 2));
            Assert.AreEqual(false, Solution.IsContainsDuplicateByDict(Arr5, 1));
            Assert.AreEqual(true, Solution.IsContainsDuplicateByDict(Arr6, 3));
            Assert.AreEqual(false, Solution.IsContainsDuplicateByDict(Arr6, 2));
            Assert.AreEqual(false, Solution.IsContainsDuplicateByDict(Arr7, 1));
            Assert.AreEqual(true, Solution.IsContainsDuplicateByDict(Arr8, 1));
        }
    }
}

using Leetcode.TwoSumLessThanK;
using NUnit.Framework;

namespace Leetcode.Tests
{
    [TestFixture]
    public class GetTwoSumLesThanKTests
    {
        private readonly int[] _arr1 = {};
        private readonly int[] _arr2 = {0};
        private readonly int[] _arr3 = {1, 1};
        private readonly int[] _arr4 = {10, 20, 30};
        private readonly int[] _arr5 = {34, 23, 1, 24, 75, 33, 54, 8};

        [Test]
        public void GetTwoSumLessThanKBy_ShellSort_BasicTests()
        {
            Assert.AreEqual(-1, Solution.GetTwoSumLessThanKByShellSort(_arr1, 0));
            Assert.AreEqual(-1, Solution.GetTwoSumLessThanKByShellSort(_arr2, 0));
            Assert.AreEqual(2, Solution.GetTwoSumLessThanKByShellSort(_arr3, 3));
            Assert.AreEqual(-1, Solution.GetTwoSumLessThanKByShellSort(_arr4, 15));
            Assert.AreEqual(58, Solution.GetTwoSumLessThanKByShellSort(_arr5, 60));
        }

        [Test]
        public void GetTwoSumLessThanKBy_QuickSort_BasicTests()
        {
            Assert.AreEqual(-1, Solution.GetTwoSumLessThanKByQuickSort(_arr1, 0));
            Assert.AreEqual(-1, Solution.GetTwoSumLessThanKByQuickSort(_arr2, 0));
            Assert.AreEqual(2, Solution.GetTwoSumLessThanKByQuickSort(_arr3, 3));
            Assert.AreEqual(-1, Solution.GetTwoSumLessThanKByQuickSort(_arr4, 15));
            Assert.AreEqual(58, Solution.GetTwoSumLessThanKByQuickSort(_arr5, 60));
        }

        [Test]
        public void GetTwoSumLessThanKBy_InsertionSort_BasicTests()
        {
            Assert.AreEqual(-1, Solution.GetTwoSumLessThanKByInsertionSort(_arr1, 0));
            Assert.AreEqual(-1, Solution.GetTwoSumLessThanKByInsertionSort(_arr2, 0));
            Assert.AreEqual(2, Solution.GetTwoSumLessThanKByInsertionSort(_arr3, 3));
            Assert.AreEqual(-1, Solution.GetTwoSumLessThanKByInsertionSort(_arr4, 15));
            Assert.AreEqual(58, Solution.GetTwoSumLessThanKByInsertionSort(_arr5, 60));
        }

        [Test]
        public void GetTwoSumLessThanKBy_MergeSort_BasicTests()
        {
            Assert.AreEqual(-1, Solution.GetTwoSumLessThanKByMergeSort(_arr1, 0));
            Assert.AreEqual(-1, Solution.GetTwoSumLessThanKByMergeSort(_arr2, 0));
            Assert.AreEqual(2, Solution.GetTwoSumLessThanKByMergeSort(_arr3, 3));
            Assert.AreEqual(-1, Solution.GetTwoSumLessThanKByMergeSort(_arr4, 15));
            Assert.AreEqual(58, Solution.GetTwoSumLessThanKByMergeSort(_arr5, 60));
        }

        [Test]
        public void GetTwoSumLessThanKBy_Linq_BasicTests()
        {
            Assert.AreEqual(-1, Solution.GetTwoSumLessThanKByLinq(_arr1, 0));
            Assert.AreEqual(-1, Solution.GetTwoSumLessThanKByLinq(_arr2, 0));
            Assert.AreEqual(2, Solution.GetTwoSumLessThanKByLinq(_arr3, 3));
            Assert.AreEqual(-1, Solution.GetTwoSumLessThanKByLinq(_arr4, 15));
            Assert.AreEqual(58, Solution.GetTwoSumLessThanKByLinq(_arr5, 60));
        }
    }
}

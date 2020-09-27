using Leetcode.FindNumbersDisappearedArray;
using NUnit.Framework;

namespace Leetcode.Tests
{
    [TestFixture]
    public class FindNumbersDisappearedArrayTests
    {
        private readonly int[] _list  = new int[0];
        private readonly int[] _list1 = new[] {4, 3, 2, 7, 8, 2, 3, 1};
        private readonly int[] _list2 = new[] {1, 1};
        private readonly int[] _list3 = new[] {5, 6};
        private readonly int[] _list4 = new[] {2};

        [Test]
        public void FindDisappearedNumbers1_BasicTests()
        {
            Assert.AreEqual(_list, Solution.FindDisappearedNumbers1(_list));
            Assert.AreEqual(_list3, Solution.FindDisappearedNumbers1(_list1));
            Assert.AreEqual(_list4, Solution.FindDisappearedNumbers1(_list2));
        }

        [Test]
        public void FindDisappearedNumbers2_BasicTests()
        {
            Assert.AreEqual(_list, Solution.FindDisappearedNumbers2(_list));
            Assert.AreEqual(_list3, Solution.FindDisappearedNumbers2(_list1));
            Assert.AreEqual(_list4, Solution.FindDisappearedNumbers2(_list2));
        }

        [Test]
        public void FindDisappearedNumbers3_BasicTests()
        {
            Assert.AreEqual(_list, Solution.FindDisappearedNumbers3(_list));
            Assert.AreEqual(_list3, Solution.FindDisappearedNumbers3(_list1));
            Assert.AreEqual(_list4, Solution.FindDisappearedNumbers3(_list2));
        }

        [Test]
        public void FindDisappearedNumbers4_BasicTests()
        {
            Assert.AreEqual(_list, Solution.FindDisappearedNumbers4(_list));
            Assert.AreEqual(_list3, Solution.FindDisappearedNumbers4(_list1));
            Assert.AreEqual(_list4, Solution.FindDisappearedNumbers4(_list2));
        }

        [Test]
        public void FindDisappearedNumbers5_BasicTests()
        {
            Assert.AreEqual(_list, Solution.FindDisappearedNumbers5(_list));
            Assert.AreEqual(_list3, Solution.FindDisappearedNumbers5(_list1));
            Assert.AreEqual(_list4, Solution.FindDisappearedNumbers5(_list2));
        }
    }
}

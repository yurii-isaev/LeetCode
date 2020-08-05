using System.Collections.Generic;
using Leetсode.PascalTriangle2;
using NUnit.Framework;

namespace Leetcode.Tests
{
    [TestFixture]
    public class PascalTriangle2Tests
    {
        private readonly IList<int> _list1 = new List<int> {1};
        private readonly IList<int> _list2 = new List<int> {1, 1};
        private readonly IList<int> _list3 = new List<int> {1, 3, 3, 1};

        [Test]
        public void GenerateByDp_BasicTests()
        {
            Assert.AreEqual(_list1, Solution.GetRow(0));
            Assert.AreEqual(_list2, Solution.GetRow(1));
            Assert.AreEqual(_list3, Solution.GetRow(3));
        }

        [Test]
        public void GetRowByList_BasicTests()
        {
            Assert.AreEqual(_list1, Solution.GetRowByList(0));
            Assert.AreEqual(_list2, Solution.GetRowByList(1));
            Assert.AreEqual(_list3, Solution.GetRowByList(3));
        }

        [Test]
        public void GetRowByDp_BasicTests()
        {
            Assert.AreEqual(_list1, Solution.GetRowByDp(0));
            Assert.AreEqual(_list2, Solution.GetRowByDp(1));
            Assert.AreEqual(_list3, Solution.GetRowByDp(3));
        }

        [Test]
        public void GetRowByRecursion_BasicTests()
        {
            Assert.AreEqual(_list1, Solution.GetRowByRecursion(0));
            Assert.AreEqual(_list2, Solution.GetRowByRecursion(1));
            Assert.AreEqual(_list3, Solution.GetRowByRecursion(3));
        }
    }
}

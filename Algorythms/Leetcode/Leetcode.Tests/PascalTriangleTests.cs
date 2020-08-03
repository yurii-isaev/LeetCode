using System.Collections.Generic;
using Leetсode.PascalTriangle;
using NUnit.Framework;

namespace Leetcode.Tests
{
    [TestFixture]
    public class PascalTriangleTests
    {
        private static readonly IList<IList<int>> ExpectList1 = new List<IList<int>>();
        private static readonly IList<IList<int>> ExpectList2 = new List<IList<int>>{new List<int> {1}};
        private static readonly IList<IList<int>> ExpectList3 = new List<IList<int>>
        {
            new List<int> {1},
            new List<int> {1,1},
            new List<int> {1,2,1},
            new List<int> {1,3,3,1},
            new List<int> {1,4,6,4,1}
        };

        [Test]
        public void GenerateByDP_BasicTests()
        {
            Assert.AreEqual(ExpectList1, Solution.GenerateByDp(0));
            Assert.AreEqual(ExpectList2, Solution.GenerateByDp(1));
            Assert.AreEqual(ExpectList3, Solution.GenerateByDp(5));
        }
        
        [Test]
        public void Generate_BasicTests()
        {
            Assert.AreEqual(ExpectList1, Solution.Generate(0));
            Assert.AreEqual(ExpectList2, Solution.Generate(1));
            Assert.AreEqual(ExpectList3, Solution.Generate(5));
        }
        
        [Test]
        public void GenerateByRecursion_BasicTests()
        {
            Assert.AreEqual(ExpectList1, Solution.GenerateByRecursion(0));
            Assert.AreEqual(ExpectList2, Solution.GenerateByRecursion(1));
            Assert.AreEqual(ExpectList3, Solution.GenerateByRecursion(5));
        }
        
        [Test]
        public void GenerateByList_BasicTests()
        {
            Assert.AreEqual(ExpectList1, Solution.GenerateByList(0));
            Assert.AreEqual(ExpectList2, Solution.GenerateByList(1));
            Assert.AreEqual(ExpectList3, Solution.GenerateByList(5));
        }
    }
}

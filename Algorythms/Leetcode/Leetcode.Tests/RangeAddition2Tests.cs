using Leetcode.RangeAddition2;
using NUnit.Framework;

namespace Leetcode.Tests
{
    [TestFixture]
    public class RangeAddition2Tests
    {
        private readonly int[,] _ops1 = new int[,] {};
        private readonly int[,] _ops21 = new int[,] {{2, 2}, {3, 3}};
        
        private readonly int[,] _ops41 = new int[,]
        {
            {2, 2, 2}, {3, 3, 3}, {4, 4, 4}, {5, 5, 5}
        };

        private readonly int[,] _ops81 = new int[,]
        {
            {2, 2}, {3, 3}, {3, 3}, {3, 3}, {2, 2}, {3, 3}, {3, 3}, {3, 3}, {2, 2}, {3, 3}, {3, 3}, {3, 3}
        };

        private readonly int[][] _ops = {};
        
        private readonly int[][] _ops2 = {new[] {2, 2}, new[] {3, 3}};
        
        private readonly int[][] _ops4 =
        {
            new[] {2, 2}, new[] {3, 3}, new[] {4, 4}, new[] {5, 5}
        };

        private readonly int[][] _ops8 =
        {
            new[] {2, 2}, new[] {3, 3}, new[] {3, 3}, new[] {3, 3}, new[] {2, 2}, new[] {3, 3},
            new[] {3, 3}, new[] {3, 3}, new[] {2, 2}, new[] {3, 3}, new[] {3, 3}, new[] {3, 3}
        };

        [Test]
        public void MaxCount1_BasicTests()
        {
            Assert.AreEqual(9, Solution.MaxCount1(3, 3, _ops));
            Assert.AreEqual(4, Solution.MaxCount1(3, 3, _ops2));
            Assert.AreEqual(4, Solution.MaxCount1(3, 3, _ops4));
            Assert.AreEqual(4, Solution.MaxCount1(3, 3, _ops8));
        }

        [Test]
        public void MaxCount2_BasicTests()
        {
            Assert.AreEqual(9, Solution.MaxCount2(3, 3, _ops));
            Assert.AreEqual(4, Solution.MaxCount2(3, 3, _ops2));
            Assert.AreEqual(4, Solution.MaxCount2(3, 3, _ops4));
            Assert.AreEqual(4, Solution.MaxCount2(3, 3, _ops8));
        }

        [Test]
        public void MaxCount3_BasicTests()
        {
            Assert.AreEqual(9, Solution.MaxCount3(3, 3, _ops1));
            Assert.AreEqual(4, Solution.MaxCount3(3, 3, _ops21));
            Assert.AreEqual(4, Solution.MaxCount3(3, 3, _ops41));
            Assert.AreEqual(4, Solution.MaxCount3(3, 3, _ops81));
        }

        [Test]
        public void MaxCount4_BasicTests()
        {
            Assert.AreEqual(9, Solution.MaxCount4(3, 3, _ops));
            Assert.AreEqual(4, Solution.MaxCount4(3, 3, _ops2));
            Assert.AreEqual(4, Solution.MaxCount4(3, 3, _ops4));
            Assert.AreEqual(4, Solution.MaxCount4(3, 3, _ops8));
        }

        [Test]
        public void MaxCount5_BasicTests()
        {
            Assert.AreEqual(9, Solution.MaxCount5(3, 3, _ops));
            Assert.AreEqual(4, Solution.MaxCount5(3, 3, _ops2));
            Assert.AreEqual(4, Solution.MaxCount5(3, 3, _ops4));
            Assert.AreEqual(4, Solution.MaxCount5(3, 3, _ops8));
        }
    }
}

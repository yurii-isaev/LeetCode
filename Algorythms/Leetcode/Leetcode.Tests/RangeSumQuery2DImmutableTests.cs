using Leetcode.RangeSumQuery2DImmutable;
using NUnit.Framework;

namespace Leetcode.Tests
{
    [TestFixture]
    public class RangeSumQuery2DImmutableTests
    {
        private NumMatrix _instance;
        private int[][] _matrix;

        [SetUp]
        public void Setup()
        {
            _matrix =  new[]
            {
                new[] {3, 0, 1, 4, 2},
                new[] {5, 6, 3, 2, 1},
                new[] {1, 2, 0, 1, 5},
                new[] {4, 1, 0, 1, 7},
                new[] {1, 0, 3, 0, 5}
            };
            
            _instance = new NumMatrix(_matrix);
        }

        [Test]
        public void NumMatrix_SumRegion_BasicTests()
        {
            Assert.AreEqual(8, _instance.SumRegion(2, 1, 4, 3));
            Assert.AreEqual(11, _instance.SumRegion(1, 1, 2, 2));
            Assert.AreEqual(12, _instance.SumRegion(1, 2, 2, 4));
        }

        [Test]
        public void NumMatrixByDp_SumRegion_BasicTests()
        {
            Assert.AreEqual(8, _instance.SumRegion(2, 1, 4, 3));
            Assert.AreEqual(11, _instance.SumRegion(1, 1, 2, 2));
            Assert.AreEqual(12, _instance.SumRegion(1, 2, 2, 4));
        }
    }
}

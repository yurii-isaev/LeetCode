using Leetcode.MaxConsecutiveOnes;
using NUnit.Framework;

namespace Leetcode.Tests
{
    [TestFixture]
    public class MaxConsecutiveOnesTests
    {
        private readonly int[] _grid  = {0};
        private readonly int[] _grid1 = {1};
        private readonly int[] _grid2 = {1, 1, 0, 1, 1};
        private readonly int[] _grid3 = {1, 1, 0, 1, 1, 1};
        private readonly int[] _grid4 = {1, 0, 1, 1, 0, 1};

        [Test]
        public void MaxConsecutiveOnesTests1_BasicTests()
        {
            Assert.AreEqual(0, Solution.FindMaxConsecutiveOnes1(_grid));
            Assert.AreEqual(1, Solution.FindMaxConsecutiveOnes1(_grid1));
            Assert.AreEqual(2, Solution.FindMaxConsecutiveOnes1(_grid2));
            Assert.AreEqual(3, Solution.FindMaxConsecutiveOnes1(_grid3));
            Assert.AreEqual(2, Solution.FindMaxConsecutiveOnes1(_grid4));
        }

        [Test]
        public void MaxConsecutiveOnesTests2_BasicTests()
        {
            Assert.AreEqual(0, Solution.FindMaxConsecutiveOnes2(_grid));
            Assert.AreEqual(1, Solution.FindMaxConsecutiveOnes2(_grid1));
            Assert.AreEqual(2, Solution.FindMaxConsecutiveOnes2(_grid2));
            Assert.AreEqual(3, Solution.FindMaxConsecutiveOnes2(_grid3));
            Assert.AreEqual(2, Solution.FindMaxConsecutiveOnes2(_grid4));
        }

        [Test]
        public void MaxConsecutiveOnesTests3_BasicTests()
        {
            Assert.AreEqual(0, Solution.FindMaxConsecutiveOnes3(_grid));
            Assert.AreEqual(1, Solution.FindMaxConsecutiveOnes3(_grid1));
            Assert.AreEqual(2, Solution.FindMaxConsecutiveOnes3(_grid2));
            Assert.AreEqual(3, Solution.FindMaxConsecutiveOnes3(_grid3));
            Assert.AreEqual(2, Solution.FindMaxConsecutiveOnes3(_grid4));
        }

        [Test]
        public void MaxConsecutiveOnesTests4_BasicTests()
        {
            Assert.AreEqual(0, Solution.FindMaxConsecutiveOnes4(_grid));
            Assert.AreEqual(1, Solution.FindMaxConsecutiveOnes4(_grid1));
            Assert.AreEqual(2, Solution.FindMaxConsecutiveOnes4(_grid2));
            Assert.AreEqual(3, Solution.FindMaxConsecutiveOnes4(_grid3));
            Assert.AreEqual(2, Solution.FindMaxConsecutiveOnes4(_grid4));
        }
    }
}

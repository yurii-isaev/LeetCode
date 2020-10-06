using Leetcode.TeemoAttacking;
using NUnit.Framework;

namespace Leetcode.Tests
{
    [TestFixture]
    public class TeemoAttackingTests
    {
        private readonly int[] _timeSeries  = {0};
        private readonly int[] _timeSeries1 = {1};
        private readonly int[] _timeSeries2 = {1, 0};
        private readonly int[] _timeSeries3 = {1, 1};
        private readonly int[] _timeSeries4 = {1, 2};
        private readonly int[] _timeSeries5 = {1, 4};
        private readonly int[] _timeSeries6 = {1, 2, 4, 5, 6};
        private readonly int[] _timeSeries7 = {1, 2, 4, 5, 6, 8, 10, 15, 19, 24};

        [Test]
        public void FindPoisonedDuration1_BasicTests()
        {
            Assert.AreEqual(0, Solution.FindPoisonedDuration1(_timeSeries, 0));
            Assert.AreEqual(1, Solution.FindPoisonedDuration1(_timeSeries1, 1));
            Assert.AreEqual(1, Solution.FindPoisonedDuration1(_timeSeries2, 2));
            Assert.AreEqual(2, Solution.FindPoisonedDuration1(_timeSeries3, 2));
            Assert.AreEqual(3, Solution.FindPoisonedDuration1(_timeSeries4, 2));
            Assert.AreEqual(4, Solution.FindPoisonedDuration1(_timeSeries5, 2));
            Assert.AreEqual(7, Solution.FindPoisonedDuration1(_timeSeries6, 2));
            Assert.AreEqual(25, Solution.FindPoisonedDuration1(_timeSeries7, 4));
        }
        
        [Test]
        public void FindPoisonedDuration2_BasicTests()
        {
            Assert.AreEqual(0, Solution.FindPoisonedDuration2(_timeSeries, 0));
            Assert.AreEqual(1, Solution.FindPoisonedDuration2(_timeSeries1, 1));
            Assert.AreEqual(1, Solution.FindPoisonedDuration2(_timeSeries2, 2));
            Assert.AreEqual(2, Solution.FindPoisonedDuration2(_timeSeries3, 2));
            Assert.AreEqual(3, Solution.FindPoisonedDuration2(_timeSeries4, 2));
            Assert.AreEqual(4, Solution.FindPoisonedDuration2(_timeSeries5, 2));
            Assert.AreEqual(7, Solution.FindPoisonedDuration2(_timeSeries6, 2));
            Assert.AreEqual(25, Solution.FindPoisonedDuration2(_timeSeries7, 4));
        }
        
        [Test]
        public void FindPoisonedDuration3_BasicTests()
        {
            Assert.AreEqual(0, Solution.FindPoisonedDuration3(_timeSeries, 0));
            Assert.AreEqual(1, Solution.FindPoisonedDuration3(_timeSeries1, 1));
            Assert.AreEqual(1, Solution.FindPoisonedDuration3(_timeSeries2, 2));
            Assert.AreEqual(2, Solution.FindPoisonedDuration3(_timeSeries3, 2));
            Assert.AreEqual(3, Solution.FindPoisonedDuration3(_timeSeries4, 2));
            Assert.AreEqual(4, Solution.FindPoisonedDuration3(_timeSeries5, 2));
            Assert.AreEqual(7, Solution.FindPoisonedDuration3(_timeSeries6, 2));
            Assert.AreEqual(25, Solution.FindPoisonedDuration3(_timeSeries7, 4));
        }
    }
}

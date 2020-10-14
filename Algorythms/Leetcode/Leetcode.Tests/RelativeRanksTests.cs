using Leetcode.RelativeRanks;
using NUnit.Framework;

namespace Leetcode.Tests
{
    [TestFixture]
    public class RelativeRanksTests
    {
        private readonly int[] _scores1 = {5, 4, 3, 2, 1};
        private readonly int[] _scores2 = {10, 3, 8, 9, 4};
        private readonly string[] _ranks1 = {"Gold Medal", "Silver Medal", "Bronze Medal", "4", "5"};
        private readonly string[] _ranks2 = {"Gold Medal", "5", "Bronze Medal", "Silver Medal", "4"};

        [Test]
        public void FindRelativeRanks1_BasicTests()
        {
            Assert.AreEqual(_ranks1, Solution.FindRelativeRanks1(_scores1));
            Assert.AreEqual(_ranks2, Solution.FindRelativeRanks1(_scores2));
        }

        [Test]
        public void FindRelativeRanks2_BasicTests()
        {
            Assert.AreEqual(_ranks1, Solution.FindRelativeRanks2(_scores1));
            Assert.AreEqual(_ranks2, Solution.FindRelativeRanks2(_scores2));
        }

        [Test]
        public void FindRelativeRanks3_BasicTests()
        {
            Assert.AreEqual(_ranks1, Solution.FindRelativeRanks3(_scores1));
            Assert.AreEqual(_ranks2, Solution.FindRelativeRanks3(_scores2));
        }

        [Test]
        public void FindRelativeRanks4_BasicTests()
        {
            Assert.AreEqual(_ranks1, Solution.FindRelativeRanks4(_scores1));
            Assert.AreEqual(_ranks2, Solution.FindRelativeRanks4(_scores2));
        }

        [Test]
        public void FindRelativeRanks5_BasicTests()
        {
            Assert.AreEqual(_ranks1, Solution.FindRelativeRanks5(_scores1));
            Assert.AreEqual(_ranks2, Solution.FindRelativeRanks5(_scores2));
        }
    }
}

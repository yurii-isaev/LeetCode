using Leetcode.SingleNumber;
using NUnit.Framework;

namespace Leetcode.Tests
{
    [TestFixture]
    public class SingleNumberTests
    {
        private readonly int[] _arr1 = {};
        private readonly int[] _arr2 = {0};
        private readonly int[] _arr3 = {1};
        private readonly int[] _arr4 = {1, 1};
        private readonly int[] _arr5 = {2, 2, 1};
        private readonly int[] _arr6 = {1, 1, 2, 2};
        private readonly int[] _arr7 = {4, 1, 2, 1, 2};

        [Test]
        public void SingleNumberByBitwise_BasicTests()
        {
            Assert.AreEqual(0, Solution.SingleNumberByBitwise(_arr1));
            Assert.AreEqual(0, Solution.SingleNumberByBitwise(_arr2));
            Assert.AreEqual(1, Solution.SingleNumberByBitwise(_arr3));
            Assert.AreEqual(0, Solution.SingleNumberByBitwise(_arr4));
            Assert.AreEqual(1, Solution.SingleNumberByBitwise(_arr5));
            Assert.AreEqual(0, Solution.SingleNumberByBitwise(_arr6));
            Assert.AreEqual(4, Solution.SingleNumberByBitwise(_arr7));
        }

        [Test]
        public void SingleNumber_BasicTests()
        {
            Assert.AreEqual(0, Solution.SingleNumber(_arr1));
            Assert.AreEqual(0, Solution.SingleNumber(_arr2));
            Assert.AreEqual(1, Solution.SingleNumber(_arr3));
            Assert.AreEqual(0, Solution.SingleNumber(_arr4));
            Assert.AreEqual(1, Solution.SingleNumber(_arr5));
            Assert.AreEqual(0, Solution.SingleNumber(_arr6));
            Assert.AreEqual(4, Solution.SingleNumber(_arr7));
        }

        [Test]
        public void SingleNumberByLinq_BasicTests()
        {
            Assert.AreEqual(0, Solution.SingleNumberByLinq(_arr1));
            Assert.AreEqual(0, Solution.SingleNumberByLinq(_arr2));
            Assert.AreEqual(1, Solution.SingleNumberByLinq(_arr3));
            Assert.AreEqual(0, Solution.SingleNumberByLinq(_arr4));
            Assert.AreEqual(1, Solution.SingleNumberByLinq(_arr5));
            Assert.AreEqual(0, Solution.SingleNumberByLinq(_arr6));
            Assert.AreEqual(4, Solution.SingleNumberByLinq(_arr7));
        }
    }
}

using Leetcode.MissingNumber;
using NUnit.Framework;

namespace Leetcode.Tests
{
    [TestFixture]
    public class MissingNumberTests
    {
        private readonly int[] _arr2 = {0, 1};
        private readonly int[] _arr3 = {3, 0, 1};
        private readonly int[] _arr9 = {9, 6, 4, 2, 3, 5, 7, 0, 1};

        [Test]
        public void MissingNumber1_BasicTests()
        {
            Assert.AreEqual(2, Solution.MissingNumber1(_arr2));
            Assert.AreEqual(2, Solution.MissingNumber1(_arr3));
            Assert.AreEqual(8, Solution.MissingNumber1(_arr9));
        }

        [Test]
        public void MissingNumber2_BasicTests()
        {
            Assert.AreEqual(2, Solution.MissingNumber2(_arr2));
            Assert.AreEqual(2, Solution.MissingNumber2(_arr3));
            Assert.AreEqual(8, Solution.MissingNumber2(_arr9));
        }

        [Test]
        public void MissingNumber3_BasicTests()
        {
            Assert.AreEqual(2, Solution.MissingNumber3(_arr2));
            Assert.AreEqual(2, Solution.MissingNumber3(_arr3));
            Assert.AreEqual(8, Solution.MissingNumber3(_arr9));
        }

        [Test]
        public void MissingNumber4_BasicTests()
        {
            Assert.AreEqual(2, Solution.MissingNumber4(_arr2));
            Assert.AreEqual(2, Solution.MissingNumber4(_arr3));
            Assert.AreEqual(8, Solution.MissingNumber4(_arr9));
        }

        [Test]
        public void MissingNumberByLinq_BasicTests()
        {
            Assert.AreEqual(2, Solution.MissingNumberByLinq(_arr2));
            Assert.AreEqual(2, Solution.MissingNumberByLinq(_arr3));
            Assert.AreEqual(8, Solution.MissingNumberByLinq(_arr9));
        }
    }
}

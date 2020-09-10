using Leetcode.RangeSumQueryImmutable;
using NUnit.Framework;

namespace Leetcode.Tests
{
    [TestFixture]
    public class RangeSumQueryImmutableTests
    {
        private readonly int[] _arr = {-2, 0, 3, -5, 2, -1};

        [Test]
        public void NumArray_SumRange_BasicTests()
        {
            Assert.AreEqual(1, new NumArray(_arr).SumRange(0, 2));
            Assert.AreEqual(-1, new NumArray(_arr).SumRange(2, 5));
            Assert.AreEqual(-3, new NumArray(_arr).SumRange(0, 5));
        }

        [Test]
        public void NumArray2_SumRange_BasicTests()
        {
            Assert.AreEqual(1, new NumArray2(_arr).SumRange(0, 2));
            Assert.AreEqual(-1, new NumArray2(_arr).SumRange(2, 5));
            Assert.AreEqual(-3, new NumArray2(_arr).SumRange(0, 5));
        }

        [Test]
        public void NumArray3_SumRange_BasicTests()
        {
            Assert.AreEqual(1, new NumArray3(_arr).SumRange(0, 2));
            Assert.AreEqual(-1, new NumArray3(_arr).SumRange(2, 5));
            Assert.AreEqual(-3, new NumArray3(_arr).SumRange(0, 5));
        }

        [Test]
        public void NumArrayByLinq_SumRange_BasicTests()
        {
            Assert.AreEqual(1, new NumArrayByLinq(_arr).SumRange(0, 2));
            Assert.AreEqual(-1, new NumArrayByLinq(_arr).SumRange(2, 5));
            Assert.AreEqual(-3, new NumArrayByLinq(_arr).SumRange(0, 5));
        }

        [Test]
        public void NumArrayByListLinq_SumRange_BasicTests()
        {
            Assert.AreEqual(1, new NumArrayByListLinq(_arr).SumRange(0, 2));
            Assert.AreEqual(-1, new NumArrayByListLinq(_arr).SumRange(2, 5));
            Assert.AreEqual(-3, new NumArrayByListLinq(_arr).SumRange(0, 5));
        }
    }
}

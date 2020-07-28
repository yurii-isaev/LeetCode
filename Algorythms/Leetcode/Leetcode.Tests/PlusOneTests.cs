using Leetcode.PlusOne;
using NUnit.Framework;

namespace Leetcode.Tests
{
    [TestFixture]
    public class PlusOneTests
    {
        [Test]
        public void PlusOne1_BasicTests()
        {
            Assert.AreEqual(new int[] {}, Solution.PlusOne1(new int[] {}));
            Assert.AreEqual(new[] {1}, Solution.PlusOne1(new[] {0}));
            Assert.AreEqual(new[] {1, 0}, Solution.PlusOne1(new[] {9}));
            Assert.AreEqual(new[] {1, 2, 4}, Solution.PlusOne1(new[] {1, 2, 3}));
            Assert.AreEqual(new[] {4, 3, 2, 2}, Solution.PlusOne1(new[] {4, 3, 2, 1}));
        }

        [Test]
        public void PlusOne2_BasicTests()
        {
            Assert.AreEqual(new int[] {}, Solution.PlusOne2(new int[] {}));
            Assert.AreEqual(new[] {1}, Solution.PlusOne2(new[] {0}));
            Assert.AreEqual(new[] {1, 0}, Solution.PlusOne2(new[] {9}));
            Assert.AreEqual(new[] {1, 2, 4}, Solution.PlusOne2(new[] {1, 2, 3}));
            Assert.AreEqual(new[] {4, 3, 2, 2}, Solution.PlusOne2(new[] {4, 3, 2, 1}));
        }

        [Test]
        public void PlusOne3_BasicTests()
        {
            Assert.AreEqual(new int[] {}, Solution.PlusOne3(new int[] {}));
            Assert.AreEqual(new[] {1}, Solution.PlusOne3(new[] {0}));
            Assert.AreEqual(new[] {1, 0}, Solution.PlusOne3(new[] {9}));
            Assert.AreEqual(new[] {1, 2, 4}, Solution.PlusOne3(new[] {1, 2, 3}));
            Assert.AreEqual(new[] {4, 3, 2, 2}, Solution.PlusOne3(new[] {4, 3, 2, 1}));
        }

        [Test]
        public void PlusOneByLinq_BasicTests()
        {
            Assert.AreEqual(new int[] {}, Solution.PlusOneByLinq(new int[] {}));
            Assert.AreEqual(new[] {1}, Solution.PlusOneByLinq(new[] {0}));
            Assert.AreEqual(new[] {1, 0}, Solution.PlusOneByLinq(new[] {9}));
            Assert.AreEqual(new[] {1, 2, 4}, Solution.PlusOneByLinq(new[] {1, 2, 3}));
            Assert.AreEqual(new[] {4, 3, 2, 2}, Solution.PlusOneByLinq(new[] {4, 3, 2, 1}));
        }
    }
}
using Leetcode.RemoveElement;
using NUnit.Framework;

namespace Leetcode.Tests
{
    [TestFixture]
    public class RemoveElementTests
    {
        [Test]
        public void RemoveElementByForeach_BasicTests()
        {
            Assert.AreEqual(0, Solution.RemoveElementByForeach(new int[] {}, 0));
            Assert.AreEqual(0, Solution.RemoveElementByForeach(new[] {0}, 0));
            Assert.AreEqual(1, Solution.RemoveElementByForeach(new[] {0, 1}, 0));
            Assert.AreEqual(2, Solution.RemoveElementByForeach(new[] {3, 2, 2, 3}, 3));
            Assert.AreEqual(5, Solution.RemoveElementByForeach(new[] {0, 1, 2, 2, 3, 0, 4, 2}, 2));
        }

        [Test]
        public void RemoveElementByFor_BasicTests()
        {
            Assert.AreEqual(0, Solution.RemoveElementByFor(new int[] {}, 0));
            Assert.AreEqual(0, Solution.RemoveElementByFor(new[] {0}, 0));
            Assert.AreEqual(1, Solution.RemoveElementByFor(new[] {0, 1}, 0));
            Assert.AreEqual(2, Solution.RemoveElementByFor(new[] {3, 2, 2, 3}, 3));
            Assert.AreEqual(5, Solution.RemoveElementByFor(new[] {0, 1, 2, 2, 3, 0, 4, 2}, 2));
        }

        [Test]
        public void RemoveElementByLinq_BasicTests()
        {
            Assert.AreEqual(0, Solution.RemoveElementByLinq(new int[] {}, 0));
            Assert.AreEqual(0, Solution.RemoveElementByLinq(new[] {0}, 0));
            Assert.AreEqual(1, Solution.RemoveElementByLinq(new[] {0, 1}, 0));
            Assert.AreEqual(2, Solution.RemoveElementByLinq(new[] {3, 2, 2, 3}, 3));
            Assert.AreEqual(5, Solution.RemoveElementByLinq(new[] {0, 1, 2, 2, 3, 0, 4, 2}, 2));
        }
    }
}

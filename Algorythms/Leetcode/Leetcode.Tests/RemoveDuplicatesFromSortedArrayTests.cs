using Leetcode.RemoveDuplicatesFromSortedArray;
using NUnit.Framework;

namespace Leetcode.Tests
{
    [TestFixture]
    public class RemoveDuplicatesFromSortedArrayTests
    {
        [Test]
        public void RemoveDuplicatesByFor_BasicTests()
        {
            Assert.AreEqual(0, Solution.RemoveDuplicatesByFor(new int[] {}));
            Assert.AreEqual(1, Solution.RemoveDuplicatesByFor(new[] {0}));
            Assert.AreEqual(2, Solution.RemoveDuplicatesByFor(new[] {1, 1, 2}));
            Assert.AreEqual(5, Solution.RemoveDuplicatesByFor(new[] {0, 0, 1, 1, 1, 2, 2, 3, 3, 4}));
        }

        [Test]
        public void RemoveDuplicatesByForeach_BasicTests()
        {
            Assert.AreEqual(0, Solution.RemoveDuplicatesByForeach(new int[] {}));
            Assert.AreEqual(1, Solution.RemoveDuplicatesByForeach(new[] {0}));
            Assert.AreEqual(2, Solution.RemoveDuplicatesByForeach(new[] {1, 1, 2}));
            Assert.AreEqual(5, Solution.RemoveDuplicatesByForeach(new[] {0, 0, 1, 1, 1, 2, 2, 3, 3, 4}));
        }

        [Test]
        public void RemoveDuplicatesByHashSet_BasicTests()
        {
            Assert.AreEqual(0, Solution.RemoveDuplicatesByHashSet(new int[] {}));
            Assert.AreEqual(1, Solution.RemoveDuplicatesByHashSet(new[] {0}));
            Assert.AreEqual(2, Solution.RemoveDuplicatesByHashSet(new[] {1, 1, 2}));
            Assert.AreEqual(5, Solution.RemoveDuplicatesByHashSet(new[] {0, 0, 1, 1, 1, 2, 2, 3, 3, 4}));
        }
    }
}

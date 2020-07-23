using Leetcode.SearchInsertPosition;
using NUnit.Framework;

namespace Leetcode.Tests
{
    [TestFixture]
    public class SearchInsertPositionTests
    {
        [Test]
        public void SearchInsert_BasicTests()
        {
            Assert.AreEqual(0, Solution.SearchInsert(new int[] {}, 0));
            Assert.AreEqual(0, Solution.SearchInsert(new[] {0}, 0));
            Assert.AreEqual(1, Solution.SearchInsert(new[] {0}, 1));
            Assert.AreEqual(0, Solution.SearchInsert(new[] {0, 1}, 0));
            Assert.AreEqual(0, Solution.SearchInsert(new[] {1, 3, 5, 6}, 1));
            Assert.AreEqual(2, Solution.SearchInsert(new[] {1, 3, 5, 6}, 5));
            Assert.AreEqual(1, Solution.SearchInsert(new[] {1, 3, 5, 6}, 2));
            Assert.AreEqual(4, Solution.SearchInsert(new[] {1, 3, 5, 6}, 7));
        }

        [Test]
        public void SearchInsertByBinarySearch_BasicTests()
        {
            Assert.AreEqual(0, Solution.SearchInsertByBinarySearch(new int[] {}, 0));
            Assert.AreEqual(0, Solution.SearchInsertByBinarySearch(new[] {0}, 0));
            Assert.AreEqual(1, Solution.SearchInsertByBinarySearch(new[] {0}, 1));
            Assert.AreEqual(0, Solution.SearchInsertByBinarySearch(new[] {0, 1}, 0));
            Assert.AreEqual(0, Solution.SearchInsertByBinarySearch(new[] {1, 3, 5, 6}, 1));
            Assert.AreEqual(2, Solution.SearchInsertByBinarySearch(new[] {1, 3, 5, 6}, 5));
            Assert.AreEqual(1, Solution.SearchInsertByBinarySearch(new[] {1, 3, 5, 6}, 2));
            Assert.AreEqual(4, Solution.SearchInsertByBinarySearch(new[] {1, 3, 5, 6}, 7));
        }

        [Test]
        public void SearchInsertByFor_BasicTests()
        {
            Assert.AreEqual(0, Solution.SearchInsertByFor(new int[] {}, 0));
            Assert.AreEqual(0, Solution.SearchInsertByFor(new[] {0}, 0));
            Assert.AreEqual(1, Solution.SearchInsertByFor(new[] {0}, 1));
            Assert.AreEqual(0, Solution.SearchInsertByFor(new[] {0, 1}, 0));
            Assert.AreEqual(0, Solution.SearchInsertByFor(new[] {1, 3, 5, 6}, 1));
            Assert.AreEqual(2, Solution.SearchInsertByFor(new[] {1, 3, 5, 6}, 5));
            Assert.AreEqual(1, Solution.SearchInsertByFor(new[] {1, 3, 5, 6}, 2));
            Assert.AreEqual(4, Solution.SearchInsertByFor(new[] {1, 3, 5, 6}, 7));
        }

        [Test]
        public void SearchInsertByLinq_BasicTests()
        {
            Assert.AreEqual(0, Solution.SearchInsertByLinq(new int[] {}, 0));
            Assert.AreEqual(0, Solution.SearchInsertByLinq(new[] {0}, 0));
            Assert.AreEqual(1, Solution.SearchInsertByLinq(new[] {0}, 1));
            Assert.AreEqual(0, Solution.SearchInsertByLinq(new[] {0, 1}, 0));
            Assert.AreEqual(0, Solution.SearchInsertByLinq(new[] {1, 3, 5, 6}, 1));
            Assert.AreEqual(2, Solution.SearchInsertByLinq(new[] {1, 3, 5, 6}, 5));
            Assert.AreEqual(1, Solution.SearchInsertByLinq(new[] {1, 3, 5, 6}, 2));
            Assert.AreEqual(4, Solution.SearchInsertByLinq(new[] {1, 3, 5, 6}, 7));
        }
    }
}

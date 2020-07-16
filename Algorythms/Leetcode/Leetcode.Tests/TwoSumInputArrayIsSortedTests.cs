using Leetcode.TwoSumInputArrayIsSorted;
using NUnit.Framework;

namespace Leetcode.Tests
{
    [TestFixture]
    public class TwoSumInputArrayIsSortedTests
    {
        [Test]
        public void GetTwoSumByBinarySearch_BasicTests()
        {
            Assert.AreEqual(
                new int[] {},
                Solution.GetTwoSumByBinarySearch(new int[] {}, 0)
            );

            Assert.AreEqual(
                new int[] {},
                Solution.GetTwoSumByBinarySearch(new[] {0}, 0)
            );

            Assert.AreEqual(
                new[] {1, 2},
                Solution.GetTwoSumByBinarySearch(new[] {-1, 0}, -1)
            );

            Assert.AreEqual(
                new[] {1, 3},
                Solution.GetTwoSumByBinarySearch(new[] {2, 3, 4}, 6)
            );

            Assert.AreEqual(
                new[] {1, 2},
                Solution.GetTwoSumByBinarySearch(new[] {2, 7, 11, 15}, 9)
            );
        }
    }
}

using Leetсode.MergeSortedArray;
using NUnit.Framework;

namespace Leetcode.Tests
{
    [TestFixture]
    public class MergeSortedArrayTests
    {
        [Test]
        public void MergeByWhile_BasicTests()
        {
            Assert.AreEqual(
                new[] {1},
                Solution.MergeByWhile(new[] {0}, 0, new[] {1}, 1)
            );

            Assert.AreEqual(
                new[] {1},
                Solution.MergeByWhile(new[] {1}, 1, new int[] {}, 0)
            );

            Assert.AreEqual(
                new[] {1, 2, 2, 3, 5, 6},
                Solution.MergeByWhile(new[] {1, 2, 3, 0, 0, 0}, 3, new[] {2, 5, 6}, 3)
            );
        }

        [Test]
        public void MergeByFor_BasicTests()
        {
            Assert.AreEqual(
                new[] {1},
                Solution.MergeByFor(new[] {0}, 0, new[] {1}, 1)
            );

            Assert.AreEqual(
                new[] {1},
                Solution.MergeByFor(new[] {1}, 1, new int[] {}, 0)
            );

            Assert.AreEqual(
                new[] {1, 2, 2, 3, 5, 6},
                Solution.MergeByFor(new[] {1, 2, 3, 0, 0, 0}, 3, new[] {2, 5, 6}, 3)
            );
        }

        [Test]
        public void MergeByArray_BasicTests()
        {
            Assert.AreEqual(
                new[] {1},
                Solution.MergeByArray(new[] {0}, 0, new[] {1}, 1)
            );

            Assert.AreEqual(
                new[] {1},
                Solution.MergeByArray(new[] {1}, 1, new int[] {}, 0)
            );

            Assert.AreEqual(
                new[] {1, 2, 2, 3, 5, 6},
                Solution.MergeByArray(new[] {1, 2, 3, 0, 0, 0}, 3, new[] {2, 5, 6}, 3)
            );
        }

        [Test]
        public void MergeByLinq_BasicTests()
        {
            Assert.AreEqual(
                new[] {1},
                Solution.MergeByLinq(new[] {0}, 0, new[] {1}, 1)
            );

            Assert.AreEqual(
                new[] {1},
                Solution.MergeByLinq(new[] {1}, 1, new int[] {}, 0)
            );

            Assert.AreEqual(
                new[] {1, 2, 2, 3, 5, 6},
                Solution.MergeByLinq(new[] {1, 2, 3, 0, 0, 0}, 3, new[] {2, 5, 6}, 3)
            );
        }
    }
}

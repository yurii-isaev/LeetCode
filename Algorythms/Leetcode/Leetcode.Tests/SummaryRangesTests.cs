using System.Collections.Generic;
using Leetcode.SummaryRanges;
using NUnit.Framework;

namespace Leetcode.Tests
{
    [TestFixture]
    public class SummaryRangesTests
    {
        [Test]
        public void SummaryRanges1_BasicTests()
        {
            Assert.AreEqual(
                new List<string> {"0", "2->4", "6", "8->9"},
                Solution.SummaryRanges1(new[] {0, 2, 3, 4, 6, 8, 9})
            );

            Assert.AreEqual(
                    new List<string> {"0->2", "4->5", "7"},
                    Solution.SummaryRanges1(new[] {0, 1, 2, 4, 5, 7}))
                ;

            Assert.AreEqual(
                new List<string> {"0->1", "1", "1->4", "6", "8->9"},
                Solution.SummaryRanges1(new[] {0, 1, 1, 1, 2, 3, 4, 6, 8, 9})
            );
        }

        [Test]
        public void SummaryRanges2_BasicTests()
        {
            Assert.AreEqual(
                new List<string> {"0", "2->4", "6", "8->9"},
                Solution.SummaryRanges2(new[] {0, 2, 3, 4, 6, 8, 9})
            );

            Assert.AreEqual(
                new List<string> {"0->2", "4->5", "7"},
                Solution.SummaryRanges2(new[] {0, 1, 2, 4, 5, 7})
            );

            Assert.AreEqual(
                new List<string> {"0->1", "1", "1->4", "6", "8->9"},
                Solution.SummaryRanges2(new[] {0, 1, 1, 1, 2, 3, 4, 6, 8, 9})
            );
        }
    }
}

using System.Collections.Generic;
using Leetcode.MissingRanges;
using NUnit.Framework;

namespace Leetcode.Tests
{
    [TestFixture]
    public class MissingRangesTests
    {
        private readonly int[] _arr1 = {};
        private readonly int[] _arr2 = {0};
        private readonly int[] _arr3 = {0, 1};
        private readonly int[] _arr4 = {1, 1};
        private readonly int[] _arr5 = {-1};
        private readonly int[] _arr6 = {0, 1, 3, 50, 75};

        [Test]
        public void FindMissingRanges_BasicTests()
        {
            Assert.AreEqual(
                new List<string> {"-1->1"},
                Solution.FindMissingRanges(_arr1, -1, 1)
            );

            Assert.AreEqual(
                new List<string> {"1"},
                Solution.FindMissingRanges(_arr1, 1, 1)
            );

            Assert.AreEqual(
                new List<string> {"-3->-1"},
                Solution.FindMissingRanges(_arr1, -3, -1)
            );

            Assert.AreEqual(
                new List<string> {"1"},
                Solution.FindMissingRanges(_arr2, 0, 1)
            );

            Assert.AreEqual(
                new List<string> {"-1"},
                Solution.FindMissingRanges(_arr3, -1, 1));
            Assert.AreEqual(
                new List<string> {"0"}, Solution.FindMissingRanges(_arr4, 0, 1)
            );

            Assert.AreEqual(
                new List<string>(),
                Solution.FindMissingRanges(_arr5, -1, -1)
            );

            Assert.AreEqual(
                new List<string> {"-2"},
                Solution.FindMissingRanges(_arr5, -2, -1)
            );
            Assert.AreEqual(
                new List<string> {"2", "4->49", "51->74", "76->99"},
                Solution.FindMissingRanges(_arr6, 0, 99)
            );
        }

        [Test]
        public void FindMissingRangesByFun_BasicTests()
        {
            Assert.AreEqual(
                new List<string> {"-1->1"},
                Solution.FindMissingRangesByFun(_arr1, -1, 1)
            );

            Assert.AreEqual(
                new List<string> {"1"},
                Solution.FindMissingRangesByFun(_arr1, 1, 1)
            );

            Assert.AreEqual(
                new List<string> {"-3->-1"},
                Solution.FindMissingRangesByFun(_arr1, -3, -1)
            );

            Assert.AreEqual(
                new List<string> {"1"},
                Solution.FindMissingRangesByFun(_arr2, 0, 1)
            );

            Assert.AreEqual(
                new List<string> {"-1"},
                Solution.FindMissingRangesByFun(_arr3, -1, 1)
            );

            Assert.AreEqual(
                new List<string> {"0"},
                Solution.FindMissingRangesByFun(_arr4, 0, 1)
            );

            Assert.AreEqual(
                new List<string>(),
                Solution.FindMissingRangesByFun(_arr5, -1, -1)
            );

            Assert.AreEqual(
                new List<string> {"-2"},
                Solution.FindMissingRangesByFun(_arr5, -2, -1)
            );

            Assert.AreEqual(
                new List<string> {"2", "4->49", "51->74", "76->99"},
                Solution.FindMissingRangesByFun(_arr6, 0, 99)
            );
        }
    }
}

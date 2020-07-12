using Leetcode.TwoSum;
using NUnit.Framework;

namespace Leetcode.Tests
{
    [TestFixture]
    public class TwoSumTests
    {
        [Test]
        public void GetTwoSum_BasicTests()
        {
            Assert.AreEqual(new int[] {}, Solution.GetTwoSum(new int[] {}, 0));
            Assert.AreEqual(new int[] {}, Solution.GetTwoSum(new[] {0}, 1));
            Assert.AreEqual(new int[] {}, Solution.GetTwoSum(new[] {1, 1, 1}, 3));
            Assert.AreEqual(new[] {0, 1}, Solution.GetTwoSum(new[] {1, 1}, 2));
            Assert.AreEqual(new[] {0, 1}, Solution.GetTwoSum(new[] {2, 7, 11, 15}, 9));
            Assert.AreEqual(new[] {0, 1}, Solution.GetTwoSum(new[] {3, 3}, 6));
            Assert.AreEqual(new[] {1, 2}, Solution.GetTwoSum(new[] {3, 2, 4}, 6));
        }

        [Test]
        public void GetTwoSumByDictionary_BasicTests()
        {
            Assert.AreEqual(new int[] {}, Solution.GetTwoSumByDictionary(new int[] {}, 0));
            Assert.AreEqual(new int[] {}, Solution.GetTwoSumByDictionary(new[] {0}, 1));
            Assert.AreEqual(new int[] {}, Solution.GetTwoSumByDictionary(new[] {1, 1, 1}, 3));
            Assert.AreEqual(new[] {0, 1}, Solution.GetTwoSumByDictionary(new[] {1, 1}, 2));
            Assert.AreEqual(new[] {0, 1}, Solution.GetTwoSumByDictionary(new[] {2, 7, 11, 15}, 9));
            Assert.AreEqual(new[] {0, 1}, Solution.GetTwoSumByDictionary(new[] {3, 3}, 6));
            Assert.AreEqual(new[] {1, 2}, Solution.GetTwoSumByDictionary(new[] {3, 2, 4}, 6));
        }
    }
}

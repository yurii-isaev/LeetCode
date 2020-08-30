using Leetcode.ShortestWordDistance;
using NUnit.Framework;

namespace Leetcode.Tests
{
    [TestFixture]
    public class ShortestWordDistanceTests
    {
        [Test]
        public void ShortestDistance_BasicTests()
        {
            Assert.AreEqual(0, Solution.ShortestDistance(
                new string[] {}, null, null)
            );

            Assert.AreEqual(1, Solution.ShortestDistance(
                new[] {"practice", "makes", "perfect", "coding", "makes"},
                "makes", "practice")
            );

            Assert.AreEqual(3, Solution.ShortestDistance(
                new[] {"practice", "makes", "perfect", "coding", "makes"},
                "practice", "coding")
            );
        }
    }
}

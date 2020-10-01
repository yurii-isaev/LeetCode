using Leetcode.IslandPerimeter;
using NUnit.Framework;

namespace Leetcode.Tests
{
    [TestFixture]
    public class IslandPerimeterTests
    {
        private readonly int[][] _grid1 = {new[] {1}};

        private readonly int[][] _grid2 = {new[] {1, 0}};

        private readonly int[][] _grid4 =
        {
            new[] {0, 1, 0, 0}, new[] {1, 1, 1, 0}, new[] {0, 1, 0, 0}, new[] {1, 1, 0, 0}
        };

        [Test]
        public void IslandPerimeter1_BasicTests()
        {
            Assert.AreEqual(4, Solution.IslandPerimeter1(_grid1));
            Assert.AreEqual(4, Solution.IslandPerimeter1(_grid2));
            Assert.AreEqual(16, Solution.IslandPerimeter1(_grid4));
        }

        [Test]
        public void IslandPerimeter2_BasicTests()
        {
            Assert.AreEqual(4, Solution.IslandPerimeter2(_grid1));
            Assert.AreEqual(4, Solution.IslandPerimeter2(_grid2));
            Assert.AreEqual(16, Solution.IslandPerimeter2(_grid4));
        }
    }
}

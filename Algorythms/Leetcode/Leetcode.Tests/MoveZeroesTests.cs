using Leetcode.MoveZeroes;
using NUnit.Framework;

namespace Leetcode.Tests
{
    [TestFixture]
    public class MoveZeroesTests
    {
        private readonly int[] _arr = {};
        private readonly int[] _arr1 = {0};
        private readonly int[] _arr5 = {0, 1, 0, 3, 12};
        private readonly int[] _arr10 = {9, 6, 4, 0, 3, 5, 7, 0, 1, 0};

        private readonly int[] _expectArr = {};
        private readonly int[] _expectArr5 = {1, 3, 12, 0, 0};
        private readonly int[] _expectArr10 = {9, 6, 4, 3, 5, 7, 1, 0, 0, 0};

        [Test]
        public void MoveZeroes1_BasicTests()
        {
            Assert.AreEqual(_expectArr, Solution.MoveZeroes1(_arr));
            Assert.AreEqual(_arr1, Solution.MoveZeroes1(_arr1));
            Assert.AreEqual(_expectArr5, Solution.MoveZeroes1(_arr5));
            Assert.AreEqual(_expectArr10, Solution.MoveZeroes1(_arr10));
        }

        [Test]
        public void MoveZeroes2_BasicTests()
        {
            Assert.AreEqual(_expectArr, Solution.MoveZeroes1(_arr));
            Assert.AreEqual(_arr1, Solution.MoveZeroes2(_arr1));
            Assert.AreEqual(_expectArr5, Solution.MoveZeroes2(_arr5));
            Assert.AreEqual(_expectArr10, Solution.MoveZeroes2(_arr10));
        }

        [Test]
        public void MoveZeroes3_BasicTests()
        {
            Assert.AreEqual(_expectArr, Solution.MoveZeroes1(_arr));
            Assert.AreEqual(_arr1, Solution.MoveZeroes3(_arr1));
            Assert.AreEqual(_expectArr5, Solution.MoveZeroes3(_arr5));
            Assert.AreEqual(_expectArr10, Solution.MoveZeroes3(_arr10));
        }

        [Test]
        public void MoveZeroes4_BasicTests()
        {
            Assert.AreEqual(_expectArr, Solution.MoveZeroes1(_arr));
            Assert.AreEqual(_arr1, Solution.MoveZeroesByLinq(_arr1));
            Assert.AreEqual(_expectArr5, Solution.MoveZeroesByLinq(_arr5));
            Assert.AreEqual(_expectArr10, Solution.MoveZeroesByLinq(_arr10));
        }
    }
}

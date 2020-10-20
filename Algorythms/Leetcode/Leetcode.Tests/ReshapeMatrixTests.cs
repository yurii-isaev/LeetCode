using Leetcode.ReshapeMatrix;
using NUnit.Framework;

namespace Leetcode.Tests
{
    [TestFixture]
    public class ReshapeMatrixTests
    {
        private readonly int[][] _arr1 =
        {
            new[] {1, 2, 3, 4}
        };
        
        private readonly int[][] _arr2 =
        {
            new[] {1, 2}, new[] {3, 4}
        };

        [Test]
        public void MatrixReshape1_BasicTests()
        {
            Assert.AreEqual(_arr1, Solution.MatrixReshape1(_arr2, 1, 4));
            Assert.AreEqual(_arr2, Solution.MatrixReshape1(_arr2, 2, 4));
        }

        [Test]
        public void MatrixReshape2_BasicTests()
        {
            Assert.AreEqual(_arr1, Solution.MatrixReshape2(_arr2, 1, 4));
            Assert.AreEqual(_arr2, Solution.MatrixReshape2(_arr2, 2, 4));
        }

        [Test]
        public void MatrixReshape3_BasicTests()
        {
            Assert.AreEqual(_arr1, Solution.MatrixReshape3(_arr2, 1, 4));
            Assert.AreEqual(_arr2, Solution.MatrixReshape3(_arr2, 2, 4));
        }

        [Test]
        public void MatrixReshape4_BasicTests()
        {
            Assert.AreEqual(_arr1, Solution.MatrixReshape4(_arr2, 1, 4));
            Assert.AreEqual(_arr2, Solution.MatrixReshape4(_arr2, 2, 4));
        }

        [Test]
        public void MatrixReshape5_BasicTests()
        {
            Assert.AreEqual(_arr1, Solution.MatrixReshape5(_arr2, 1, 4));
            Assert.AreEqual(_arr2, Solution.MatrixReshape5(_arr2, 2, 4));
        }
    }
}

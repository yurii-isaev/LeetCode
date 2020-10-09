using Leetcode.NextGreaterElement;
using NUnit.Framework;

namespace Leetcode.Tests
{
    [TestFixture]
    public class NextGreaterElementTests
    {
        private readonly int[] _arr1 = {4, 1, 2, 2, 6};
        private readonly int[] _arr2 = {1, 3, 4, 2, 6};
        private readonly int[] _arr3 = {4, 1, 2};
        private readonly int[] _arr4 = {1, 3, 4, 2};
        private readonly int[] _arr5 = {2, 4};
        private readonly int[] _arr6 = {1, 2, 3, 4};

        private readonly int[] _expectArr1 = {6, 3, 6, 6, -1};
        private readonly int[] _expectArr2 = {-1, 3, -1};
        private readonly int[] _expectArr3 = {3, -1};

        [Test]
        public void NextGreaterElement1_BasicTests()
        {
            Assert.AreEqual(_expectArr1, Solution.NextGreaterElement1(_arr1, _arr2));
            Assert.AreEqual(_expectArr2, Solution.NextGreaterElement1(_arr3, _arr4));
            Assert.AreEqual(_expectArr3, Solution.NextGreaterElement1(_arr5, _arr6));
        }

        [Test]
        public void NextGreaterElement2_BasicTests()
        {
            Assert.AreEqual(_expectArr1, Solution.NextGreaterElement2(_arr1, _arr2));
            Assert.AreEqual(_expectArr2, Solution.NextGreaterElement2(_arr3, _arr4));
            Assert.AreEqual(_expectArr3, Solution.NextGreaterElement2(_arr5, _arr6));
        }

        [Test]
        public void NextGreaterElement3_BasicTests()
        {
            Assert.AreEqual(_expectArr1, Solution.NextGreaterElement3(_arr1, _arr2));
            Assert.AreEqual(_expectArr2, Solution.NextGreaterElement3(_arr3, _arr4));
            Assert.AreEqual(_expectArr3, Solution.NextGreaterElement3(_arr5, _arr6));
        }

        [Test]
        public void NextGreaterElement4_BasicTests()
        {
            Assert.AreEqual(_expectArr1, Solution.NextGreaterElement4(_arr1, _arr2));
            Assert.AreEqual(_expectArr2, Solution.NextGreaterElement4(_arr3, _arr4));
            Assert.AreEqual(_expectArr3, Solution.NextGreaterElement4(_arr5, _arr6));
        }
    }
}

using Leetcode.IntersectionOfTwoArrays2;
using NUnit.Framework;

namespace Leetcode.Tests
{
    [TestFixture]
    public class IntersectionOfTwoArrays2Tests
    {
        private readonly int[] _arr = new int[0];
        private readonly int[] _arr1 = new[] {1, 2, 2, 1};
        private readonly int[] _arr2 = new[] {2, 2};
        private readonly int[] _expectedArr1 = new[] {2, 2};

        private int[] _arr3 = new[] {4, 9, 5};
        private int[] _arr4 = new[] {9, 4, 9, 8, 4};
        private int[] _expectedArr2 = new[] {4, 9};

        [SetUp]
        public void SetUp()
        {
            _arr3 = new[] {4, 9, 5};
            _arr4 = new[] {9, 4, 9, 8, 4};
            _expectedArr2 = new[] {4, 9};
        }

        [Test]
        public void Intersect_BasicTests()
        {
            Assert.AreEqual(_arr, Solution.Intersect(_arr, _arr));

            Assert.AreEqual(_expectedArr1,
                Solution.Intersect(_arr1, _arr2)
            );

            Assert.AreEqual(_expectedArr2,
                Solution.Intersect(_arr3, _arr4)
            );
        }

        [Test]
        public void IntersectByList_BasicTests()
        {
            Assert.AreEqual(_arr, Solution.Intersect(_arr, _arr));

            Assert.AreEqual(_expectedArr1,
                Solution.IntersectByList(_arr1, _arr2)
            );

            Assert.AreEqual(_expectedArr2,
                Solution.IntersectByList(_arr3, _arr4)
            );
        }

        [Test]
        public void IntersectByLinq_BasicTests()
        {
            Assert.AreEqual(_arr, Solution.Intersect(_arr, _arr));

            Assert.AreEqual(_expectedArr1,
                Solution.IntersectByLinq(_arr1, _arr2)
            );

            Assert.AreEqual(_expectedArr2,
                Solution.IntersectByLinq(_arr3, _arr4)
            );
        }

        [Test]
        public void IntersectByLinqDictionary_BasicTests()
        {
            Assert.AreEqual(_arr, Solution.Intersect(_arr, _arr));

            Assert.AreEqual(_expectedArr1,
                Solution.IntersectByLinqDictionary(_arr1, _arr2)
            );

            Assert.AreEqual(_expectedArr2,
                Solution.IntersectByLinqDictionary(_arr3, _arr4)
            );
        }
    }
}

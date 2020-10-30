using Leetcode.MinimumIndexSumOfTwoLists;
using NUnit.Framework;

namespace Leetcode.Tests
{
    [TestFixture]
    public class MinimumIndexSumOfTwoListsTests
    {
        private readonly string[] _arr1 = {"Shogun", "Tapioca Express", "Burger King", "KFC"};
        private readonly string[] _arr2 = {"Piatti", "The Grill at Torrey Pines", "Hungry Hunter Steakhouse", "Shogun"};
        private readonly string[] _arr3 = {"KFC", "Shogun", "Burger King"};
        private readonly string[] _arr4 = {"happy", "sad", "good"};
        private readonly string[] _arr5 = {"sad", "happy", "good"};

        private readonly string[] _expected1 = {"Shogun"};
        private readonly string[] _expected2 = {"sad", "happy"};

        [Test]
        public void FindRestaurant_BasicTests()
        {
            Assert.AreEqual(_expected1, Solution.FindRestaurant(_arr1, _arr2));
            Assert.AreEqual(_expected1, Solution.FindRestaurant(_arr1, _arr3));
            Assert.AreEqual(_expected2, Solution.FindRestaurant(_arr4, _arr5));
        }
    }
}

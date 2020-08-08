using Leetсode.BestTimeToBuyAndSellStock;
using NUnit.Framework;

namespace Leetcode.Tests
{
    [TestFixture]
    public class BestTimeToBuyAndSellStockTests
    {
        private static int[] _arr1 = {0};
        private static int[] _arr2 = {1};
        private static int[] _arr3 = {3, 3};
        private static int[] _arr4 = {2, 4, 1};
        private static int[] _arr5 = {7, 6, 4, 3, 1};
        private static int[] _arr6 = {7, 1, 5, 3, 6, 4};
        private static int[] _arr7 = {7, 1, 5, 3, 6, 4, 2, 6, 8, 9};
        private static int[] _arr8 = {7, 1, 5, 3, 6, 4, 2, 6, 8, 9, 12, 16, 33, 19, 16, 25, 14, 17, 24, 26};

        [Test]
        public void MaxProfit_BasicTests()
        {
            Assert.AreEqual(0, Solution.MaxProfit(_arr1));
            Assert.AreEqual(0, Solution.MaxProfit(_arr2));
            Assert.AreEqual(0, Solution.MaxProfit(_arr3));
            Assert.AreEqual(2, Solution.MaxProfit(_arr4));
            Assert.AreEqual(0, Solution.MaxProfit(_arr5));
            Assert.AreEqual(5, Solution.MaxProfit(_arr6));
            Assert.AreEqual(8, Solution.MaxProfit(_arr7));
            Assert.AreEqual(32, Solution.MaxProfit(_arr8));
        }

        [Test]
        public void MaxProfitByDP_BasicTests()
        {
            Assert.AreEqual(0, Solution.MaxProfitByDp(_arr1));
            Assert.AreEqual(0, Solution.MaxProfitByDp(_arr2));
            Assert.AreEqual(0, Solution.MaxProfitByDp(_arr3));
            Assert.AreEqual(2, Solution.MaxProfitByDp(_arr4));
            Assert.AreEqual(0, Solution.MaxProfitByDp(_arr5));
            Assert.AreEqual(5, Solution.MaxProfitByDp(_arr6));
            Assert.AreEqual(8, Solution.MaxProfitByDp(_arr7));
            Assert.AreEqual(32, Solution.MaxProfitByDp(_arr8));
        }
    }
}

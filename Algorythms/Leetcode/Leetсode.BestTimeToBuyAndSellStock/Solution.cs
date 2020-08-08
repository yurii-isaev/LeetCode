using System;

namespace Leetсode.BestTimeToBuyAndSellStock
{
    public static class Solution
    {
        /*
         121. Best Time to Buy and Sell Stock (https://leetcode.com/problems/best-time-to-buy-and-sell-stock/).
         
         Description:
         You are given an array prices where prices[i] is the price of a given stock on the ith day.
         You want to maximize your profit by choosing a single day to buy one stock
         and choosing a different day in the future to sell that stock.
         Return the maximum profit you can achieve from this transaction.
         If you cannot achieve any profit, return 0.
         
         Example:
         Input: prices = [7,1,5,3,6,4].
         Output: 5.
         Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
         */

        // ---------------------------------------------------------------------- //

        // Time complexity:  O(n). 
        // Space complexity: O(1).
        // Data input: x ->     performance: 20 ns; memory: _ B.
        // Data input: x * 2 -> performance: 40 ns; memory: _ B.
        public static int MaxProfit(int[] prices)
        {
            if (prices == null || prices.Length == 0) return 0;
            var minPrice = prices[0];
            var profit = 0;

            foreach (var price in prices)
            {
                if (minPrice > price) minPrice = price;
                else if (profit < (price - minPrice)) profit = price - minPrice;
            }

            return profit;
        }

        // Time complexity:  O(n). 
        // Space complexity: O(1).
        // Data input: x ->     performance: 20 ns; memory: _ B.
        // Data input: x * 2 -> performance: 45 ns; memory: _ B.
        public static int MaxProfitByDp(int[] prices)
        {
            if (prices == null || prices.Length == 0) return 0;
            int profit = 0, buy = int.MaxValue;

            foreach (var price in prices)
            {
                buy = Math.Min(buy, price);
                profit = Math.Max(profit, price - buy);
            }

            return profit;
        }
    }
}

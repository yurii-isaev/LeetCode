using System.Collections.Generic;

namespace Leetcode.MinimumIndexSumOfTwoLists
{
    public static class Solution
    {
        /*
         599. Minimum Index Sum Of Two Lists (https://leetcode.com/problems/minimum-index-sum-of-two-lists/):
         
         Description:
         Given two arrays of strings list1 and list2, find the common strings with the least index sum.
         A common string is a string that appeared in both list1 and list2.
         A common string with the least index sum is a common string such that if it appeared at list1[i] and list2[j]
         then i + j should be the minimum value among all the other common strings.
         Return all the common strings with the least index sum. Return the answer in any order.
         
         Example 1:
         Input:
         list1 = ["Shogun","Tapioca Express","Burger King","KFC"],
         list2 = ["Piatti","The Grill at Torrey Pines","Hungry Hunter Steakhouse","Shogun"]
         Output: ["Shogun"]
         Explanation: The only common string is "Shogun".
         
         Example 2:
         Input: list1 = ["Shogun","Tapioca Express","Burger King","KFC"], list2 = ["KFC","Shogun","Burger King"]
         Output: ["Shogun"]
         Explanation: The common string with the least index sum is "Shogun" with index sum = (0 + 1) = 1.
         
         Example 3:
         Input: list1 = ["happy","sad","good"], list2 = ["sad","happy","good"]
         Output: ["sad","happy"]
         Explanation: There are three common strings:
         "happy" with index sum = (0 + 1) = 1.
         "sad" with index sum = (1 + 0) = 1.
         "good" with index sum = (2 + 2) = 4.
         The strings with the least index sum are "sad" and "happy".
        */

        // ---------------------------------------------------------------------- //
        
        // Time complexity:  O(n). 
        // Space complexity: O(n).
        // Data input: x ->     performance: 500 ns; memory: 608 B.
        // Data input: x * 2 -> performance: 800 ns; memory: 616 B.
        // Data input: x * 4 -> performance: 1.3 us; memory: 608 B.
        public static string[] FindRestaurant(string[] list1, string[] list2)
        {
            var list = new List<string>();
            var sum = int.MaxValue;
            var dict = new Dictionary<string, int>();

            for (var i = 0; i < list1.Length; i++) dict[list1[i]] = i;

            for (var j = 0; j < list2.Length; j++)
            {
                if (dict.ContainsKey(list2[j]))
                {
                    var idx = dict[list2[j]];

                    if (j + idx < sum)
                    {
                        sum = j + idx;
                        list = new List<string>() { list2[j] };
                    }
                    else if (j + idx == sum)
                    {
                        list.Add(list2[j]);
                    }
                }
            }

            return list.ToArray();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace Leetcode.RelativeRanks
{
    public static class Solution
    {
        /*
         506. Relative Ranks (https://leetcode.com/problems/relative-ranks/):
         
         Description:
         You are given an integer array score of size n,
         where score[i] is the score of the ith athlete in a competition.
         All the scores are guaranteed to be unique.
         
         The athletes are placed based on their scores, where the 1st place athlete has the highest score,
         the 2nd place athlete has the 2nd highest score, and so on.
         The placement of each athlete determines their rank:
         
         The 1st place athlete's rank is "Gold Medal".
         The 2nd place athlete's rank is "Silver Medal".
         The 3rd place athlete's rank is "Bronze Medal".
         For the 4th place to the nth place athlete,
         their rank is their placement number (i.e., the xth place athlete's rank is "x").
         Return an array answer of size n where answer[i] is the rank of the ith athlete.
         
         Example:
         Input: score = [5,4,3,2,1].
         Output: ["Gold Medal","Silver Medal","Bronze Medal","4","5"].
         
         ---------------------------------
         Explanation:
         The placements are [1st, 2nd, 3rd, 4th, 5th].
         */

        // ---------------------------------------------------------------------- //
        
        // Time complexity:  O(n).
        // Space complexity: O(n).
        // Data input: x ->     performance: 200 ns; memory: 112 В.
        // Data input: x * 2 -> performance: 420 ns; memory: 200 В.
        // Data input: x * 4 -> performance:   1 us; memory: 688 В.
        public static string[] FindRelativeRanks1(int[] nums)
        {
            var copy = new int[nums.Length];
            nums.CopyTo(copy, 0);
            var results = new string[nums.Length];
            Array.Sort(copy);
            var count = 1;

            for (var i = copy.Length - 1; i >= 0; i--)
            {
                if (count == 1)
                {
                    results[GetIndex(nums, copy[i])] = "Gold Medal";
                }
                else if (count == 2)
                {
                    results[GetIndex(nums, copy[i])] = "Silver Medal";
                }
                else if (count == 3)
                {
                    results[GetIndex(nums, copy[i])] = "Bronze Medal";
                }
                else
                {
                    results[GetIndex(nums, copy[i])] = (nums.Length - i).ToString();
                }

                count += 1;
            }

            return results;
        }

        public static int GetIndex(int[] nums, int n)
        {
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] == n) return i;
            }

            return -1;
        }

        // Time complexity:  O(n).
        // Space complexity: O(n).
        // Data input: x ->     performance: 290 ns; memory: 192 В.
        // Data input: x * 2 -> performance: 540 ns; memory: 296 В.
        // Data input: x * 4 -> performance: 1.1 us; memory: 800 В.
        public static string[] FindRelativeRanks2(int[] score)
        {
            var sorted = new int[score.Length];
            Array.Copy(score, sorted, score.Length);
            Array.Sort(sorted);
            Array.Reverse(sorted);
            var sortedL = sorted.ToList();
            var result = new string[score.Length];

            for (var r = 0; r < score.Length; r++)
            {
                var i = sortedL.IndexOf(score[r]);
                string m;

                if (i == 0) m = "Gold Medal";
                else if (i == 1) m = "Silver Medal";
                else if (i == 2) m = "Bronze Medal";
                else m = (i + 1).ToString();

                result[r] = m;
            }

            return result;
        }

        // Time complexity:  O(n).
        // Space complexity: O(n).
        // Data input: x ->     performance: 180 ns; memory: 128 В.
        // Data input: x * 2 -> performance: 500 ns; memory: 240 В.
        // Data input: x * 4 -> performance: 1.5 us; memory: 768 В.
        public static string[] FindRelativeRanks3(int[] nums)
        {
            var data = new (int score, int idx)[nums.Length];
            for (var i = 0; i < nums.Length; i++)
            {
                data[i] = (nums[i], i);
            }

            Array.Sort(data, (d1, d2) => d2.score.CompareTo(d1.score));
            
            var res = new string[nums.Length];
            for (var i = 0; i < nums.Length; i++)
            {
                if (i == 0)
                {
                    res[data[i].idx] = "Gold Medal";
                    continue;
                }

                if (i == 1)
                {
                    res[data[i].idx] = "Silver Medal";
                    continue;
                }

                if (i == 2)
                {
                    res[data[i].idx] = "Bronze Medal";
                    continue;
                }

                res[data[i].idx] = (i + 1).ToString();
            }

            return res;
        }

        // Time complexity:  O(n).
        // Space complexity: O(n).
        // Data input: x ->     performance: 370 ns; memory: 376 В.
        // Data input: x * 2 -> performance: 680 ns; memory: 544 В.
        // Data input: x * 4 -> performance: 1.4 us; memory: 1240 В.
        public static string[] FindRelativeRanks4(int[] nums)
        {
            var ordered = (int[])nums.Clone();
            Array.Sort(ordered);
            var len = nums.Length;

            var numToRank = new Dictionary<int, int>(len);
            for (var i = 0; i < len; i++)
            {
                numToRank[ordered[i]] = len - i;
            }

            var results = new string[len];
            for (var i = 0; i < len; i++)
            {
                var rank = numToRank[nums[i]];
                results[i] =
                    rank > 3 ? rank.ToString() :
                    rank == 3 ? "Bronze Medal" :
                    rank == 2 ? "Silver Medal" : "Gold Medal";
            }

            return results;
        }

        // Time complexity:  O(n).
        // Space complexity: O(n).
        // Data input: x ->     performance: 520 ns; memory: 688 В.
        // Data input: x * 2 -> performance:   1 us; memory: 824 В.
        // Data input: x * 4 -> performance: 2.2 us; memory: 1424 В.
        public static string[] FindRelativeRanks5(int[] score)
        {
            var scores = score.OrderByDescending(x => x).ToList();
            
            return score.Select(x =>
            {
                if (x == scores[0]) return "Gold Medal";
                if (x == scores[1]) return "Silver Medal";
                if (x == scores[2]) return "Bronze Medal";
                return (scores.IndexOf(x) + 1).ToString();
            }).ToArray();
        }
    }
}

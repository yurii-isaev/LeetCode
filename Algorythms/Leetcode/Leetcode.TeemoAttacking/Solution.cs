using System;

namespace Leetcode.TeemoAttacking
{
    public static class Solution
    {
        /*
         495. Teemo Attacking (https://leetcode.com/problems/teemo-attacking/):
         
         Description:
         Our hero Teemo is attacking an enemy Ashe with poison attacks!
         When Teemo attacks Ashe, Ashe gets poisoned for a exactly duration seconds.
         More formally, an attack at second t will mean Ashe is poisoned during
         the inclusive time interval [t, t + duration - 1].
         If Teemo attacks again before the poison effect ends,
         the timer for it is reset, and the poison effect will end duration seconds after the new attack.
         
         You are given a non-decreasing integer array timeSeries,
         where timeSeries[i] denotes that Teemo attacks Ashe at second timeSeries[i], and an integer duration.
         
         Return the total number of seconds that Ashe is poisoned.
         
         Example:
         Explanation:
         Input: timeSeries = [1,4], duration = 2.
         Output: 4.
         
         ---------------------------------
         Explanation:
          Teemo's attacks on Ashe go as follows:
         - At second 1, Teemo attacks, and Ashe is poisoned for seconds 1 and 2.
         - At second 4, Teemo attacks, and Ashe is poisoned for seconds 4 and 5.
         Ashe is poisoned for seconds 1, 2, 4, and 5, which is 4 seconds in total.
         */

        // ---------------------------------------------------------------------- //

        // Time complexity:  O(n).
        // Space complexity: O(1).
        // Data input: x ->     performance: 10 ns; memory: _ В.
        // Data input: x * 2 -> performance: 15 ns; memory: _ В. 
        // Data input: x * 4 -> performance: 45 ns; memory: _ В. 
        public static int FindPoisonedDuration1(int[] timeSeries, int duration)
        {
            int cnt = 0, end = 0;

            foreach (var x in timeSeries)
            {
                cnt += end > x ? duration - (end - x) : duration;
                end = x + duration;
            }

            return cnt;
        }

        // Time complexity:  O(n).
        // Space complexity: O(1).
        // Data input: x ->     performance: 10 ns; memory: _ В.
        // Data input: x * 2 -> performance: 18 ns; memory: _ В.
        // Data input: x * 4 -> performance: 50 ns; memory: _ В.
        public static int FindPoisonedDuration2(int[] timeSeries, int duration)
        {
            int last = -1, cnt = 0, now;

            foreach (var i in timeSeries)
            {
                now = i - 1 + duration;

                if (i <= last)
                {
                    cnt += now - last;
                }
                else
                {
                    cnt += duration;
                }

                last = now;
            }

            return cnt;
        }

        // Time complexity:  O(n).
        // Space complexity: O(1).
        // Data input: x ->     performance: 10 ns; memory: _ В.
        // Data input: x * 2 -> performance: 20 ns; memory: _ В.
        // Data input: x * 4 -> performance: 50 ns; memory: _ В.
        public static int FindPoisonedDuration3(int[] timeSeries, int duration)
        {
            var t = 0;

            for (var i = 1; i < timeSeries.Length; i++)
            {
                t += Math.Min(timeSeries[i] - timeSeries[i - 1], duration);
            }

            return timeSeries.Length == 0 ? 0 : t + duration;
        }
    }
}

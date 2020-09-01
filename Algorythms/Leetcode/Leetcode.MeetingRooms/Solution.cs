using System;

namespace Leetcode.MeetingRooms
{
    public static class Solution
    {
        /*
       252. Meeting Rooms (https://leetcode.com/problems/meeting-rooms/):
       
       Description:
       Given an array of meeting timeslots where intervals[i] = [starti, endi],
       determine if a person can attend all meetings.
       
       Example:
       Input: intervals = [[0,30],[5,10],[15,20]].
       Output: false.
       */
        
        // ---------------------------------------------------------------------- //

        // Time complexity:  O(n). 
        // Space complexity: O(n).
        // Data input: x ->     performance: 100 ns; memory: 80 B.
        // Data input: x * 2 -> performance: 140 us; memory: 96 B.
        public static bool CanAttendMeetings1(int[][] intervals)
        {
            var len = intervals.Length;
            var start = new int[len];
            var end = new int[len];
            var count = 0;

            for (var i = 0; i < len; i++)
            {
                start[count] = intervals[i][0];
                end[count++] = intervals[i][1];
            }

            Array.Sort(start);
            Array.Sort(end);

            for (var j = 1; j < len; j++)
            {
                if (start[j] < end[j - 1]) return false;
            }

            return true;
        }

        // Time complexity:  O(n). 
        // Space complexity: O(n).
        // Data input: x ->     performance: 110 ns; memory: 80 B.
        // Data input: x * 2 -> performance: 160 us; memory: 96 B.
        public static int CanAttendMeetings2(int[][] intervals)
        {
            var len = intervals.Length;
            var start = new int[len];
            var end = new int[len];

            for (var i = 0; i < len; i++)
            {
                start[i] = intervals[i][0];
                end[i] = intervals[i][1];
            }

            Array.Sort(start);
            Array.Sort(end);

            int k = 1, j = 0, curr = 1, result = 1;

            while (k < start.Length && j < end.Length)
            {
                if (start[k] < end[j])
                {
                    curr++;
                    k++;
                }
                else
                {
                    curr--;
                    j++;
                }

                result = Math.Max(result, curr);
            }

            return result;
        }
    }
}

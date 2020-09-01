using BenchmarkDotNet.Attributes;

namespace Leetcode.MeetingRooms
{
    [MemoryDiagnoser]
    [RankColumn]
    public class Benchmark
    {
        private readonly int[][] _intervals3 =
        {
            new[] {0, 30}, new[] {5, 10}, new[] {15, 20}
        };

        private readonly int[][] _intervals6 =
        {
            new[] {0, 30}, new[] {5, 10}, new[] {15, 20}, new[] {1, 5}, new[] {5, 20}, new[] {15, 40}
        };

        [Benchmark]
        public void Test_CanAttendMeetings_1() => Solution.CanAttendMeetings1(_intervals3);

        [Benchmark]
        public void Test_CanAttendMeetings_2() => Solution.CanAttendMeetings1(_intervals6);

        [Benchmark]
        public void Test_CanAttendMeetings_3() => Solution.CanAttendMeetings2(_intervals3);

        [Benchmark]
        public void Test_CanAttendMeetings_4() => Solution.CanAttendMeetings2(_intervals6);
    }
}

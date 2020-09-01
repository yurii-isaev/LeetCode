using BenchmarkDotNet.Running;

namespace Leetcode.MeetingRooms
{
    public static class Program
    {
        private static void Main() => BenchmarkRunner.Run<Benchmark>();
    }
}

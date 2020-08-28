using BenchmarkDotNet.Running;

namespace Leetcode.SummaryRanges
{
    public static class Program
    {
        private static void Main() => BenchmarkRunner.Run<Benchmark>();
    }
}

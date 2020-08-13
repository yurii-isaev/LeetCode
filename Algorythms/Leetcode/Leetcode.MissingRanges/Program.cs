using BenchmarkDotNet.Running;

namespace Leetcode.MissingRanges
{
    public static class Program
    {
        private static void Main() => BenchmarkRunner.Run<Benchmark>();
    }
}

using BenchmarkDotNet.Running;

namespace Leetcode.RangeSumQueryImmutable
{
    public static class Program
    {
        private static void Main() => BenchmarkRunner.Run<Benchmark>();
    }
}

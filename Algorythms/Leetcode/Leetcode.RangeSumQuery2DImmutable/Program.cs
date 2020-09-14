using BenchmarkDotNet.Running;

namespace Leetcode.RangeSumQuery2DImmutable
{
    public static class Program
    {
        private static void Main() => BenchmarkRunner.Run<Benchmark>();
    }
}

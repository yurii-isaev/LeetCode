using BenchmarkDotNet.Running;

namespace Leetcode.MaximumSubarray
{
    public static class Program
    {
        private static void Main() => BenchmarkRunner.Run<Benchmark>();
    }
}

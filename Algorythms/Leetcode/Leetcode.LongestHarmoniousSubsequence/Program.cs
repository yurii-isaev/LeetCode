using BenchmarkDotNet.Running;

namespace Leetcode.LongestHarmoniousSubsequence
{
    public static class Program
    {
        private static void Main() => BenchmarkRunner.Run<Benchmark>();
    }
}

using BenchmarkDotNet.Running;

namespace Leetcode.RelativeRanks
{
    public static class Program
    {
        private static void Main() => BenchmarkRunner.Run<Benchmark>();
    }
}

using BenchmarkDotNet.Running;

namespace Leetcode.MinimumIndexSumOfTwoLists
{
    public static class Program
    {
        private static void Main() => BenchmarkRunner.Run<Benchmark>();
    }
}
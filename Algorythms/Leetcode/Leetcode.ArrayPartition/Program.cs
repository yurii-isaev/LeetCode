using BenchmarkDotNet.Running;

namespace Leetcode.ArrayPartition
{
    public static class Program
    {
        private static void Main() => BenchmarkRunner.Run<Benchmark>();
    }
}

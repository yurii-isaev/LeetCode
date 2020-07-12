using BenchmarkDotNet.Running;

namespace Leetcode.TwoSum
{
    public static class Program
    {
        private static void Main() => BenchmarkRunner.Run<Benchmark>();
    }
}

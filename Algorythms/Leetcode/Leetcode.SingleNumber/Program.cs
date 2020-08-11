using BenchmarkDotNet.Running;

namespace Leetcode.SingleNumber
{
    public static class Program
    {
        private static void Main() => BenchmarkRunner.Run<Benchmark>();
    }
}

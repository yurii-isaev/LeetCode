using BenchmarkDotNet.Running;

namespace Leetcode.MissingNumber
{
    public static class Program
    {
        private static void Main() => BenchmarkRunner.Run<Benchmark>();
    }
}

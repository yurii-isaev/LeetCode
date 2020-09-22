using BenchmarkDotNet.Running;

namespace Leetcode.ThirdMaximumNumber
{
    public static class Program
    {
        private static void Main() => BenchmarkRunner.Run<Benchmark>();
    }
}

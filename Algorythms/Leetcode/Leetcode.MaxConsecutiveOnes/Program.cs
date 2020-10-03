using BenchmarkDotNet.Running;

namespace Leetcode.MaxConsecutiveOnes
{
    public static class Program
    {
        private static void Main() => BenchmarkRunner.Run<Benchmark>();
    }
}

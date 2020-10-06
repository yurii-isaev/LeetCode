using BenchmarkDotNet.Running;

namespace Leetcode.TeemoAttacking
{
    public static class Program
    {
        private static void Main() => BenchmarkRunner.Run<Benchmark>();
    }
}    
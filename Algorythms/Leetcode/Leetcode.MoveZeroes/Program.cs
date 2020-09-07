using BenchmarkDotNet.Running;

namespace Leetcode.MoveZeroes
{
    public static class Program
    {
        private static void Main() => BenchmarkRunner.Run<Benchmark>();
    }
}

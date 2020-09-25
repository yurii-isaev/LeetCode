using BenchmarkDotNet.Running;

namespace Leetcode.ValidWordSquare
{
    public static class Program
    {
        private static void Main() => BenchmarkRunner.Run<Benchmark>();
    }
}

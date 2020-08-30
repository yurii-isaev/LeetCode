using BenchmarkDotNet.Running;

namespace Leetcode.ShortestWordDistance
{
    public static class Program
    {
        private static void Main() => BenchmarkRunner.Run<Benchmark>();
    }
}

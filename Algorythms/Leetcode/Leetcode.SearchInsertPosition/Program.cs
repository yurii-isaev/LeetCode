using BenchmarkDotNet.Running;

namespace Leetcode.SearchInsertPosition
{
    public static class Program
    {
        private static void Main() => BenchmarkRunner.Run<Benchmark>();
    }
}

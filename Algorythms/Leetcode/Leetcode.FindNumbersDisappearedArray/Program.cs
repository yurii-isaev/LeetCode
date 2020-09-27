using BenchmarkDotNet.Running;

namespace Leetcode.FindNumbersDisappearedArray
{
    public static class Program
    {
        private static void Main() => BenchmarkRunner.Run<Benchmark>();
    }
}

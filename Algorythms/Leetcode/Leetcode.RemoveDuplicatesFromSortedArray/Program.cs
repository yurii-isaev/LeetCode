using BenchmarkDotNet.Running;

namespace Leetcode.RemoveDuplicatesFromSortedArray
{
    public static class Program
    {
        private static void Main() => BenchmarkRunner.Run<Benchmark>();
    }
}

using BenchmarkDotNet.Running;

namespace Leetcode.TwoSumInputArrayIsSorted
{
    public static class Program
    {
        private static void Main() => BenchmarkRunner.Run<Benchmark>();
    }
}

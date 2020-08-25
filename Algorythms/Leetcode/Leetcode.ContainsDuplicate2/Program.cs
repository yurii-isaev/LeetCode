using BenchmarkDotNet.Running;

namespace Leetcode.ContainsDuplicate2
{
    public static class Program
    {
        private static void Main() => BenchmarkRunner.Run<Benchmark>();
    }
}

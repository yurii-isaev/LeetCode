using BenchmarkDotNet.Running;

namespace Leetcode.IntersectionOfTwoArrays
{
    public static class Program
    {
        private static void Main() => BenchmarkRunner.Run<Benchmark>();
    }
}

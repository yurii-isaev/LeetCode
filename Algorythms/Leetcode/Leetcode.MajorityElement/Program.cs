using BenchmarkDotNet.Running;

namespace Leetcode.MajorityElement
{
    public static class Program
    {
        private static void Main() => BenchmarkRunner.Run<Benchmark>();
    }
}

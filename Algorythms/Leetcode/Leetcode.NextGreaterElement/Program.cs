using BenchmarkDotNet.Running;

namespace Leetcode.NextGreaterElement
{
    public static class Program
    {
        private static void Main() => BenchmarkRunner.Run<Benchmark>();
    }
}

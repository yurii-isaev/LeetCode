using BenchmarkDotNet.Running;

namespace Leetcode.RemoveElement
{
    public static class Program
    {
        private static void Main() => BenchmarkRunner.Run<Benchmark>();
    }
}

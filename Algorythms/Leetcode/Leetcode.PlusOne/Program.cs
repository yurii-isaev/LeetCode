using BenchmarkDotNet.Running;

namespace Leetcode.PlusOne
{
    public static class Program
    {
        private static void Main() => BenchmarkRunner.Run<Benchmark>();
    }
}

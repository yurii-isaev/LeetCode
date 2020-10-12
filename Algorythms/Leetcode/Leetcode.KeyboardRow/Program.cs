using BenchmarkDotNet.Running;

namespace Leetcode.KeyboardRow
{
    public static class Program
    {
        private static void Main() => BenchmarkRunner.Run<Benchmark>();
    }
}

using BenchmarkDotNet.Running;

namespace Leetcode.AssignCookies
{
    public static class Program
    {
        private static void Main() => BenchmarkRunner.Run<Benchmark>();
    }
}

using BenchmarkDotNet.Running;

namespace Leetсode.PascalTriangle2
{
    public static class Program
    {
        private static void Main() => BenchmarkRunner.Run<Benchmark>();
    }
}

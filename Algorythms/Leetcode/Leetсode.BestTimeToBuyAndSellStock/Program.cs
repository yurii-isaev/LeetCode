using BenchmarkDotNet.Running;

namespace Leetсode.BestTimeToBuyAndSellStock
{
    public static class Program
    {
        private static void Main() => BenchmarkRunner.Run<Benchmark>();
    }
}

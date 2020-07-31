using BenchmarkDotNet.Running;

namespace Leetсode.MergeSortedArray
{
    public static class Program
    {
        private static void Main() => BenchmarkRunner.Run<Benchmark>();
    }
}

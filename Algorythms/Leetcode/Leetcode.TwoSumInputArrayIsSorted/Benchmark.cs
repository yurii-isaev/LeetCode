using BenchmarkDotNet.Attributes;

namespace Leetcode.TwoSumInputArrayIsSorted
{
    [MemoryDiagnoser]
    [RankColumn]
    public class Benchmark
    {
        private readonly int[] _arr10 =
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10
        };

        private readonly int[] _arr20 =
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 14, 18, 19, 20
        };

        [Benchmark]
        public void Test_GetTwoSumByBinarySearch_1()
        {
            Solution.GetTwoSumByBinarySearch(_arr10, 6);
        }

        [Benchmark]
        public void Test_GetTwoSumByBinarySearch_2()
        {
            Solution.GetTwoSumByBinarySearch(_arr20, 30);
        }
    }
}

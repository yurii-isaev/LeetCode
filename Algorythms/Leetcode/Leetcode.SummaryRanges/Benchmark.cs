using BenchmarkDotNet.Attributes;

namespace Leetcode.SummaryRanges
{
    [MemoryDiagnoser]
    [RankColumn]
    public class Benchmark
    {
        private readonly int[] _arr1 =
        {
            0, 1, 1, 1, 2, 3, 4, 6, 8, 9
        };

        private readonly int[] _arr2 =
        {
            0, 1, 1, 1, 2, 2, 2, 3, 3, 3, 4, 5, 5, 5, 6, 8, 9, 9, 9, 9
        };

        [Benchmark]
        public void Test_SummaryRanges_1() => Solution.SummaryRanges1(_arr1);

        [Benchmark]
        public void Test_SummaryRanges_2() => Solution.SummaryRanges1(_arr2);

        [Benchmark]
        public void Test_SummaryRanges_3() => Solution.SummaryRanges2(_arr1);

        [Benchmark]
        public void Test_SummaryRanges_4() => Solution.SummaryRanges2(_arr2);
    }
}

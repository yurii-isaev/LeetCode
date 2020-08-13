using BenchmarkDotNet.Attributes;

namespace Leetcode.MissingRanges
{
    [MemoryDiagnoser]
    [RankColumn]
    public class Benchmark
    {
        private readonly int[] _arr5 = {0, 1, 3, 50, 75};

        private readonly int[] _arr10 = {0, 1, 3, 50, 75, 100, 101, 103, 150, 175};

        [Benchmark]
        public void Test_FindMissingRanges_1() => Solution.FindMissingRanges(_arr5, 0, 99);

        [Benchmark]
        public void Test_FindMissingRanges_2() => Solution.FindMissingRanges(_arr10, 0, 199);

        [Benchmark]
        public void Test_FindMissingRangesByFun_1() => Solution.FindMissingRangesByFun(_arr5, 0, 99);

        [Benchmark]
        public void Test_FindMissingRangesByFun_2() => Solution.FindMissingRangesByFun(_arr10, 0, 199);
    }
}

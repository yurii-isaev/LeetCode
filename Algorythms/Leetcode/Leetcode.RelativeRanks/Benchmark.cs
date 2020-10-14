using BenchmarkDotNet.Attributes;

namespace Leetcode.RelativeRanks
{
    [MemoryDiagnoser]
    [RankColumn]
    public class Benchmark
    {
        private int[] _scores5 = {10, 3, 8, 9, 4};
        private int[] _scores10 = {10, 3, 8, 9, 4, 5, 6, 7, 1, 2};
        private int[] _scores20 = {10, 3, 8, 9, 4, 5, 6, 7, 1, 2, 1, 2, 22, 14, 16, 15, 12, 19, 11, 13, 10};

        [Benchmark]
        public void Test_FindRelativeRanks_1() => Solution.FindRelativeRanks1(_scores5);

        [Benchmark]
        public void Test_FindRelativeRanks_2() => Solution.FindRelativeRanks1(_scores10);

        [Benchmark]
        public void Test_FindRelativeRanks_3() => Solution.FindRelativeRanks1(_scores20);

        [Benchmark]
        public void Test_FindRelativeRanks_4() => Solution.FindRelativeRanks2(_scores5);

        [Benchmark]
        public void Test_FindRelativeRanks_5() => Solution.FindRelativeRanks2(_scores10);

        [Benchmark]
        public void Test_FindRelativeRanks_6() => Solution.FindRelativeRanks2(_scores20);

        [Benchmark]
        public void Test_FindRelativeRanks_7() => Solution.FindRelativeRanks3(_scores5);

        [Benchmark]
        public void Test_FindRelativeRanks_8() => Solution.FindRelativeRanks3(_scores10);

        [Benchmark]
        public void Test_FindRelativeRanks_9() => Solution.FindRelativeRanks3(_scores20);

        [Benchmark]
        public void Test_FindRelativeRanks_13() => Solution.FindRelativeRanks4(_scores5);

        [Benchmark]
        public void Test_FindRelativeRanks_14() => Solution.FindRelativeRanks4(_scores10);

        [Benchmark]
        public void Test_FindRelativeRanks_15() => Solution.FindRelativeRanks4(_scores20);

        [Benchmark]
        public void Test_FindRelativeRanks_16() => Solution.FindRelativeRanks5(_scores5);

        [Benchmark]
        public void Test_FindRelativeRanks_17() => Solution.FindRelativeRanks5(_scores10);

        [Benchmark]
        public void Test_FindRelativeRanks_18() => Solution.FindRelativeRanks5(_scores20);
    }
}

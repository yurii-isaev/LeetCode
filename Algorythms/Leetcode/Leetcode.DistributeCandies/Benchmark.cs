using BenchmarkDotNet.Attributes;

namespace Leetcode.DistributeCandies
{
    [MemoryDiagnoser]
    [RankColumn]
    public class Benchmark
    {
        private readonly int[] _array6 =
        {
            1, 1, 2, 2, 3, 3
        };

        private readonly int[] _array12 =
        {
            1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6
        };

        private readonly int[] _array24 =
        {
            1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7,
            7, 8, 8, 9, 9, 10, 10, 11, 11, 12, 12
        };

        private readonly int[] _array38 =
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13,
            14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24,
            25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38
        };

        [Benchmark]
        public void Test_DistributeCandies_1() => Solution.DistributeCandies1(_array6);

        [Benchmark]
        public void Test_DistributeCandies_2() => Solution.DistributeCandies1(_array12);

        [Benchmark]
        public void Test_DistributeCandies_3() => Solution.DistributeCandies1(_array24);

        [Benchmark]
        public void Test_DistributeCandies_4() => Solution.DistributeCandies1(_array38);


        [Benchmark]
        public void Test_DistributeCandies_5() => Solution.DistributeCandies2(_array6);

        [Benchmark]
        public void Test_DistributeCandies_6() => Solution.DistributeCandies2(_array12);

        [Benchmark]
        public void Test_DistributeCandies_7() => Solution.DistributeCandies2(_array24);

        [Benchmark]
        public void Test_DistributeCandies_8() => Solution.DistributeCandies2(_array38);


        [Benchmark]
        public void Test_DistributeCandies_9() => Solution.DistributeCandies3(_array6);

        [Benchmark]
        public void Test_DistributeCandies_10() => Solution.DistributeCandies3(_array12);

        [Benchmark]
        public void Test_DistributeCandies_11() => Solution.DistributeCandies3(_array24);

        [Benchmark]
        public void Test_DistributeCandies_12() => Solution.DistributeCandies3(_array38);


        [Benchmark]
        public void Test_DistributeCandies_13() => Solution.DistributeCandies4(_array6);

        [Benchmark]
        public void Test_DistributeCandies_14() => Solution.DistributeCandies4(_array12);

        [Benchmark]
        public void Test_DistributeCandies_15() => Solution.DistributeCandies4(_array24);

        [Benchmark]
        public void Test_DistributeCandies_16() => Solution.DistributeCandies4(_array38);
    }
}

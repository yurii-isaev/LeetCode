using BenchmarkDotNet.Attributes;

namespace Leetcode.LongestHarmoniousSubsequence
{
    [MemoryDiagnoser]
    [RankColumn]
    public class Benchmark
    {
        private readonly int[] _array5 =
        {
            1, 3, 2, 2, 5
        };

        private readonly int[] _array10 =
        {
            1, 3, 2, 2, 5, 2, 3, 7, 6, 8
        };

        private readonly int[] _array20 =
        {
            1, 3, 2, 2, 5, 2, 3, 7, 6, 8, 1, 2, 3, 6, 5, 2, 4, 5, 2, 1
        };

        private readonly int[] _array40 =
        {
            1, 3, 2, 2, 5, 2, 3, 7, 6, 8, 1, 2, 3, 6, 5, 2, 4, 5, 2, 1,
            1, 3, 2, 2, 5, 2, 3, 7, 6, 8, 1, 2, 3, 6, 5, 2, 4, 5, 2
        };

        [Benchmark]
        public void TestFindLhs_1() => Solution.FindLhs1(_array5);

        [Benchmark]
        public void TestFindLhs_2() => Solution.FindLhs1(_array10);

        [Benchmark]
        public void TestFindLhs_3() => Solution.FindLhs1(_array20);

        [Benchmark]
        public void TestFindLhs_4() => Solution.FindLhs1(_array40);


        [Benchmark]
        public void TestFindLhs_5() => Solution.FindLhs2(_array5);

        [Benchmark]
        public void TestFindLhs_6() => Solution.FindLhs2(_array10);

        [Benchmark]
        public void TestFindLhs_7() => Solution.FindLhs2(_array20);

        [Benchmark]
        public void TestFindLhs_8() => Solution.FindLhs2(_array40);


        [Benchmark]
        public void TestFindLhs_9() => Solution.FindLhs3(_array5);

        [Benchmark]
        public void TestFindLhs_10() => Solution.FindLhs3(_array10);

        [Benchmark]
        public void TestFindLhs_11() => Solution.FindLhs3(_array20);

        [Benchmark]
        public void TestFindLhs_12() => Solution.FindLhs3(_array40);


        [Benchmark]
        public void TestFindLhs_13() => Solution.FindLhs4(_array5);

        [Benchmark]
        public void TestFindLhs_14() => Solution.FindLhs4(_array10);

        [Benchmark]
        public void TestFindLhs_15() => Solution.FindLhs4(_array20);

        [Benchmark]
        public void TestFindLhs_16() => Solution.FindLhs4(_array40);
    }
}

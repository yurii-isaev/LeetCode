using BenchmarkDotNet.Attributes;

namespace Leetcode.FindNumbersDisappearedArray
{
    [MemoryDiagnoser]
    [RankColumn]
    public class Benchmark
    {
        private readonly int[] _array10 =
        {
            4, 3, 2, 7, 8, 2, 3, 1, 3, 6
        };

        private readonly int[] _array20 =
        {
            4, 3, 2, 7, 8, 2, 3, 1, 3, 6, 11, 13, 5, 18, 4, 14, 4, 6, 12, 10
        };

        [Benchmark]
        public void Test_FindDisappearedNumbers_1() => Solution.FindDisappearedNumbers1(_array10);

        [Benchmark]
        public void Test_FindDisappearedNumbers_2() => Solution.FindDisappearedNumbers1(_array20);

        [Benchmark]
        public void Test_FindDisappearedNumbers_3() => Solution.FindDisappearedNumbers2(_array10);

        [Benchmark]
        public void Test_FindDisappearedNumbers_4() => Solution.FindDisappearedNumbers2(_array20);

        [Benchmark]
        public void Test_FindDisappearedNumbers_5() => Solution.FindDisappearedNumbers3(_array10);

        [Benchmark]
        public void Test_FindDisappearedNumbers_6() => Solution.FindDisappearedNumbers3(_array20);

        [Benchmark]
        public void Test_FindDisappearedNumbers_7() => Solution.FindDisappearedNumbers4(_array10);

        [Benchmark]
        public void Test_FindDisappearedNumbers_8() => Solution.FindDisappearedNumbers4(_array20);

        [Benchmark]
        public void Test_FindDisappearedNumbers_9() => Solution.FindDisappearedNumbers5(_array10);

        [Benchmark]
        public void Test_FindDisappearedNumbers_10() => Solution.FindDisappearedNumbers5(_array20);
    }
}

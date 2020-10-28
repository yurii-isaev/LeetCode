using BenchmarkDotNet.Attributes;

namespace Leetcode.RangeAddition2
{
    [MemoryDiagnoser]
    [RankColumn]
    public class Benchmark
    {
        private readonly int[,] _ops21 = new int[,]
        {
            {2, 2}, {3, 3}
        };

        private readonly int[,] _ops41 = new int[,]
        {
            {2, 2, 2}, {3, 3, 3}, {4, 4, 4}, {5, 5, 5}
        };

        private readonly int[,] _ops81 = new int[,]
        {
            {2, 2, 2, 2}, {3, 3, 3, 3}, {3, 3, 3, 3}, {3, 3, 3, 3},
            {2, 2, 2, 2}, {3, 3, 3, 3}, {3, 3, 3, 3}, {3, 3, 3, 3}
        };

        private readonly int[][] _ops2 =
        {
            new[] {2, 2}, new[] {3, 3}
        };

        private readonly int[][] _ops4 =
        {
            new[] {2, 2}, new[] {3, 3}, new[] {4, 4}, new[] {5, 5}
        };

        private readonly int[][] _ops8 =
        {
            new[] {2, 2, 2, 2}, new[] {3, 3, 3, 3}, new[] {3, 3, 3, 3}, new[] {3, 3, 3, 3},
            new[] {2, 2, 2, 2}, new[] {3, 3, 3, 3}, new[] {3, 3, 3, 3}, new[] {3, 3, 3, 3}
        };

        [Benchmark]
        public void Test_MaxCount_1() => Solution.MaxCount1(3, 3, _ops2);

        [Benchmark]
        public void Test_MaxCount_2() => Solution.MaxCount1(3, 3, _ops4);

        [Benchmark]
        public void Test_MaxCount_3() => Solution.MaxCount1(3, 3, _ops8);

        [Benchmark]
        public void Test_MaxCount_4() => Solution.MaxCount2(3, 3, _ops2);

        [Benchmark]
        public void Test_MaxCount_5() => Solution.MaxCount2(3, 3, _ops4);

        [Benchmark]
        public void Test_MaxCount_6() => Solution.MaxCount2(3, 3, _ops8);

        [Benchmark]
        public void Test_MaxCount_7() => Solution.MaxCount3(3, 3, _ops21);

        [Benchmark]
        public void Test_MaxCount_8() => Solution.MaxCount3(3, 3, _ops41);

        [Benchmark]
        public void Test_MaxCount_9() => Solution.MaxCount3(3, 3, _ops81);

        [Benchmark]
        public void Test_MaxCount_10() => Solution.MaxCount4(3, 3, _ops2);

        [Benchmark]
        public void Test_MaxCount_11() => Solution.MaxCount4(3, 3, _ops4);

        [Benchmark]
        public void Test_MaxCount_12() => Solution.MaxCount4(3, 3, _ops8);

        [Benchmark]
        public void Test_MaxCount_13() => Solution.MaxCount5(3, 3, _ops2);

        [Benchmark]
        public void Test_MaxCount_14() => Solution.MaxCount5(3, 3, _ops4);

        [Benchmark]
        public void Test_MaxCount_15() => Solution.MaxCount5(3, 3, _ops8);
    }
}

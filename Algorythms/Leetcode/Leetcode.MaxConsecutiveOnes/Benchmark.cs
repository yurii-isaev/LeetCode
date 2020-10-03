using BenchmarkDotNet.Attributes;

namespace Leetcode.MaxConsecutiveOnes
{
    [MemoryDiagnoser]
    [RankColumn]
    public class Benchmark
    {
        private readonly int[] _grid10 =
        {
            1, 1, 0, 1, 1, 1, 0, 0, 1, 1
        };

        private readonly int[] _grid20 =
        {
            1, 1, 0, 1, 1, 1, 0, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1, 1, 2, 2
        };

        private readonly int[] _grid40 =
        {
            1, 1, 0, 1, 1, 1, 0, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1, 1, 2, 2,
            1, 1, 0, 1, 1, 1, 0, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1, 1, 2, 2
        };

        [Benchmark]
        public void Test_FindMaxConsecutiveOnes_1() => Solution.FindMaxConsecutiveOnes1(_grid10);

        [Benchmark]
        public void Test_FindMaxConsecutiveOnes_2() => Solution.FindMaxConsecutiveOnes1(_grid20);

        [Benchmark]
        public void Test_FindMaxConsecutiveOnes_3() => Solution.FindMaxConsecutiveOnes1(_grid40);

        [Benchmark]
        public void Test_FindMaxConsecutiveOnes_4() => Solution.FindMaxConsecutiveOnes2(_grid10);

        [Benchmark]
        public void Test_FindMaxConsecutiveOnes_5() => Solution.FindMaxConsecutiveOnes2(_grid20);

        [Benchmark]
        public void Test_FindMaxConsecutiveOnes_6() => Solution.FindMaxConsecutiveOnes2(_grid40);

        [Benchmark]
        public void Test_FindMaxConsecutiveOnes_7() => Solution.FindMaxConsecutiveOnes3(_grid10);

        [Benchmark]
        public void Test_FindMaxConsecutiveOnes_8() => Solution.FindMaxConsecutiveOnes3(_grid20);

        [Benchmark]
        public void Test_FindMaxConsecutiveOnes_9() => Solution.FindMaxConsecutiveOnes3(_grid40);

        [Benchmark]
        public void Test_FindMaxConsecutiveOnes_10() => Solution.FindMaxConsecutiveOnes4(_grid10);

        [Benchmark]
        public void Test_FindMaxConsecutiveOnes_11() => Solution.FindMaxConsecutiveOnes4(_grid20);

        [Benchmark]
        public void Test_FindMaxConsecutiveOnes_12() => Solution.FindMaxConsecutiveOnes4(_grid40);
    }
}

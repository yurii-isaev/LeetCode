using BenchmarkDotNet.Attributes;

namespace Leetcode.TeemoAttacking
{
    [MemoryDiagnoser]
    [RankColumn]
    public class Benchmark
    {
        private readonly int[] _timeSeries1 =
        {
            1, 2, 4, 5, 6
        };

        private readonly int[] _timeSeries2 =
        {
            1, 2, 4, 5, 6, 8, 10, 15, 19, 24
        };

        private readonly int[] _timeSeries4 =
        {
            1, 2, 4, 5, 6, 8, 10, 15, 19, 24, 26, 27, 29, 30, 32, 35,
            36, 37, 38, 41, 43, 45, 48, 49, 51, 52, 53, 57, 58, 59
        };

        [Benchmark]
        public void Test_FindPoisonedDuration_1() => Solution.FindPoisonedDuration1(_timeSeries1, 2);

        [Benchmark]
        public void Test_FindPoisonedDuration_2() => Solution.FindPoisonedDuration1(_timeSeries2, 4);

        [Benchmark]
        public void Test_FindPoisonedDuration_3() => Solution.FindPoisonedDuration1(_timeSeries4, 8);

        [Benchmark]
        public void Test_FindPoisonedDuration_4() => Solution.FindPoisonedDuration2(_timeSeries1, 2);

        [Benchmark]
        public void Test_FindPoisonedDuration_5() => Solution.FindPoisonedDuration2(_timeSeries2, 4);

        [Benchmark]
        public void Test_FindPoisonedDuration_6() => Solution.FindPoisonedDuration2(_timeSeries4, 8);

        [Benchmark]
        public void Test_FindPoisonedDuration_7() => Solution.FindPoisonedDuration3(_timeSeries1, 2);

        [Benchmark]
        public void Test_FindPoisonedDuration_8() => Solution.FindPoisonedDuration3(_timeSeries2, 4);

        [Benchmark]
        public void Test_FindPoisonedDuration_9() => Solution.FindPoisonedDuration3(_timeSeries4, 8);
    }
}

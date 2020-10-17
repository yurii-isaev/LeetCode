using BenchmarkDotNet.Attributes;

namespace Leetcode.ArrayPartition
{
    [MemoryDiagnoser]
    [RankColumn]
    public class Benchmark
    {
        private int[] _scores6 =
        {
            6, 2, 6, 5, 1, 2
        };
        
        private int[] _scores12 =
        {
            6, 21, 6, 52, 1, 21, 1, 95, 2, 56, 6, 84
        };

        private int[] _scores24 =
        {
            6, 2, 6, 5, 20, 29, 1, 49, 2, 5, 12, 8, 6, 25, 16, 5, 16, 12, 1, 19, 2, 51, 6, 8
        };

        [Benchmark]
        public void Test_ArrayPairSum_1() => Solution.ArrayPairSum1(_scores6);

        [Benchmark]
        public void Test_ArrayPairSum_2() => Solution.ArrayPairSum1(_scores12);

        [Benchmark]
        public void Test_ArrayPairSum_3() => Solution.ArrayPairSum1(_scores24);

        [Benchmark]
        public void Test_ArrayPairSum_4() => Solution.ArrayPairSum2(_scores6);

        [Benchmark]
        public void Test_ArrayPairSum_5() => Solution.ArrayPairSum2(_scores12);

        [Benchmark]
        public void Test_ArrayPairSum_6() => Solution.ArrayPairSum2(_scores24);

        [Benchmark]
        public void Test_ArrayPairSum_7() => Solution.ArrayPairSum3(_scores6);

        [Benchmark]
        public void Test_ArrayPairSum_8() => Solution.ArrayPairSum3(_scores12);

        [Benchmark]
        public void Test_ArrayPairSum_9() => Solution.ArrayPairSum3(_scores24);

        [Benchmark]
        public void Test_ArrayPairSum_10() => Solution.ArrayPairSum4(_scores6);

        [Benchmark]
        public void Test_ArrayPairSum_11() => Solution.ArrayPairSum4(_scores12);

        [Benchmark]
        public void Test_ArrayPairSum_12() => Solution.ArrayPairSum4(_scores24);
    }
}

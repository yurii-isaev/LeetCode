using BenchmarkDotNet.Attributes;

namespace Leetcode.MoveZeroes
{
    [MemoryDiagnoser]
    [RankColumn]
    public class Benchmark
    {
        private readonly int[] _arr1 =
        {
            0, 1, 0, 3, 12
        };

        private readonly int[] _arr2 =
        {
            0, 1, 0, 3, 12, 0, 5, 0, 4, 2
        };

        private readonly int[] _arr4 =
        {
            0, 1, 0, 3, 12, 0, 5, 0, 4, 2, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9
        };

        private readonly int[] _arr6 =
        {
            0, 1, 0, 3, 12, 0, 5, 0, 4, 2, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 0, 4, 2, 7
        };

        [Benchmark]
        public void Test_MoveZeroes_1() => Solution.MoveZeroes1(_arr1);

        [Benchmark]
        public void Test_MoveZeroes_2() => Solution.MoveZeroes1(_arr2);

        [Benchmark]
        public void Test_MoveZeroes_3() => Solution.MoveZeroes1(_arr4);

        [Benchmark]
        public void Test_MoveZeroes_4() => Solution.MoveZeroes1(_arr6);


        [Benchmark]
        public void Test_MoveZeroes_5() => Solution.MoveZeroes2(_arr1);

        [Benchmark]
        public void Test_MoveZeroes_6() => Solution.MoveZeroes2(_arr2);

        [Benchmark]
        public void Test_MoveZeroes_7() => Solution.MoveZeroes2(_arr4);

        [Benchmark]
        public void Test_MoveZeroes_8() => Solution.MoveZeroes2(_arr6);


        [Benchmark]
        public void Test_MoveZeroes_9() => Solution.MoveZeroes3(_arr1);

        [Benchmark]
        public void Test_MoveZeroes_10() => Solution.MoveZeroes3(_arr2);

        [Benchmark]
        public void Test_MoveZeroes_11() => Solution.MoveZeroes3(_arr4);

        [Benchmark]
        public void Test_MoveZeroes_12() => Solution.MoveZeroes3(_arr6);


        [Benchmark]
        public void Test_MoveZeroes_13() => Solution.MoveZeroesByLinq(_arr1);

        [Benchmark]
        public void Test_MoveZeroes_14() => Solution.MoveZeroesByLinq(_arr2);

        [Benchmark]
        public void Test_MoveZeroes_15() => Solution.MoveZeroesByLinq(_arr4);

        [Benchmark]
        public void Test_MoveZeroes_16() => Solution.MoveZeroesByLinq(_arr6);
    }
}

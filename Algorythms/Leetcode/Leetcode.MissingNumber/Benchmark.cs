using BenchmarkDotNet.Attributes;

namespace Leetcode.MissingNumber
{
    [MemoryDiagnoser]
    [RankColumn]
    public class Benchmark
    {
        private readonly int[] _arr1 =
        {
            0, 1, 2, 3, 4
        };

        private readonly int[] _arr2 =
        {
            0, 1, 2, 3, 4, 5, 6, 7, 8, 9
        };

        private readonly int[] _arr4 =
        {
            0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19
        };

        private readonly int[] _arr6 =
        {
            0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15,
            16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29
        };

        [Benchmark]
        public void Test_MissingNumber_1() => Solution.MissingNumber1(_arr1);

        [Benchmark]
        public void Test_MissingNumber_2() => Solution.MissingNumber1(_arr2);

        [Benchmark]
        public void Test_MissingNumber_3() => Solution.MissingNumber1(_arr4);

        [Benchmark]
        public void Test_MissingNumber_4() => Solution.MissingNumber2(_arr6);

        [Benchmark]
        public void Test_MissingNumber_5() => Solution.MissingNumber2(_arr1);

        [Benchmark]
        public void Test_MissingNumber_6() => Solution.MissingNumber2(_arr2);

        [Benchmark]
        public void Test_MissingNumber_7() => Solution.MissingNumber2(_arr4);

        [Benchmark]
        public void Test_MissingNumber_8() => Solution.MissingNumber2(_arr6);

        [Benchmark]
        public void Test_MissingNumber_9() => Solution.MissingNumber3(_arr1);

        [Benchmark]
        public void Test_MissingNumber_10() => Solution.MissingNumber3(_arr2);

        [Benchmark]
        public void Test_MissingNumber_11() => Solution.MissingNumber3(_arr4);

        [Benchmark]
        public void Test_MissingNumber_12() => Solution.MissingNumber4(_arr6);

        [Benchmark]
        public void Test_MissingNumber_13() => Solution.MissingNumber4(_arr1);

        [Benchmark]
        public void Test_MissingNumber_14() => Solution.MissingNumber4(_arr2);

        [Benchmark]
        public void Test_MissingNumber_15() => Solution.MissingNumber4(_arr4);

        [Benchmark]
        public void Test_MissingNumber_16() => Solution.MissingNumber4(_arr6);

        [Benchmark]
        public void Test_MissingNumber_17() => Solution.MissingNumberByLinq(_arr1);

        [Benchmark]
        public void Test_MissingNumber_18() => Solution.MissingNumberByLinq(_arr2);

        [Benchmark]
        public void Test_MissingNumber_19() => Solution.MissingNumberByLinq(_arr4);

        [Benchmark]
        public void Test_MissingNumber_20() => Solution.MissingNumberByLinq(_arr6);
    }
}

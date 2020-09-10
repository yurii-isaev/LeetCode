using BenchmarkDotNet.Attributes;

namespace Leetcode.RangeSumQueryImmutable
{
    [MemoryDiagnoser]
    [RankColumn]
    public class Benchmark
    {
        private readonly int[] _arr10 =
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 9
        };

        private readonly int[] _arr20 =
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9
        };

        private readonly int[] _arr40 =
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9,
            1, 2, 3, 4, 5, 6, 7, 8, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9
        };

        [Benchmark]
        public void Test_SumRange_1() => new NumArray(_arr10).SumRange(2, 8);

        [Benchmark]
        public void Test_SumRange_2() => new NumArray(_arr20).SumRange(5, 15);

        [Benchmark]
        public void Test_SumRange_3() => new NumArray(_arr40).SumRange(10, 30);


        [Benchmark]
        public void Test_SumRange_4() => new NumArray2(_arr10).SumRange(2, 8);

        [Benchmark]
        public void Test_SumRange_5() => new NumArray2(_arr20).SumRange(5, 15);

        [Benchmark]
        public void Test_SumRange_6() => new NumArray2(_arr40).SumRange(10, 30);


        [Benchmark]
        public void Test_SumRange_7() => new NumArray3(_arr10).SumRange(2, 8);

        [Benchmark]
        public void Test_SumRange_8() => new NumArray3(_arr20).SumRange(5, 15);

        [Benchmark]
        public void Test_SumRange_9() => new NumArray3(_arr40).SumRange(10, 30);


        [Benchmark]
        public void Test_SumRangeByLinq_1() => new NumArrayByLinq(_arr10).SumRange(2, 8);

        [Benchmark]
        public void Test_SumRangeByLinq_2() => new NumArrayByLinq(_arr20).SumRange(5, 15);

        [Benchmark]
        public void Test_SumRangeByLinq_3() => new NumArrayByLinq(_arr40).SumRange(10, 30);


        [Benchmark]
        public void Test_SumRangeByListLinq_1() => new NumArrayByListLinq(_arr10).SumRange(2, 8);

        [Benchmark]
        public void Test_SumRangeByListLinq_2() => new NumArrayByListLinq(_arr20).SumRange(5, 15);

        [Benchmark]
        public void Test_SumRangeByListLinq_3() => new NumArrayByListLinq(_arr40).SumRange(10, 30);
    }
}

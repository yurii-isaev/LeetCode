using BenchmarkDotNet.Attributes;

namespace Leetсode.MergeSortedArray
{
    [MemoryDiagnoser]
    [RankColumn]
    public class Benchmark
    {
        private readonly int[] _arr10 =
        {
            1, 2, 3, 4, 5, 0, 0, 0, 0, 0
        };

        private readonly int[] _arr20 =
        {
            1, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0
        };

        [Benchmark]
        public void Test_MergeByWhile1() => Solution.MergeByWhile(_arr10, 5, _arr10, 5);

        [Benchmark]
        public void Test_MergeByWhile2() => Solution.MergeByWhile(_arr20, 10, _arr20, 10);

        [Benchmark]
        public void Test_MergeByFor1() => Solution.MergeByFor(_arr10, 5, _arr10, 5);

        [Benchmark]
        public void Test_MergeByFor2() => Solution.MergeByFor(_arr20, 10, _arr20, 10);

        [Benchmark]
        public void Test_MergeByArray1() => Solution.MergeByArray(_arr10, 5, _arr10, 5);

        [Benchmark]
        public void Test_MergeByArray2() => Solution.MergeByArray(_arr20, 10, _arr20, 10);

        [Benchmark]
        public void Test_MergeByLinq1() => Solution.MergeByLinq(_arr10, 5, _arr10, 5);

        [Benchmark]
        public void Test_MergeByLinq2() => Solution.MergeByLinq(_arr20, 10, _arr20, 10);
    }
}

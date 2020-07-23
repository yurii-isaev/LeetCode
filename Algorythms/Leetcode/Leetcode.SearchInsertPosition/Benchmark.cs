using BenchmarkDotNet.Attributes;

namespace Leetcode.SearchInsertPosition
{
    [MemoryDiagnoser]
    [RankColumn]
    public class Benchmark
    {
        private readonly int[] _arr10 =
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10
        };
        
        private readonly int[] _arr20 =
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20
        };

        private readonly int[] _arr40 =
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 22, 23, 24, 25, 26, 27, 28, 29, 30,
            31, 32, 33, 34, 35, 36, 37, 38, 39, 40
        };

        [Benchmark]
        public void TestSearchInsert1() => Solution.SearchInsert(_arr10, 5);

        [Benchmark]
        public void TestSearchInsert2() => Solution.SearchInsert(_arr20, 10);

        [Benchmark]
        public void TestSearchInsert3() => Solution.SearchInsert(_arr40, 30);

        [Benchmark]
        public void TestSearchInsertByBinarySearch1() => Solution.SearchInsertByBinarySearch(_arr10, 5);

        [Benchmark]
        public void TestSearchInsertByBinarySearch2() => Solution.SearchInsertByBinarySearch(_arr20, 10);

        [Benchmark]
        public void TestSearchInsertByBinarySearch3() => Solution.SearchInsertByBinarySearch(_arr40, 30);

        [Benchmark]
        public void TestSearchInsertByFor1() => Solution.SearchInsertByFor(_arr10, 5);

        [Benchmark]
        public void TestSearchInsertByFor2() => Solution.SearchInsertByFor(_arr20, 10);

        [Benchmark]
        public void TestSearchInsertByFor3() => Solution.SearchInsertByFor(_arr40, 30);

        [Benchmark]
        public void TestSearchInsertByLinq1() => Solution.SearchInsertByLinq(_arr10, 5);

        [Benchmark]
        public void TestSearchInsertByLinq2() => Solution.SearchInsertByLinq(_arr20, 10);

        [Benchmark]
        public void TestSearchInsertByLinq3() => Solution.SearchInsertByLinq(_arr40, 30);
    }
}

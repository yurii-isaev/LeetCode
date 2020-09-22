using BenchmarkDotNet.Attributes;

namespace Leetcode.ThirdMaximumNumber
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

        [Benchmark]
        public void Test_ThirdMax_1() => Solution.ThirdMax(_arr10);

        [Benchmark]
        public void Test_ThirdMax_2() => Solution.ThirdMax(_arr20);

        [Benchmark]
        public void Test_ThirdMaxByArray_1() => Solution.ThirdMaxByArray(_arr10);

        [Benchmark]
        public void Test_ThirdMaxByArray_2() => Solution.ThirdMaxByArray(_arr20);

        [Benchmark]
        public void Test_ThirdMaxBySortedSet_1() => Solution.ThirdMaxBySortedSet(_arr10);

        [Benchmark]
        public void Test_ThirdMaxBySortedSet_2() => Solution.ThirdMaxBySortedSet(_arr20);

        [Benchmark]
        public void Test_ThirdMaxByLinqSortedSet_1() => Solution.ThirdMaxByLinqSortedSet(_arr10);

        [Benchmark]
        public void Test_ThirdMaxByLinqSortedSet_2() => Solution.ThirdMaxByLinqSortedSet(_arr20);

        [Benchmark]
        public void Test_ThirdMaxByLinq_1() => Solution.ThirdMaxByLinq(_arr10);

        [Benchmark]
        public void Test_ThirdMaxByLinq_2() => Solution.ThirdMaxByLinq(_arr20);
    }
}

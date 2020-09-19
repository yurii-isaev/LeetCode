using BenchmarkDotNet.Attributes;

namespace Leetcode.IntersectionOfTwoArrays2
{
    [MemoryDiagnoser]
    [RankColumn]
    public class Benchmark
    {
        private readonly int[] _arr1 =
        {
            1, 2, 3, 4, 5, 6, 7, 8, 10
        };

        private readonly int[] _arr2 =
        {
            1, 2, 3, 4, 5, 6, 7, 8, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20
        };

        [Benchmark]
        public void Test_Intersect_1() => Solution.Intersect(_arr1, _arr1);

        [Benchmark]
        public void Test_Intersect_2() => Solution.Intersect(_arr2, _arr2);

        [Benchmark]
        public void Test_IntersectByList_1() => Solution.IntersectByList(_arr1, _arr1);

        [Benchmark]
        public void Test_IntersectByList_2() => Solution.IntersectByList(_arr2, _arr2);

        [Benchmark]
        public void Test_IntersectByLinq_1() => Solution.IntersectByLinq(_arr1, _arr1);

        [Benchmark]
        public void Test_IntersectByLinq_2() => Solution.IntersectByLinq(_arr2, _arr2);

        [Benchmark]
        public void Test_IntersectByLinqDictionary_1() => Solution.IntersectByLinqDictionary(_arr1, _arr1);

        [Benchmark]
        public void Test_IntersectByLinqDictionary_2() => Solution.IntersectByLinqDictionary(_arr2, _arr2);
    }
}

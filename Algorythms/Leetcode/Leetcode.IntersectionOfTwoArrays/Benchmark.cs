using BenchmarkDotNet.Attributes;

namespace Leetcode.IntersectionOfTwoArrays
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
        public void Test_IntersectionByList_1() => Solution.IntersectionByList(_arr1, _arr1);

        [Benchmark]
        public void Test_IntersectionByList_2() => Solution.IntersectionByList(_arr2, _arr2);

        [Benchmark]
        public void Test_IntersectionByHashSet_1() => Solution.IntersectionByHashSet(_arr1, _arr1);

        [Benchmark]
        public void Test_IntersectionByHashSet_2() => Solution.IntersectionByHashSet(_arr2, _arr2);

        [Benchmark]
        public void Test_IntersectionByLinq_1() => Solution.IntersectionByLinq(_arr1, _arr1);

        [Benchmark]
        public void Test_IntersectionByLinq_2() => Solution.IntersectionByLinq(_arr2, _arr2);

        [Benchmark]
        public void Test_IntersectionByLinqIntersect_1() => Solution.IntersectionByLinqIntersect(_arr1, _arr1);

        [Benchmark]
        public void Test_IntersectionByLinqIntersect_2() => Solution.IntersectionByLinqIntersect(_arr2, _arr2);
    }
}

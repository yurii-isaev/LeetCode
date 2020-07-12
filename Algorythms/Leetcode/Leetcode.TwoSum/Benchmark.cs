using BenchmarkDotNet.Attributes;

namespace Leetcode.TwoSum
{
    [MemoryDiagnoser]
    [RankColumn]
    public class Benchmark
    {
        private readonly int[] _arr1 = {87, 47, 78, 82, 6, 37, 98, 18, 3, 10};

        private readonly int[] _arr2 =
            {87, 47, 78, 82, 6, 37, 98, 18, 3, 10, 10, 9, 87, 9, 6, 7, 8, 12, 14, 20};

        private readonly int[] _arr3 =
        {
            87, 47, 78, 82, 15, 37, 98, 18, 92, 3, 10, 9, 87, 9, 6, 7, 8, 12, 14, 20, 1, 3, 45, 5, 6, 8, 1, 50, 42, 30
        };

        [Benchmark]
        public void Test_GetTwoSum_1() => Solution.GetTwoSum(_arr1, 9);

        [Benchmark]
        public void Test_GetTwoSum_2() => Solution.GetTwoSum(_arr2, 9);

        [Benchmark]
        public void Test_GetTwoSum_3() => Solution.GetTwoSum(_arr3, 2);

        [Benchmark]
        public void Test_GetTwoSumByDictionary_1() => Solution.GetTwoSumByDictionary(_arr1, 9);

        [Benchmark]
        public void Test_GetTwoSumByDictionary_2() => Solution.GetTwoSumByDictionary(_arr2, 9);

        [Benchmark]
        public void Test_GetTwoSumByDictionary_3() => Solution.GetTwoSumByDictionary(_arr3, 2);
    }
}

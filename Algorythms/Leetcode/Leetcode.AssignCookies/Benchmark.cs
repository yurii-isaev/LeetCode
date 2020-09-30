using BenchmarkDotNet.Attributes;

namespace Leetcode.AssignCookies
{
    [MemoryDiagnoser]
    [RankColumn]
    public class Benchmark
    {
        private readonly int[] _array10 =
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10
        };

        private readonly int[] _array20 =
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20
        };

        private readonly int[] _array40 =
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
            21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40
        };

        [Benchmark]
        public void Test_IsContainsDuplicateByFor_1() => Solution.FindContentChildren(_array10, _array10);

        [Benchmark]
        public void Test_IsContainsDuplicateByFor_2() => Solution.FindContentChildren(_array20, _array20);

        [Benchmark]
        public void Test_IsContainsDuplicateByFor_3() => Solution.FindContentChildren(_array40, _array40);
    }
}

using BenchmarkDotNet.Attributes;

namespace Leetcode.MaximumSubarray
{
    [MemoryDiagnoser]
    [RankColumn]
    public class Benchmark
    {
        private readonly int[] _arr10 =
        {
            -2, 1, -3, 4, -1, 2, 1, -5, 4, 6
        };

        private readonly int[] _arr20 =
        {
            -2, 1, -3, 4, -1, 2, 1, -5, 4, 6, 3, 8, 4, -1, 5, -6, 2, 9, 0, 7
        };

        private readonly int[] _arr40 =
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
            22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40
        };

        [Benchmark]
        public void Test_FindMaxSubArrayByForEach1() => Solution.FindMaxSubArrayByForEach(_arr10);

        [Benchmark]
        public void Test_FindMaxSubArrayByForEach2() => Solution.FindMaxSubArrayByForEach(_arr20);

        [Benchmark]
        public void Test_FindMaxSubArrayByForEach3() => Solution.FindMaxSubArrayByForEach(_arr40);

        [Benchmark]
        public void Test_FindMaxSubArray1() => Solution.FindMaxSubArray(_arr10);

        [Benchmark]
        public void Test_FindMaxSubArray2() => Solution.FindMaxSubArray(_arr20);

        [Benchmark]
        public void Test_FindMaxSubArray3() => Solution.FindMaxSubArray(_arr40);

        [Benchmark]
        public void Test_FindMaxSubArrayByFor1() => Solution.FindMaxSubArrayByFor(_arr10);

        [Benchmark]
        public void Test_FindMaxSubArrayByFor2() => Solution.FindMaxSubArrayByFor(_arr20);

        [Benchmark]
        public void Test_FindMaxSubArrayByFor3() => Solution.FindMaxSubArrayByFor(_arr40);
    }
}

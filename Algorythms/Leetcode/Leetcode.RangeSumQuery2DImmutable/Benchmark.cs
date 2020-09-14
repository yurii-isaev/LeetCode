using BenchmarkDotNet.Attributes;

namespace Leetcode.RangeSumQuery2DImmutable
{
    [MemoryDiagnoser]
    [RankColumn]
    public class Benchmark
    {
        private readonly int[][] _matrix25 =
        {
            new[] {3, 0, 1, 4, 2},
            new[] {5, 6, 3, 2, 1},
            new[] {1, 2, 0, 1, 5},
            new[] {4, 1, 0, 1, 7},
            new[] {1, 0, 3, 0, 5}
        };

        private readonly int[][] _matrix50 =
        {
            new[] {3, 0, 1, 4, 2, 5, 9, 4, 5, 9},
            new[] {5, 6, 3, 2, 1, 5, 9, 4, 5, 9},
            new[] {1, 2, 0, 1, 5, 5, 9, 4, 5, 9},
            new[] {4, 1, 0, 1, 7, 5, 9, 4, 5, 9},
            new[] {4, 1, 0, 1, 7, 5, 9, 4, 5, 9}
        };

        [Benchmark]
        public void Test_NumMatrix_1() => new NumMatrix(_matrix25).SumRegion(2, 1, 4, 3);

        [Benchmark]
        public void Test_NumMatrix_2() => new NumMatrix(_matrix50).SumRegion(2, 4, 4, 9);

        [Benchmark]
        public void Test_NumMatrixByDp_1() => new NumMatrixByDp(_matrix25).SumRegion(2, 1, 4, 3);

        [Benchmark]
        public void Test_NumMatrixByDp_2() => new NumMatrixByDp(_matrix50).SumRegion(2, 4, 4, 9);
    }
}

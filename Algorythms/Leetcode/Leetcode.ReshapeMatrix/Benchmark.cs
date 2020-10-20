using BenchmarkDotNet.Attributes;

namespace Leetcode.ReshapeMatrix
{
    [MemoryDiagnoser]
    [RankColumn]
    public class Benchmark
    {
        private readonly int[][] _arr2 =
        {
            new[] {1, 2}, new[] {3, 4}
        };

        private readonly int[][] _arr4 =
        {
            new[] {1, 2}, new[] {3, 4}, new[] {5, 6}, new[] {7, 8}
        };

        [Benchmark]
        public void Test_MatrixReshape_1() => Solution.MatrixReshape1(_arr2, 1, 4);

        [Benchmark]
        public void Test_MatrixReshape_2() => Solution.MatrixReshape1(_arr4, 2, 4);

        [Benchmark]
        public void Test_MatrixReshape_3() => Solution.MatrixReshape2(_arr2, 1, 4);

        [Benchmark]
        public void Test_MatrixReshape_4() => Solution.MatrixReshape2(_arr4, 2, 4);

        [Benchmark]
        public void Test_MatrixReshape_5() => Solution.MatrixReshape3(_arr2, 1, 4);

        [Benchmark]
        public void Test_MatrixReshape_6() => Solution.MatrixReshape3(_arr4, 2, 4);

        [Benchmark]
        public void Test_MatrixReshape_7() => Solution.MatrixReshape4(_arr2, 1, 4);

        [Benchmark]
        public void Test_MatrixReshape_8() => Solution.MatrixReshape4(_arr4, 2, 4);

        [Benchmark]
        public void Test_MatrixReshape_9() => Solution.MatrixReshape5(_arr2, 1, 4);

        [Benchmark]
        public void Test_MatrixReshape_10() => Solution.MatrixReshape5(_arr4, 2, 4);
    }
}

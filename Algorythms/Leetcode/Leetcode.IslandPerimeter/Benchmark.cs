using BenchmarkDotNet.Attributes;

namespace Leetcode.IslandPerimeter
{
    [MemoryDiagnoser]
    [RankColumn]
    public class Benchmark
    {
        private readonly int[][] _grid4 =
        {
            new[] {0,1,0,0}, new[] {1,1,1,0}, new[] {0,1,0,0}, new[] {1,1,0,0}
        };

        private readonly int[][] _grid8 =
        {
            new[] {0,1,0,0}, new[] {1,1,1,0}, new[] {0,1,0,0}, new[] {1,1,0,0},
            new[] {0,1,0,0}, new[] {1,1,1,0}, new[] {0,1,0,0}, new[] {1,1,0,0}
        };

        [Benchmark]
        public void Test_IslandPerimeter_1() => Solution.IslandPerimeter1(_grid4);

        [Benchmark]
        public void Test_IslandPerimeter_2() => Solution.IslandPerimeter2(_grid8);
        
        [Benchmark]
        public void Test_IslandPerimeter_3() => Solution.IslandPerimeter1(_grid4);

        [Benchmark]
        public void Test_IslandPerimeter_4() => Solution.IslandPerimeter2(_grid8);
    }
}
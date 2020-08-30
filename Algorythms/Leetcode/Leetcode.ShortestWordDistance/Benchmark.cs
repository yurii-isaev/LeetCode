using BenchmarkDotNet.Attributes;

namespace Leetcode.ShortestWordDistance
{
    [MemoryDiagnoser]
    [RankColumn]
    public class Benchmark
    {
        private readonly string[] _arr5 =
        {
            "practice", "makes", "perfect", "coding", "makes"
        };

        private readonly string[] _arr10 =
        {
            "practice", "makes", "perfect", "coding", "makes", "makes", "perfect", "coding", "makes", "long"
        };

        [Benchmark]
        public void Test_ShortestDistance_1()
        {
            Solution.ShortestDistance(_arr5, "practice", "coding");
        }

        [Benchmark]
        public void Test_ShortestDistance_2()
        {
            Solution.ShortestDistance(_arr10, "makes", "long");
        }
    }
}

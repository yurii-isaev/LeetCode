using BenchmarkDotNet.Attributes;

namespace Leetcode.TwoSumDataStructureDesign
{
    [MemoryDiagnoser]
    [RankColumn]
    public class Benchmark
    {
        [Benchmark]
        public void Test_MapAdd() => DictionarySolution.Add(1);

        [Benchmark]
        public void Test_MapIsFind1() => DictionarySolution.IsFind1(4);

        [Benchmark]
        public void Test_MapIsFind2() => DictionarySolution.IsFind2(4);

        [Benchmark]
        public void Test_SetAdd() => SetSolution.Add(1);

        [Benchmark]
        public void Test_SetIsFind() => SetSolution.IsFind(4);
    }
}

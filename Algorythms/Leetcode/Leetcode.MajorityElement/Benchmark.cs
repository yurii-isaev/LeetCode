using BenchmarkDotNet.Attributes;

namespace Leetcode.MajorityElement
{
    [MemoryDiagnoser]
    [RankColumn]
    public class Benchmark
    {
        private readonly int[] _arr10 =
        {
            1, 2, 4, 3, 3, 3, 5, 5, 1, 1
        };
        
        private readonly int[] _arr20 =
        {
            1, 2, 3, 4, 5, 5, 5, 6, 7, 8, 8, 9, 9, 1, 2, 3, 3, 4, 4, 4
        };

        [Benchmark]
        public void Test_FindMajorityElementByCount_1() => Solution.FindMajorityElementByCount(_arr10);

        [Benchmark]
        public void Test_FindMajorityElementByCount_2() => Solution.FindMajorityElementByCount(_arr20);

        [Benchmark]
        public void Test_FindMajorityElement_1() => Solution.FindMajorityElement(_arr10);

        [Benchmark]
        public void Test_FindMajorityElement_2() => Solution.FindMajorityElement(_arr20);

        [Benchmark]
        public void Test_FindMajorityElementByLinq_1() => Solution.FindMajorityElementByLinq(_arr10);

        [Benchmark]
        public void Test_FindMajorityElementByLinq_2() => Solution.FindMajorityElementByLinq(_arr20);
    }
}

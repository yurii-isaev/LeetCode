using BenchmarkDotNet.Attributes;

namespace Leetcode.RemoveElement
{
    [MemoryDiagnoser]
    [RankColumn]
    public class Benchmark
    {
        private readonly int[] _arr10 =
        {
            3, 2, 2, 4, 3, 5, 8, 0, 3, 1
        };
        
        private readonly int[] _arr20 =
        {
            3, 2, 2, 4, 3, 5, 8, 0, 3, 1, 8, 6, 7, 3, 4, 1, 2, 8, 6, 4
        };

        private readonly int[] _arr30 =
        {
            1, 1, 2, 2, 3, 3, 4, 4, 4, 5, 5, 5, 6, 6, 7, 7, 8, 8, 8, 8, 8, 8, 8, 8, 8, 9, 9, 9, 9, 9
        };

        [Benchmark]
        public void Test_RemoveElement_ByForeach1() => Solution.RemoveElementByForeach(_arr10, 3);

        [Benchmark]
        public void Test_RemoveElement_ByForeach2() => Solution.RemoveElementByForeach(_arr20, 3);

        [Benchmark]
        public void Test_RemoveElement_ByForeach3() => Solution.RemoveElementByForeach(_arr30, 3);

        [Benchmark]
        public void Test_RemoveElement_ByFor1() => Solution.RemoveElementByFor(_arr10, 3);

        [Benchmark]
        public void Test_RemoveElement_ByFor2() => Solution.RemoveElementByFor(_arr20, 3);

        [Benchmark]
        public void Test_RemoveElement_ByFort3() => Solution.RemoveElementByFor(_arr30, 3);

        [Benchmark]
        public void Test_RemoveElement_ByLinq1() => Solution.RemoveElementByLinq(_arr10, 3);

        [Benchmark]
        public void Test_RemoveElement_ByLinq2() => Solution.RemoveElementByLinq(_arr20, 3);

        [Benchmark]
        public void Test_RemoveElement_ByLinq3() => Solution.RemoveElementByLinq(_arr30, 3);
    }
}

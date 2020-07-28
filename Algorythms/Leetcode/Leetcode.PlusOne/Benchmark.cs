using BenchmarkDotNet.Attributes;

namespace Leetcode.PlusOne
{
    [MemoryDiagnoser]
    [RankColumn]
    public class Benchmark
    {
        private static readonly int[] Array10 =
        {
            1,2,3,4,5,6,7,8,9,9
        };
        
        private static readonly int[] Array20 =
        {
            1,2,3,4,5,6,7,8,9,9,9,9,9,9,9,9,9,9,9,9
        };
        
        private static readonly int[] Array40 =
        {
            1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40
        };
        
        
        [Benchmark]
        public void TryTestPlusOne1() => Solution.PlusOne1(Array10);

        [Benchmark]
        public void TryTestPlusOne2() => Solution.PlusOne1(Array20);

        [Benchmark]
        public void TryTestPlusOne3() => Solution.PlusOne1(Array40);

        [Benchmark]
        public void TryTestPlusOne4() => Solution.PlusOne2(Array10);

        [Benchmark]
        public void TryTestPlusOne5() => Solution.PlusOne2(Array20);

        [Benchmark]
        public void TryTestPlusOne6() => Solution.PlusOne2(Array40);

        [Benchmark]
        public void TryTestPlusOne7() => Solution.PlusOne3(Array10);

        [Benchmark]
        public void TryTestPlusOne8() => Solution.PlusOne3(Array20);

        [Benchmark]
        public void TryTestPlusOne9() => Solution.PlusOne3(Array40);

        [Benchmark]
        public void TryTestPlusOneByLinq1() => Solution.PlusOneByLinq(Array10);

        [Benchmark]
        public void TryTestPlusOneByLinq2() => Solution.PlusOneByLinq(Array20);

        [Benchmark]
        public void TryTestPlusOneByLinq3() => Solution.PlusOneByLinq(Array40);
    }
}
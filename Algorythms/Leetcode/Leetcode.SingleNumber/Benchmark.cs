using BenchmarkDotNet.Attributes;

namespace Leetcode.SingleNumber
{
    [MemoryDiagnoser]
    [RankColumn]
    public class Benchmark
    {
        private readonly int[] _arr1 =
        {
            4, 1, 2, 1, 2, 3, 5, 3, 5, 8
        };
        
        private readonly int[] _arr2 =
        {
            4, 1, 2, 1, 2, 3, 5, 3, 5, 8, 8, 9, 9, 6, 6, 7, 7, 2, 2, 8
        };

        [Benchmark]
        public void Test_SingleNumberByBitwise_1() => Solution.SingleNumberByBitwise(_arr1);

        [Benchmark]
        public void Test_SingleNumberByBitwise_2() => Solution.SingleNumberByBitwise(_arr2);

        [Benchmark]
        public void Test_SingleNumber_1() => Solution.SingleNumber(_arr1);

        [Benchmark]
        public void Test_SingleNumber_2() => Solution.SingleNumber(_arr2);

        [Benchmark]
        public void Test_SingleNumberByLinq_1() => Solution.SingleNumberByLinq(_arr1);

        [Benchmark]
        public void Test_SingleNumberByLinq_2() => Solution.SingleNumberByLinq(_arr2);
    }
}

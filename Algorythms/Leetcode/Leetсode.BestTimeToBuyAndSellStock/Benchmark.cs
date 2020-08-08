using BenchmarkDotNet.Attributes;

namespace Leetсode.BestTimeToBuyAndSellStock
{
    [MemoryDiagnoser]
    [RankColumn]
    public class Benchmark
    {
        private readonly int[] _arr10 =
        {
            7, 1, 5, 3, 6, 4, 2, 6, 8, 9
        };

        private readonly int[] _arr20 =
        {
            7, 1, 5, 3, 6, 4, 2, 6, 8, 9, 12, 16, 33, 19, 16, 25, 14, 17, 24, 26
        };

        [Benchmark]
        public void Test_MaxProfit1() => Solution.MaxProfit(_arr10);

        [Benchmark]
        public void Test_MaxProfit2() => Solution.MaxProfit(_arr20);

        [Benchmark]
        public void Test_MaxProfitByDp1() => Solution.MaxProfitByDp(_arr10);

        [Benchmark]
        public void Test_MaxProfitByDP2() => Solution.MaxProfitByDp(_arr20);
    }
}

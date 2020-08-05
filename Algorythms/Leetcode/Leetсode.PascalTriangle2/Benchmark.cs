using BenchmarkDotNet.Attributes;

namespace Leetсode.PascalTriangle2
{
    [MemoryDiagnoser]
    [RankColumn]
    public class Benchmark
    {
        [Benchmark]
        public void Test_GetRow_1() => Solution.GetRow(10);

        [Benchmark]
        public void Test_GetRow_2() => Solution.GetRow(20);

        [Benchmark]
        public void Test_GetRowByList_1() => Solution.GetRowByList(10);

        [Benchmark]
        public void Test_GetRowByList_2() => Solution.GetRowByList(20);

        [Benchmark]
        public void Test_GetRowByDp_1() => Solution.GetRowByDp(10);

        [Benchmark]
        public void Test_GetRowByDp_2() => Solution.GetRowByDp(20);

        [Benchmark]
        public void Test_GetRowByRecursion_1() => Solution.GetRowByRecursion(10);

        [Benchmark]
        public void Test_GetRowByRecursion_2() => Solution.GetRowByRecursion(20);
    }
}

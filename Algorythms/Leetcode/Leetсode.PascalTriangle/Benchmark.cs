using BenchmarkDotNet.Attributes;

namespace Leetсode.PascalTriangle
{
    [MemoryDiagnoser]
    [RankColumn]
    public class Benchmark
    {
        [Benchmark]
        public void TestGenerateByD1() => Solution.GenerateByDp(10);

        [Benchmark]
        public void TestGenerateByDp2() => Solution.GenerateByDp(20);

        [Benchmark]
        public void TestGenerate1() => Solution.Generate(10);

        [Benchmark]
        public void TestGenerate2() => Solution.Generate(20);

        [Benchmark]
        public void TestGenerateByRecursion1() => Solution.GenerateByRecursion(10);

        [Benchmark]
        public void TestGenerateByRecursion2() => Solution.GenerateByRecursion(20);

        [Benchmark]
        public void TestGenerateByList1() => Solution.GenerateByList(10);

        [Benchmark]
        public void TestGenerateByList2() => Solution.GenerateByList(20);
    }
}

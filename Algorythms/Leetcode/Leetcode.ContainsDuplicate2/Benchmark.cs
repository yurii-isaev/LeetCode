using BenchmarkDotNet.Attributes;

namespace Leetcode.ContainsDuplicate2
{
    [MemoryDiagnoser]
    [RankColumn]
    public class Benchmark
    {
        private readonly int[] _arr10 =
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 1
        };
        
        private readonly int[] _arr20 =
        {
            1, 2, 3, 4, 5, 6, 7, 8, 19, 15, 18, 1, 25, 26, 27, 30, 35, 38, 39, 40
        };

        [Benchmark]
        public void Test_IsContainsDuplicate_BySet1()
        {
            Solution.IsContainsDuplicateBySet(_arr10, 2);
        }

        [Benchmark]
        public void Test_IsContainsDuplicate_BySet2()
        {
            Solution.IsContainsDuplicateBySet(_arr20, 4);
        }

        [Benchmark]
        public void Test_IsContainsDuplicate_ByDict1()
        {
            Solution.IsContainsDuplicateByDict(_arr10, 2);
        }

        [Benchmark]
        public void Test_IsContainsDuplicate_ByDict2()
        {
            Solution.IsContainsDuplicateByDict(_arr20, 4);
        }
    }
}

using BenchmarkDotNet.Attributes;

namespace Leetcode.ContainsDuplicate
{
    [MemoryDiagnoser]
    [RankColumn]
    public class Benchmark
    {
        private readonly int[] _arr10 =
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 9
        };

        private readonly int[] _arr20 =
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20
        };

        [Benchmark]
        public void Test_IsContainsDuplicate_ByFor1()
        {
            Solution.IsContainsDuplicateByFor(_arr10);
        }

        [Benchmark]
        public void Test_IsContainsDuplicate_ByFor2()
        {
            Solution.IsContainsDuplicateByFor(_arr20);
        }

        [Benchmark]
        public void Test_IsContainsDuplicate_ByList1()
        {
            Solution.IsContainsDuplicateByList(_arr10);
        }

        [Benchmark]
        public void Test_IsContainsDuplicate_ByList2()
        {
            Solution.IsContainsDuplicateByList(_arr20);
        }

        [Benchmark]
        public void Test_IsContainsDuplicate_ByHashSet1()
        {
            Solution.IsContainsDuplicateByHashSet(_arr10);
        }

        [Benchmark]
        public void Test_IsContainsDuplicate_ByHashSet2()
        {
            Solution.IsContainsDuplicateByHashSet(_arr20);
        }

        [Benchmark]
        public void Test_IsContainsDuplicate_ByForeach1()
        {
            Solution.IsContainsDuplicateByForeach(_arr10);
        }

        [Benchmark]
        public void Test_IsContainsDuplicate_ByForeach2()
        {
            Solution.IsContainsDuplicateByForeach(_arr20);
        }

        [Benchmark]
        public void Test_IsContainsDuplicate_ByLinq1()
        {
            Solution.IsContainsDuplicateByLinq(_arr10);
        }

        [Benchmark]
        public void Test_IsContainsDuplicate_ByLinq2()
        {
            Solution.IsContainsDuplicateByLinq(_arr20);
        }

        [Benchmark]
        public void Test_IsContainsDuplicate_ByDictionary1()
        {
            Solution.IsContainsDuplicateByDictionary(_arr10);
        }

        [Benchmark]
        public void Test_IsContainsDuplicate_ByDictionary2()
        {
            Solution.IsContainsDuplicateByDictionary(_arr20);
        }
    }
}

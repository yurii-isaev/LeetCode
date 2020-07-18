using BenchmarkDotNet.Attributes;

namespace Leetcode.RemoveDuplicatesFromSortedArray
{
    [MemoryDiagnoser]
    [RankColumn]
    public class Benchmark
    {
        private readonly int[] _arr10 = {1, 1, 2, 2, 3, 3, 4, 4, 4, 5};
        
        private readonly int[] _arr20 =
        {
            1, 1, 2, 2, 3, 3, 4, 4, 4, 5, 5, 5, 6, 6, 7, 7, 8, 8, 8, 8
        };

        private readonly int[] _arr30 =
        {
            1, 1, 2, 2, 3, 3, 4, 4, 4, 5, 5, 5, 6, 6, 7, 7, 8, 8, 8, 8, 8, 8, 8, 8, 8, 9, 9, 9, 9, 9
        };

        [Benchmark]
        public void Test_RemoveDuplicatesBy_For1()
        {
            Solution.RemoveDuplicatesByFor(_arr10);
        }

        [Benchmark]
        public void Test_RemoveDuplicatesBy_For2()
        {
            Solution.RemoveDuplicatesByFor(_arr20);
        }

        [Benchmark]
        public void Test_RemoveDuplicatesBy_For3()
        {
            Solution.RemoveDuplicatesByFor(_arr30);
        }

        [Benchmark]
        public void Test_RemoveDuplicatesBy_Foreach1()
        {
            Solution.RemoveDuplicatesByForeach(_arr10);
        }

        [Benchmark]
        public void Test_RemoveDuplicatesBy_Foreach2()
        {
            Solution.RemoveDuplicatesByForeach(_arr20);
        }

        [Benchmark]
        public void Test_RemoveDuplicatesBy_Foreach3()
        {
            Solution.RemoveDuplicatesByForeach(_arr30);
        }

        [Benchmark]
        public void Test_RemoveDuplicatesBy_HashSet1()
        {
            Solution.RemoveDuplicatesByHashSet(_arr10);
        }

        [Benchmark]
        public void Test_RemoveDuplicatesBy_HashSet2()
        {
            Solution.RemoveDuplicatesByHashSet(_arr20);
        }

        [Benchmark]
        public void Test_RemoveDuplicatesBy_HashSet3()
        {
            Solution.RemoveDuplicatesByHashSet(_arr30);
        }
    }
}

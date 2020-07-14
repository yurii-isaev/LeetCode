using BenchmarkDotNet.Attributes;

namespace Leetcode.TwoSumLessThanK
{
    [MemoryDiagnoser]
    [RankColumn]
    public class Benchmark
    {
        private readonly int[] _arr10 =
        {
            87, 47, 78, 82, 6, 37, 98, 18, 92, 3
        };

        private readonly int[] _arr20 =
        {
            87, 47, 78, 82, 5, 37, 98, 18, 92, 3, 83, 76, 99, 39, 10, 74, 24, 93, 55, 85
        };

        [Benchmark]
        public void Test_GetTwoSumLessThankByBy_ShellSort1()
        {
            Solution.GetTwoSumLessThanKByShellSort(_arr10, 9);
        }

        [Benchmark]
        public void Test_GetTwoSumLessThankByBy_ShellSort2()
        {
            Solution.GetTwoSumLessThanKByShellSort(_arr20, 9);
        }

        [Benchmark]
        public void Test_GetTwoSumLessThanKBy_QuickSort1()
        {
            Solution.GetTwoSumLessThanKByQuickSort(_arr10, 9);
        }

        [Benchmark]
        public void Test_GetTwoSumLessThanKBy_QuickSort2()
        {
            Solution.GetTwoSumLessThanKByQuickSort(_arr20, 9);
        }

        [Benchmark]
        public void Test_GetTwoSumLessThanKBy_InsertionSort1()
        {
            Solution.GetTwoSumLessThanKByInsertionSort(_arr10, 9);
        }

        [Benchmark]
        public void Test_GetTwoSumLessThanKBy_InsertionSort2()
        {
            Solution.GetTwoSumLessThanKByInsertionSort(_arr20, 9);
        }

        [Benchmark]
        public void Test_GetTwoSumLessThanKBy_Linq1()
        {
            Solution.GetTwoSumLessThanKByLinq(_arr10, 9);
        }

        [Benchmark]
        public void Test_GetTwoSumLessThanKBy_Linq2()
        {
            Solution.GetTwoSumLessThanKByLinq(_arr20, 9);
        }

        [Benchmark]
        public void Test_GetTwoSumLessThankBy_MergeSort1()
        {
            Solution.GetTwoSumLessThanKByMergeSort(_arr10, 9);
        }

        [Benchmark]
        public void Test_GetTwoSumLessThankBy_MergeSort2()
        {
            Solution.GetTwoSumLessThanKByMergeSort(_arr20, 9);
        }
    }
}

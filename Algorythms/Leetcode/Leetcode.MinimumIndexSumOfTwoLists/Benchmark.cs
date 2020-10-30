using BenchmarkDotNet.Attributes;

namespace Leetcode.MinimumIndexSumOfTwoLists
{
    [MemoryDiagnoser]
    [RankColumn]
    public class Benchmark
    {
        private readonly string[] _arr1 =
        {
            "Shogun", "Tapioca Express", "Burger King", "KFC"
        };

        private readonly string[] _arr2 =
        {
            "Piatti", "The Grill", "Steakhouse", "Shogun"
        };

        private readonly string[] _arr3 =
        {
            "Shogun", "Express", "King", "KFC", "Tapioca", "Burger", "KFC", "Grill"
        };

        private readonly string[] _arr4 =
        {
            "Tapioca", "Burger", "KFC", "Grill", "Shogun", "Express", "King", "KFC"
        };

        private readonly string[] _arr5 =
        {
            "P", "G", "S", "O", "A", "P", "F", "C", "P", "G", "S", "O", "A", "P", "F", "C"
        };

        private readonly string[] _arr6 =
        {
            "S", "T", "B", "K", "A", "P", "F", "C", "S", "T", "B", "K", "A", "P", "F", "C"
        };

        [Benchmark]
        public void Test_FindRestaurant_1() => Solution.FindRestaurant(_arr1, _arr2);

        [Benchmark]
        public void Test_FindRestaurant_2() => Solution.FindRestaurant(_arr3, _arr4);

        [Benchmark]
        public void Test_FindRestaurant_3() => Solution.FindRestaurant(_arr5, _arr6);
    }
}

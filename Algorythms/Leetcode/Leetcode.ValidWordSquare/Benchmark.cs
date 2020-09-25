using System.Collections.Generic;
using BenchmarkDotNet.Attributes;

namespace Leetcode.ValidWordSquare
{
    [MemoryDiagnoser]
    [RankColumn]
    public class Benchmark
    {
        private readonly List<string> _list1 = new List<string>()
        {
            "ball", "area", "read", "lady"
        };

        private readonly List<string> _list2 = new List<string>()
        {
            "ball", "area", "read", "lady", "ball", "area", "read", "lady"
        };

        private readonly List<string> _list4 = new List<string>()
        {
            "ball", "area", "read", "lady", "ball", "area", "read", "lady",
            "ball", "area", "read", "lady", "ball", "area", "read", "lady"
        };

        [Benchmark]
        public void Test_IsValidWordSquare_1() => Solution.IsValidWordSquare(_list1);

        [Benchmark]
        public void Test_IsValidWordSquare_2() => Solution.IsValidWordSquare(_list2);

        [Benchmark]
        public void Test_IsValidWordSquare_3() => Solution.IsValidWordSquare(_list4);

        [Benchmark]
        public void Test_IsValidWordSquareByStringBuilder_1() => Solution.IsValidWordSquareByStringBuilder(_list1);

        [Benchmark]
        public void Test_IsValidWordSquareByStringBuilder_2() => Solution.IsValidWordSquareByStringBuilder(_list2);

        [Benchmark]
        public void Test_IsValidWordSquareByStringBuilder_3() => Solution.IsValidWordSquareByStringBuilder(_list4);
    }
}

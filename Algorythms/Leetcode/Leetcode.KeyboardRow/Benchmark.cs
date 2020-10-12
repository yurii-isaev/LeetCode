using BenchmarkDotNet.Attributes;

namespace Leetcode.KeyboardRow
{
    [MemoryDiagnoser]
    [RankColumn]
    public class Benchmark
    {
        private readonly string[] _words5 =
        {
            "Hello", "Alaska", "Dad", "Peace", "Omk"
        };

        private readonly string[] _words10 =
        {
            "Hello", "Alaska", "Dad", "Peace", "Omk", "Hello", "Alaska", "Dad", "Peace", "Omk"
        };

        private readonly string[] _words20 =
        {
            "Hello", "Alaska", "Dad", "Peace", "Omk", "Hello", "Alaska", "Dad", "Peace", "Omk",
            "Hello", "Alaska", "Dad", "Peace", "Omk", "Hello", "Alaska", "Dad", "Peace", "Omk"
        };

        [Benchmark]
        public void Test_FindWords_1() => Solution.FindWords1(_words5);

        [Benchmark]
        public void Test_FindWords_2() => Solution.FindWords1(_words10);

        [Benchmark]
        public void Test_FindWords_3() => Solution.FindWords1(_words20);

        [Benchmark]
        public void Test_FindWords_4() => Solution.FindWords2(_words5);

        [Benchmark]
        public void Test_FindWords_5() => Solution.FindWords2(_words10);

        [Benchmark]
        public void Test_FindWords_6() => Solution.FindWords2(_words20);

        [Benchmark]
        public void Test_FindWords_7() => Solution.FindWords3(_words5);

        [Benchmark]
        public void Test_FindWords_8() => Solution.FindWords3(_words10);

        [Benchmark]
        public void Test_FindWords_9() => Solution.FindWords3(_words20);

        [Benchmark]
        public void Test_FindWords_10() => Solution.FindWords4(_words5);

        [Benchmark]
        public void Test_FindWords_11() => Solution.FindWords4(_words10);

        [Benchmark]
        public void Test_FindWords_12() => Solution.FindWords4(_words20);

        [Benchmark]
        public void Test_FindWords_13() => Solution.FindWords5(_words5);

        [Benchmark]
        public void Test_FindWords_14() => Solution.FindWords5(_words10);

        [Benchmark]
        public void Test_FindWords_15() => Solution.FindWords5(_words20);
    }
}

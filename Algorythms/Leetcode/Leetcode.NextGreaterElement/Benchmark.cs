using BenchmarkDotNet.Attributes;

namespace Leetcode.NextGreaterElement
{
    [MemoryDiagnoser]
    [RankColumn]
    public class Benchmark
    {
        private readonly int[] _nums1 = {4, 1, 2, 2, 6};
        private readonly int[] _nums2 = {1, 3, 4, 2, 6};
        private readonly int[] _nums3 = {1, 3, 4, 2, 6, 5, 4, 2, 4, 5};
        private readonly int[] _nums4 = {1, 3, 4, 2, 6, 3, 1, 8, 4, 1};
        private readonly int[] _nums5 = {1, 3, 4, 2, 6, 3, 1, 8, 4, 1, 1, 3, 4, 2, 6, 3, 1, 8, 4, 1};
        private readonly int[] _nums6 = {1, 3, 4, 2, 6, 3, 1, 8, 4, 1, 8, 7, 5, 3, 4, 2, 4, 1, 5, 6};

        [Benchmark]
        public void Test_NextGreaterElement_1() => Solution.NextGreaterElement1(_nums1, _nums2);

        [Benchmark]
        public void Test_NextGreaterElement_2() => Solution.NextGreaterElement1(_nums3, _nums4);

        [Benchmark]
        public void Test_NextGreaterElement_3() => Solution.NextGreaterElement1(_nums5, _nums6);

        [Benchmark]
        public void Test_NextGreaterElement_4() => Solution.NextGreaterElement2(_nums1, _nums2);

        [Benchmark]
        public void Test_NextGreaterElement_5() => Solution.NextGreaterElement2(_nums3, _nums4);

        [Benchmark]
        public void Test_NextGreaterElement_6() => Solution.NextGreaterElement2(_nums5, _nums6);

        [Benchmark]
        public void Test_NextGreaterElement_7() => Solution.NextGreaterElement3(_nums1, _nums2);

        [Benchmark]
        public void Test_NextGreaterElement_8() => Solution.NextGreaterElement3(_nums3, _nums4);

        [Benchmark]
        public void Test_NextGreaterElement_9() => Solution.NextGreaterElement3(_nums5, _nums6);

        [Benchmark]
        public void Test_NextGreaterElement_10() => Solution.NextGreaterElement4(_nums1, _nums2);

        [Benchmark]
        public void Test_NextGreaterElement_11() => Solution.NextGreaterElement4(_nums3, _nums4);

        [Benchmark]
        public void Test_NextGreaterElement_12() => Solution.NextGreaterElement4(_nums5, _nums6);
    }
}

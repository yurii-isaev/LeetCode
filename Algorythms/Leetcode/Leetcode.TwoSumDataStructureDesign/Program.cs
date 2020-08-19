using System;
using BenchmarkDotNet.Running;

namespace Leetcode.TwoSumDataStructureDesign
{
    public static class Program
    {
        private static void Main()
        {
            BenchmarkRunner.Run<Benchmark>();

            DictionarySolution.Add(1);
            DictionarySolution.Add(3);
            DictionarySolution.Add(5);
            
            Console.WriteLine("Find(4):{0}", DictionarySolution.IsFind1(0));
        }
    }
}

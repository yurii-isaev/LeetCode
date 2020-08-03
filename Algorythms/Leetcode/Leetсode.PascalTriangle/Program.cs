using System;
using BenchmarkDotNet.Running;

namespace Leetсode.PascalTriangle
{
    public static class Program
    {
        private static void Main()
        {
            BenchmarkRunner.Run<Benchmark>();

        var solutionList = Solution.GenerateByDp(10);
        // Floyd`s triangle form.
        for (var i = solutionList.Count - 1; i >= 0; i--)
        {
            for (var j = 0; j < solutionList[i].Count; j++)
            {
                Console.Write("{0,-5}", solutionList[i][j]);
            }
        
            Console.WriteLine();
            Console.WriteLine();
        }
        
        // Pascal's Triangle form.
        for (var z = 0; z < solutionList.Count; z++)
        {
            // var value = 1;
            for (var y = 0; y < solutionList.Count - z; y++)
            {
                Console.Write("   ");
            }
        
            for (var x = 0; x <= solutionList[z].Count - 1; x++)
            {
                Console.Write("   {0:D}  ", solutionList[z][x]); //value
                //value = value * (z - x) / (x + 1);
            }
        
            Console.WriteLine();
        }
         }
    }
}

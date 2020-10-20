using BenchmarkDotNet.Running;

namespace Leetcode.ReshapeMatrix
{
    public static class Program
    {
        private static void Main() => BenchmarkRunner.Run<Benchmark>();

        // private static int[][] _array2 = {new[] { 1, 2 }, new[] { 3, 4 }};
        //
        // private static void Main()
        // {
        //     var matrix = Solution.MatrixReshape1(_array2, 2, 4);
        //
        //     for (var i = ((ICollection)matrix).Count - 1; i >= 0; i--)
        //     {
        //         for (var j = 0; j < ((ICollection)matrix[i]).Count; j++)
        //         {
        //             Console.Write("{0,-5}", matrix[i][j]);
        //         }
        //         Console.WriteLine();
        //     }
        // }
    }
}

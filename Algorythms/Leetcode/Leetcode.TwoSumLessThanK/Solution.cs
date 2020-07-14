using System;
using System.Linq;

namespace Leetcode.TwoSumLessThanK
{
    public static class Solution
    {
        /*
         1099. Two Sum Less Than K (https://leetcode.com/problems/two-sum-less-than-k/):
         
         Description:
         Given an array A of integers and integer K,
         return the maximum S such that there exists i < j with A[i] + A[j] = S and S < K.
         If no i, j exist satisfying this equation, return -1.
         
         Example:
         Input: nums = [34,23,1,24,75,33,54,8], target = 60
         Output: 58
         Explanation: 
         We can use 34 and 24 to sum 58 which is less than 60.
         */

        // ---------------------------------------------------------------------- //

        // Time complexity:  O(n). 
        // Space complexity: O(n).
        // Data input: x ->     performance: 70 ns;  memory: _ B.
        // Data input: x * 2 -> performance: 160 ns; memory: _ B.
        public static int GetTwoSumLessThanKByShellSort(int[] arr, int k)
        {
            if (arr == null || arr.Length == 0) return -1;
            var arrS = ShellSort(arr);
            var res = -1;
            var start = 0;
            var end = arr.Length - 1;

            while (start < end)
            {
                var sum = arrS[start] + arrS[end];
                if (k > sum)
                {
                    res = Math.Max(res, sum);
                    start++;
                }
                else
                {
                    end--;
                }
            }

            return res;
        }

        private static int[] ShellSort(int[] arr)
        {
            var step = arr.Length / 2;

            while (step > 0)
            {
                for (var i = 0; i < (arr.Length - step); i++)
                {
                    var j = i;
                    while ((j >= 0) && (arr[j] > arr[j + step]))
                    {
                        var tmp = arr[j];
                        arr[j] = arr[j + step];
                        arr[j + step] = tmp;
                        j -= step;
                    }
                }

                step /= 2;
            }

            return arr;
        }

        // Time complexity:  O(n). 
        // Space complexity: O(n).
        // Data input: x ->     performance: 170 ns; memory: _ B.
        // Data input: x * 2 -> performance: 600 ns; memory: _ B.
        public static int GetTwoSumLessThanKByQuickSort(int[] arr, int k)
        {
            if (arr == null || arr.Length == 0) return -1;
            var arrS = QuickSort(arr);
            var res = -1;
            var i = 0;
            var j = arr.Length - 1;

            while (i < j)
            {
                var sum = arrS[i] + arrS[j];
                if (k > sum)
                {
                    res = Math.Max(res, sum);
                    i++;
                }
                else
                {
                    j--;
                }
            }

            return res;
        }

        // Method for swapping array elements.
        private static void Swap(ref int x, ref int y)
        {
            var t = x;
            x = y;
            y = t;
        }

        // Method that returns the index of the pivot element.
        private static int Partition(int[] array, int minIndex, int maxIndex)
        {
            var pivot = minIndex - 1;

            for (var i = minIndex; i < maxIndex; i++)
            {
                if (array[i] < array[maxIndex])
                {
                    pivot++;
                    Swap(ref array[pivot], ref array[i]);
                }
            }

            pivot++;
            Swap(ref array[pivot], ref array[maxIndex]);
            return pivot;
        }

        // Quick sort.
        private static int[] QuickSort(int[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex) return array;
            var pivotIndex = Partition(array, minIndex, maxIndex);
            QuickSort(array, minIndex, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, maxIndex);
            return array;
        }

        private static int[] QuickSort(int[] array)
        {
            return QuickSort(array, 0, array.Length - 1);
        }

        // Time complexity:  O(n). 
        // Space complexity: O(n).
        // Data input: x ->     performance:  90 ns; memory:  64 B.
        // Data input: x * 2 -> performance: 240 ns; memory: 104 B.
        public static int GetTwoSumLessThanKByInsertionSort(int[] arr, int k)
        {
            if (arr == null || arr.Length == 0) return -1;
            var arrS = InsertionSort(arr);
            var res = -1;
            var i = 0;
            var j = arr.Length - 1;

            while (i < j)
            {
                var sum = arrS[i] + arrS[j];
                if (k > sum)
                {
                    res = Math.Max(res, sum);
                    i++;
                }
                else
                {
                    j--;
                }
            }

            return res;
        }

        private static int[] InsertionSort(int[] arr)
        {
            var res = new int[arr.Length];

            for (var i = 0; i < arr.Length; i++)
            {
                var j = i;
                while (j > 0 && res[j - 1] > arr[i])
                {
                    res[j] = res[j - 1];
                    j--;
                }

                res[j] = arr[i];
            }

            return res;
        }

        // Time complexity:  O(n).
        // Space complexity: O(n).
        // Data input: x ->     performance: 680 ns; memory: 520 B.
        // Data input: x * 2 -> performance: 1.3 us; memory: 680 B.
        public static int GetTwoSumLessThanKByLinq(int[] arr, int k)
        {
            if (arr == null || arr.Length == 0) return -1;
            var arrS = arr.OrderBy(x => x).ToArray();
            var res = -1;
            var i = 0;
            var j = arr.Length - 1;

            while (i < j)
            {
                var sum = arrS[i] + arrS[j];
                if (k > sum)
                {
                    res = Math.Max(res, sum);
                    i++;
                }
                else
                {
                    j--;
                }
            }

            return res;
        }

        // Time complexity:  O(n). 
        // Space complexity: O(n).
        // Data input: x ->     performance: 2.1 us; memory: 1856 B.
        // Data input: x * 2 -> performance: 4.5 us; memory: 4040 B.
        public static int GetTwoSumLessThanKByMergeSort(int[] arr, int k)
        {
            if (arr == null || arr.Length == 0) return -1;
            var arrS = MergeSort(arr);
            var res = -1;
            var i = 0;
            var j = arr.Length - 1;

            while (i < j)
            {
                var sum = arrS[i] + arrS[j];
                if (k > sum)
                {
                    res = Math.Max(res, sum);
                    i++;
                }
                else
                {
                    j--;
                }
            }

            return res;
        }

        private static int[] MergeSort(int[] a)
        {
            if (a.Length == 1) return a;
            var mid = a.Length / 2;

            return Merge(MergeSort(a.Take(mid).ToArray()), MergeSort(a.Skip(mid).ToArray()));
        }

        private static int[] Merge(int[] left, int[] right)
        {
            var lp = 0;
            var rp = 0;
            var merge = new int[left.Length + right.Length];

            for (var i = 0; i < merge.Length; i++)
            {
                if (lp < left.Length && rp < right.Length)
                {
                    if (left[lp] > right[rp])
                    {
                        merge[i] = right[rp++];
                    }
                    else
                    {
                        merge[i] = left[lp++];
                    }
                }
                else if (lp < left.Length)
                {
                    merge[i] = left[lp++];
                }
                else
                {
                    merge[i] = right[rp++];
                }
            }

            return merge;
        }
    }
}

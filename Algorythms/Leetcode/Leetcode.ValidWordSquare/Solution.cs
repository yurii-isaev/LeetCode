using System.Collections.Generic;
using System.Text;

namespace Leetcode.ValidWordSquare
{
    public static class Solution
    {
        /*
         422. Valid Word Square (https://leetcode.com/problems/valid-word-square/):
         
         Description:
         Given a sequence of words, check whether it forms a valid word square.
         A sequence of words forms a valid word square if the kth row and column read the exact same string,
         where 0 ≤ k < max(numRows, numColumns).
         
         Note:
         The number of words given is at least 1 and does not exceed 500.
         Word length will be at least 1 and does not exceed 500.
         Each word contains only lowercase English alphabet a-z.
         
         Example 1:
         Input:["abcd","bnrt","crmy","dtye"].
         Output: true.
         Explanation:
         The first row and first column both read "abcd".
         The second row and second column both read "bnrt".
         The third row and third column both read "crmy".
         The fourth row and fourth column both read "dtye".
         Therefore, it is a valid word square.
         
         Example 2:
         Input: ["ball","area","read","lady"]
         Output: false.         
         Explanation:
         The third row reads "read" while the third column reads "lead".
         Therefore, it is NOT a valid word square.
         */

        // ---------------------------------------------------------------------- //
        
        // Time complexity:  O(1). 
        // Space complexity: O(1).
        // Data input: x ->     performance: 16 ns; memory: _ B.
        // Data input: x * 2 -> performance: 16 ns; memory: _ B.
        // Data input: x * 4 -> performance: 16 ns; memory: _ B.
        public static bool IsValidWordSquare(List<string> words)
        {
            for (var i = 0; i < words.Count; i++)
            {
                for (var j = 0; j < words[i].Length; j++)
                {
                    if (i >= words.Count || j >= words.Count || j >= words[i].Length || i >= words[j].Length)
                        return false;

                    if (words[i][j] != words[j][i]) return false;
                }
            }

            return true;
        }

        // Time complexity:  O(n). 
        // Space complexity: O(n).
        // Data input: x ->     performance:  50 ns; memory: 136 B.
        // Data input: x * 2 -> performance:  80 ns; memory: 144 B.
        // Data input: x * 4 -> performance: 120 ns; memory: 160 B.
        public static bool IsValidWordSquareByStringBuilder(List<string> words)
        {
            for (var i = 0; i < words.Count; i++)
            {
                var sb = new StringBuilder();
                
                for (var j = 0; j < words.Count; j++)
                {
                    if (words[j].Length > i) sb.Append(words[j][i]);
                }

                if (!sb.ToString().Equals(words[i])) return false;
            }

            return true;
        }
    }
}
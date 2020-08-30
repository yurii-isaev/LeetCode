using System;

namespace Leetcode.ShortestWordDistance
{
    public static class Solution
    {
        /*
        243. Shortest Word Distance (https://leetcode.com/problems/shortest-word-distance/):
        
        Description:
        Given a list of words and two words, word 1 and word 2.
        Return the shortest distance between these two words in the list.
        
        Example:
        Input: ["practice", "makes", "perfect", "coding", "makes"]
        Input: word1 = “coding”, word2 = “practice”
        Output: 3
        Input: word1 = "makes", word2 = "coding"
        Output: 1
        */
        
        // ---------------------------------------------------------------------- //

        // Time complexity:  O(n).  
        // Space complexity: O(n).
        // Data input: x ->     performance: 30 ns; memory: _ B.
        // Data input: x * 2 -> performance: 60 ns; memory: _ B.
        public static int ShortestDistance(string[] words, string word1, string word2)
        {
            if (words.Length == 0 && word1 == null && word2 == null) return 0;
            int w1 = -1, w2 = -1, distance = int.MaxValue;

            for (var i = 0; i < words.Length; i++)
            {
                if (words[i].Equals(word1))
                {
                    w1 = i;
                    if (w2 != -1) distance = Math.Min(distance, w1 - w2);
                }
                else if (words[i].Equals(word2))
                {
                    w2 = i;
                    
                    if (w1 != -1)
                    {
                        distance = Math.Min(distance, w2 - w1);
                    }
                }
            }

            return distance;
        }
    }
}

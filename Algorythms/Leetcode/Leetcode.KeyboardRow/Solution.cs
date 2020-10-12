using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Leetcode.KeyboardRow
{
    public static class Solution
    {
        /*
         500. Keyboard Row (https://leetcode.com/problems/keyboard-row/):
         
         Description:
         Given an array of strings words, return the words that can be typed using letters of the alphabet
         on only one row of American keyboard like the image below.
        
         In the American keyboard:
         the first row consists of the characters "qwertyuiop",
         the second row consists of the characters "asdfghjkl",
         and the third row consists of the characters "zxcvbnm".
        
         Example:
         Input: words = ["Hello","Alaska","Dad","Peace"]
         Output: ["Alaska","Dad"]
         */

        // ---------------------------------------------------------------------- //
        
        // Time complexity:  O(n). 
        // Space complexity: O(n).
        // Data input: x ->     performance: 310 ns; memory: 256 В.
        // Data input: x * 2 -> performance: 570 ns; memory: 272 В.
        // Data input: x * 4 -> performance: 1.1 us; memory: 392 В.
        public static string[] FindWords1(string[] words)
        {
            var row = new[] {2, 3, 3, 2, 1, 2, 2, 2, 1, 2, 2, 2, 3, 3, 1, 1, 1, 1, 2, 1, 1, 3, 1, 3, 1, 3};
            //a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z
            var answer = new List<string>();

            for (var i = 0; i < words.Length; i++)
            {
                var compare = row[char.ToLower(words[i][0]) - 'a'];
                var found = true;

                for (var j = 1; j < words[i].Length; j++)
                {
                    if (compare != row[char.ToLower(words[i][j]) - 'a'])
                    {
                        found = false;
                        break;
                    }
                }

                if (found) answer.Add(words[i]);
            }

            return answer.ToArray();
        }

        // Time complexity:  O(n). 
        // Space complexity: O(n).
        // Data input: x ->     performance: 1.8 us; memory: 1696 В.
        // Data input: x * 2 -> performance: 3.4 us; memory: 3024 В.
        // Data input: x * 4 -> performance: 6.7 us; memory: 5768 В.
        public static string[] FindWords2(string[] words)
        {
            var option1 = "qwertyuiop";
            var option2 = "asdfghjkl";
            var option3 = "zxcvbnm";
            var result = new List<string>();

            foreach (var word in words)
            {
                var word1 = word.ToLower();
                if (!word1.Where(x => !option1.Contains(x)).Any() ||
                    !word1.Where(x => !option2.Contains(x)).Any() ||
                    !word1.Where(x => !option3.Contains(x)).Any())
                    result.Add(word);
            }

            return result.ToArray();
        }

        // Time complexity:  O(n). 
        // Space complexity: O(n).
        // Data input: x ->     performance: 4.1 us; memory: 5592 B.
        // Data input: x * 2 -> performance: 5.5 us; memory: 7440 B.
        // Data input: x * 4 -> performance: 8.5 us; memory: 11304 B.
        public static string[] FindWords3(string[] words)
        {
            var sets = new List<HashSet<char>>
            {
                new HashSet<char>("qwertyuiopQWERTYUIOP"),
                new HashSet<char>("asdfghjklASDFGHJKL"),
                new HashSet<char>("zxcvbnmZXCVBNM")
            };
            return words.Where(w => sets.Any(s => w.All(s.Contains))).ToArray();
        }

        // Time complexity:  O(n). 
        // Space complexity: O(n).
        // Data input: x ->     performance: 11,6 us; memory: 7560 B.
        // Data input: x * 2 -> performance: 15,7 us; memory: 7744 B.
        // Data input: x * 4 -> performance: 23,3 us; memory: 8200 B.
        public static string[] FindWords4(string[] words)
        {
            var regex = new Regex("^([qwertyuiop]*|[asdfghjkl]*|[zxcvbnm]*)$");
            var list = new List<string>();

            foreach (var word in words)
            {
                if (regex.IsMatch(word.ToLower())) list.Add(word);
            }

            return list.ToArray();
        }

        // Time complexity:  O(n). 
        // Space complexity: O(n).
        // Data input: x ->     performance: 8.6 us; memory: 10704 B.
        // Data input: x * 2 -> performance:  16 us; memory: 21088 B.
        // Data input: x * 4 -> performance:  32 us; memory: 42024 B.
        public static string[] FindWords5(string[] words)
        {
            var rows = new[] {"qwertyuiop", "asdfghjkl", "zxcvbnm"}
                .Select(s => s.ToHashSet());
            return words
                .Where(x => rows.Any(set => x.ToLower()
                .All(set.Contains)))
                .ToArray();
        }
    }
}

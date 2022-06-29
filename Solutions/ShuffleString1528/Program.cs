using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShuffleString1528
{
    class Solution
    {
        //LeetCode Link: https://leetcode.com/problems/shuffle-string/

        /// <summary>
        /// You are given a string s and an integer array indices of the same length. The string s will be shuffled 
        /// such that the character at the ith position moves to indices[i] in the shuffled string.
        ///Return the shuffled string.
        /// </summary>
        /// <param name="s">string to be reordered based upon indices array</param>
        /// <param name="indices">indices to change char locations</param>
        /// <returns>string with char locations changed according to indices array</returns>
        public static string RestoreString(string s, int[] indices)
        {
            StringBuilder output = new StringBuilder(s);
            for(int i = 0; i < indices.Length; i++)
            {
                output[indices[i]] = s[i];
            }
            return output.ToString();

        }

        static void Main(string[] args)
        {
            string s = "codeleet";
            string answer = "leetcode";
            int[] indices = { 4, 5, 6, 7, 0, 2, 1, 3 };
            string output = RestoreString(s, indices);
            bool isTrue = answer.Equals(output);
            Console.WriteLine(output);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{

    class Solution
    {
        /// <summary>
        /// A string s is called good if there are no two different characters in s that have the same frequency.
        ///Given a string s, return the minimum number of characters you need to delete to make s good.
        ///The frequency of a character in a string is the number of times it appears in the string. 
        ///For example, in the string "aab", the frequency of 'a' is 2, while the frequency of 'b' is 1.
        /// </summary>
        /// <param name="s"> string to be checked for the minimum number of chars to be removed to have unique char frequencies</param>
        /// <returns> number of deletions necessary for chars to have unique frequencies</returns>
        public static int MinDeletions(string s)
        {
            Dictionary<char, int> charFrequency = new Dictionary<char, int>();

            //fill in dictionary with frequency of each char
            foreach (char c in s)
            {
                if (!charFrequency.ContainsKey(c))
                    charFrequency.Add(c, 1);
                else
                    charFrequency[c] = charFrequency[c] + 1;
            }

            //make a hashSet to store each unique frequency
            HashSet<int> frequencies = new HashSet<int>();
            int count = 0;

            foreach (char c in charFrequency.Keys)
            {
                int freq = charFrequency[c];
                if (!frequencies.Contains(freq))
                    frequencies.Add(freq);
                else
                {
                    //if frequency exists in hashSet and is greater than 0, decrease frequency val and increase count for chars needed to be deleted
                    while (freq > 0 && frequencies.Contains(freq))
                    {
                        freq--;
                        count++;
                    }
                    if (freq > 0)
                        frequencies.Add(freq);
                }
            }
            return count;
        }

        static void Main(string[] args)
        {
            string test1 = "aab";
            int x = MinDeletions(test1);
            string test2 = "aaabbbcc";
            int y = MinDeletions(test2);
            string test3 = "ceabaacb";
            int z = MinDeletions(test3);
            Console.WriteLine(x + y + z);
        }
    }
}
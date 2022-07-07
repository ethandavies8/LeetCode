using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterleavingString97
{

    //Leetcode link: https://leetcode.com/problems/interleaving-string/

    //This solution uses memoization and recursion

    //Description: Given strings s1, s2, and s3, find whether s3 is formed by an interleaving of s1 and s2.
    //An interleaving of two strings s and t is a configuration where they are divided into non-empty substrings such that:
    //s = s1 + s2 + ... + sn
    //t = t1 + t2 + ... + tm
    //|n - m| <= 1
    //The interleaving is s1 + t1 + s2 + t2 + s3 + t3 + ... or t1 + s1 + t2 + s2 + t3 + s3 + ...
    //Note: a + b is the concatenation of strings a and b.



    class Program
    {
        bool?[,] cache;
        public bool IsInterleave(string s1, string s2, string s3)
        {
            int m = s1.Length, n = s2.Length, k = s3.Length;
            if (m + n != k)
                return false;


            cache = new bool?[s1.Length + 1, s2.Length + 1];

            return Helper(s1, s2, s3, 0, 0, 0);
        }
        private bool Helper(string a, string b, string c, int aIndex, int bIndex, int cIndex)
        {
            if (aIndex == a.Length && bIndex == b.Length && cIndex == c.Length)
            {
                // Success case: reached the end of all strings
                return true;
            }

            if (cache[aIndex, bIndex].HasValue)
            {
                return cache[aIndex, bIndex].Value;
            }

            // Choices:
            // --> If char in c matches char up next in a or b, we can select it from either

            cache[aIndex, bIndex] =
                aIndex < a.Length && a[aIndex] == c[cIndex] && Helper(a, b, c, aIndex + 1, bIndex, cIndex + 1) ||
                bIndex < b.Length && b[bIndex] == c[cIndex] && Helper(a, b, c, aIndex, bIndex + 1, cIndex + 1);

            return cache[aIndex, bIndex].Value;
        }


        static void Main(string[] args)
        {
            String s1 = "aabcc", s2 = "dbbca", s3 = "aadbbbaccc";
           // Console.WriteLine(IsInterleave(s1, s2, s3));

            string a1 = "", a2 = "", a3 = "";
           // Console.WriteLine(IsInterleave(a1, a2, a3));
        }
    }
}

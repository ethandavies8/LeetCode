using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositionsOfLargeGroups
{
    class Solution
    {
        public static IList<IList<int>> LargeGroupPositions(string s)
        {
            int n = s.Length;
            List<IList<int>> results = new List<IList<int>>();

            int left = 0;
            for (int right = 1; right <= n; right++)
            {
                if (right == n || s[right - 1] != s[right])
                {
                    if (right - left > 2)
                        results.Add(new List<int> { left, right - 1 });
                    left = right;
                }
            }

            return results;
        }

        static void Main(string[] args)
        {
            string s = "abbxxxxzzy";
            Console.WriteLine(LargeGroupPositions(s).ToString());
            string otherString = "abc";
            Console.WriteLine(LargeGroupPositions(otherString).ToString());
            string finalString = "abcdddeeeeaabbbcd";
            Console.WriteLine(LargeGroupPositions(finalString).ToString());
        }
    }
}
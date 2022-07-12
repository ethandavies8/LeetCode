using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchSticksToSquare473
{

    //Leetcode link: https://leetcode.com/problems/matchsticks-to-square/

    //Description:
    //You are given an integer array matchsticks where matchsticks[i] is the length of the ith matchstick.
    //You want to use all the matchsticks to make one square. You should not break any stick, but you can link them up, and each matchstick must be used exactly one time.
    //Return true if you can make this square and false otherwise.

    class Program
    {
        public bool Makesquare(int[] matchsticks)
        {
            //check empty edge case
            if (matchsticks == null || matchsticks.Length == 0)
                return false;

            int total = 0;

            foreach (int i in matchsticks)
                total += i;
            //check if summed values are divisible by 4 to make a square
            if (total % 4 != 0)
                return false;
            //sort for optimization
            Array.Sort(matchsticks);

            return dfs(matchsticks, new int[4], matchsticks.Length - 1, total / 4);

        }

        public bool dfs(int[] matchsticks, int[] sum, int index, int target)
        {
            //edge case
            if (index == -1) return true;

            for (int i = 0; i < 4; i++)
            {
                if ((sum[i] + matchsticks[index] > target) || (i > 0 && sum[i] == sum[i - 1])) 
                    continue;

                sum[i] += matchsticks[index];

                if (dfs(matchsticks, sum, index - 1, target)) 
                    return true;
                sum[i] -= matchsticks[index];
            }
            return false;
        }

        static void Main(string[] args)
        {
            int[] matchsticks = { 1, 1, 2, 2, 2 };
            // int[] matchsticks = {3, 3, 3, 3, 4};
            //Console.WriteLine(Makesquare(matchsticks));

        }
    }
}

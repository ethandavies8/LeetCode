using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistributeCandies
{
    class Solution
    {

        //Problem Link: https://leetcode.com/problems/distribute-candies/

        //This solution utilizes a HashMap in order to easily check for duplicate candies.

        //Alice has n candies, where the ith candy is of type candyType[i]. Alice noticed that she started to gain weight, so she visited a doctor.
        //The doctor advised Alice to only eat n / 2 of the candies she has (n is always even). Alice likes her candies very much, and she wants to eat the
        //maximum number of different types of candies while still following the doctor's advice.
        //Given the integer array candyType of length n, return the maximum number of different types of candies she can eat if she only eats n / 2 of them.

        public static int DistributeCandies(int[] candyType)
        {
            //use a HashSet to check for duplicates
            HashSet<int> set = new HashSet<int>();

            //add each unique candy to the set
            for (int i = 0; i < candyType.Length; i++)
            {
                set.Add(candyType[i]);
            }

            //if the number of unique candies is greater than the array length return half the array, since Alice is only allowed to eat n/2 of the candies she has
            if (set.Count >= candyType.Length / 2)
                return candyType.Length / 2;
            //else return the number of unique candies
            return set.Count;
        }

        static void Main(string[] args)
        {
            int[] candyType = { 1, 1, 2, 3 };
            Console.WriteLine(DistributeCandies(candyType).ToString());
        }
    }
}
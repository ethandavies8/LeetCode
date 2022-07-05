using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestConsecutiveSequence128
{
    class Program
    {

        //LeetCode link: https://leetcode.com/problems/longest-consecutive-sequence/

        //runs in O(n) time, space complexity is for a HashMap O(n)

        public static int LongestConsecutive(int[] nums)
        {
            //answer length
            int res = 0;
            HashSet<int> set = new HashSet<int>();

            //add all elements in a set
            foreach (int i in nums)
                set.Add(i);


            foreach(int i in nums)
            {
                //assume value "i" is the center of the sequence in which it is present
                //go left and right to find length of sequence
                int max = 1, prevVal = i - 1, nextVal = i + 1;

                while (set.Contains(prevVal)) //say val = 5, if 4 is present in set
                {
                    max++; //increase sequence length
                    set.Remove(prevVal--); //remove 4 and decrement to 3 and continue
                }

                while (set.Contains(nextVal)) //same for nextVal (6 in example)
                {
                    max++;
                    set.Remove(nextVal++);
                }

                res = Math.Max(res, max); //maintain maximum length
            }
            return res;
        }
        static void Main(string[] args)
        {
            int[] nums = { 100, 4, 200, 1, 3, 2 };
            int result = LongestConsecutive(nums);
            Console.WriteLine(result);

            int[] otherNums = { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 };
            int otherResult = LongestConsecutive(otherNums);
            Console.WriteLine(otherResult);

        }
    }
}

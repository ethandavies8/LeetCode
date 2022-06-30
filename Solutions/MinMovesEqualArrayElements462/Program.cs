using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMovesEqualArrayElements462
{
    class Program
    {
        /// <summary>
        /// Given an integer array nums of size n, return the minimum number of moves required to make all array elements equal.
        ///In one move, you can increment or decrement an element of the array by 1.
        ///Test cases are designed so that the answer will fit in a 32-bit integer.
        /// </summary>
        /// <param name="nums">array to find minumum number of moves to make elements equal</param>
        /// <returns>number of moves necessary to make elements equal</returns>
        public static int MinMoves2(int[] nums)
        {
            int n = nums.Length, steps = 0;
            Array.Sort(nums);
            int median = nums[n / 2];
            for (int i = 0; i < n; i++)
            {
                steps += Math.Abs(nums[i] - median);
            }

            return steps;
        }


        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3 };
            Console.WriteLine(MinMoves2(nums).ToString());
        }
    }

}

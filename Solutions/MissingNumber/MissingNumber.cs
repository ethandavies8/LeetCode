using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingNumber
{
    class Solution
    {
        //Gauss' math method
        public int MissingNumber(int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                // for example, input [0, 1, 3, 4], difference between value and index is [0, 0, 1, 1] 
                sum += nums[i] - i;
            }
            //add differences and subtract from length to get difference
            return nums.Length - sum;
        }

        static void Main(string[] args)
        {
        }
    }
}
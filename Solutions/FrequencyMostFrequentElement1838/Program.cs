using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrequencyMostFrequentElement1838
{


    //Does not work


    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int MaxFrequency(int[] nums, int k)
        {
            Array.Sort(nums);
            int sum = 0, right = 0, left = 0;
            int max = int.MinValue;

            while(right < nums.Length)
            {

                //create sliding window using left and right and checking the answer (max frequency of max element) for each window my condition sum + k < max * (j - i + 1)
                //The sum of the window elements + k should be equal or greater than the product of maxElement of window and the length of the window for the window to have all maxElements in k operations
                //if condition fails, reduce window size by incrementing left pointer, removing smallest element
                sum += nums[right];
                
                while(nums[right] * (right - left + 1) > sum + k)
                {
                    sum -= nums[left];
                    left++;
                }
                max = Math.Max(max, right - left + 1);
                right++;
            }
            return max;
        }


        static void Main(string[] args)
        {
            int[] nums = { 3, 9, 6};
            int k = 2;
            Console.WriteLine(MaxFrequency(nums, k).ToString());

        }
    }
}

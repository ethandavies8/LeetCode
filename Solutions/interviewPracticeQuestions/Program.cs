using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPractice
{

    //Leetcode link: https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/727/

    //This solution uses memoization and recursion

    //Description: Given an integer array nums sorted in non-decreasing order, remove the duplicates in-place ]
    //such that each unique element appears only once. The relative order of the elements should be kept the same. Then return the number of unique elements in nums.

    //solution removes duplicates in place 

    class RemoveDuplicates
    {
        public static void Main(string[] args)
        {
            RemoveDuplicates rd = new RemoveDuplicates();
            int[] nums = { 1, 1, 2 }; // Input array
            int[] expectedNums = { 1, 2 }; // The expected answer with correct length

            int k = rd.removeDuplicates(nums); // Calls your implementation

            if (k == expectedNums.Length)
            {
                for (int i = 0; i < k; i++)
                {
                    if (nums[i] != expectedNums[i])
                    {

                    }
                }
            }
        }
        public int removeDuplicates(int[] nums)
        {
            int k = 1;
            int previouse = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != previouse)
                {
                    nums[k] = nums[i];
                    k++;
                }
                previouse = nums[i];
            }
            return k;
        }
    }
}
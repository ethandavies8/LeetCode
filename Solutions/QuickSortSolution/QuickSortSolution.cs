using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KthLargestElementInArray
{
    class QuickSortSolution
    {
        public static int FindKthLargest(int[] nums, int k)
        {
            QuickSort(nums, 0, nums.Length - 1);
            return nums[nums.Length - k];
        }

        public static void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int partition = Partition(arr, low, high); //get partition point
                QuickSort(arr, low, partition - 1); //recursive call on left subarray
                QuickSort(arr, partition + 1, high); //recursive call on right subarray
            }
        }

        public static int Partition(int[] nums, int low, int high)
        {
            int pivot = nums[high], i = low - 1;
            //We make use of two pointers crawling towards the pivot from the edges of the array to swap
            for (int j = low; j <= high - 1; j++)
            {
                if (nums[j] < pivot)
                {
                    i++;
                    Swap(nums, i, j);
                }
            }
            Swap(nums, i + 1, high);
            return (i + 1);
        }


        public static void Swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }


        static void Main(string[] args)
        {
            int[] nums = new int[] { 2, 1 };
            int k = 2;
            Console.WriteLine(FindKthLargest(nums, k));

        }
    }
}
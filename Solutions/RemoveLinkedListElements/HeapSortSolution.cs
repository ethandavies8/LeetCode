using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KthLargestElementInArray
{
    class HeapSortSolution
    {
        public int FindKthLargest(int[] nums, int k)
        {
            HeapSort(nums, nums.Length);
            return nums[nums.Length - k];
        }

        public static void HeapSort(int[] nums, int n)
        {
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(nums, n, i); //Fixes bottom half as well
            }

            for (int i = n - 1; i >= 0; i--)
            { //Swap last and first indexes, then heapify
                int temp = nums[0];
                nums[0] = nums[i];
                nums[i] = temp;
                Heapify(nums, i, 0);
            }
        }

        public static void Heapify(int[] nums, int n, int i)
        { //Fixes heap structure
            int largest = i, left = 2 * i + 1, right = 2 * i + 2;

            //Find the largest child
            if (left < n && nums[left] > nums[largest]) { largest = left; }
            if (right < n && nums[right] > nums[largest]) { largest = right; }

            //If root isn't largest, swap with whatever child is larger
            if (largest != i)
            {
                int swap = nums[i];
                nums[i] = nums[largest];
                nums[largest] = swap;
                Heapify(nums, n, largest); //Continue downwards
            }
        }
    }
}
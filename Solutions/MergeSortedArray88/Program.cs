using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSortedArray
{
    class MergeSortedArray
    {

        public static int[] Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int len1 = nums1.Length;
            int end_idx = len1 - 1;
            while (n > 0 && m > 0)
            {
                if (nums2[n - 1] >= nums1[m - 1])
                {
                    nums1[end_idx] = nums2[n - 1];
                    n--;
                }
                else
                {
                    nums1[end_idx] = nums1[m - 1];
                    m--;
                }
                end_idx--;
            }
            while (n > 0)
            {
                nums1[end_idx] = nums2[n - 1];
                n--;
                end_idx--;
            }

            return nums1;
        }

    

        static void Main(string[] args)
        {
            int[] nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
            int[] nums2 = new int[] { 2, 5, 6};

            int m = 3;
            int n = 3;

            string result = string.Join(", ", Merge(nums1, m, nums2, n));

            Console.WriteLine(result);

            //Console.WriteLine(Merge(nums1, m, nums2, n).ToString());

        }
    }
}
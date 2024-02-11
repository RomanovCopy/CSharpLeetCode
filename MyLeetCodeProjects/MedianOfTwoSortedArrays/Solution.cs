using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedianOfTwoSortedArrays
{
    internal class Solution
    {
        int[] nums1 = { 1, 2, 3, 4, 5 };
        int[] nums2 = { 7};

        public Solution()
        {
            ;
            Console.WriteLine(FindMedianSortedArrays(nums1, nums2));
            Console.ReadKey();
        }

        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            double mediana = 0;
            List<int> list = new List<int>();
            int[] nums = new int[nums1.Length + nums2.Length];
            nums1.CopyTo(nums, 0);
            nums2.CopyTo(nums, nums1.Length);
            foreach(var num in nums)
            {
                list.Add(num);
            }
            list.Sort();
            if (list.Count % 2 == 0)
                mediana = (double)(list[list.Count / 2-1] + list[list.Count / 2]) / 2.0;
            else
                mediana = list[list.Count / 2 ];

            return mediana;
        }

    }
}

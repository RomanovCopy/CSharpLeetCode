using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_TwoSum
{
    internal class Solution
    {
        internal Solution()
        {
            TwoSum(GenerateArray(10, 0, 20), 35);
        }

        public int[] TwoSum(int[] nums, int target)
        {
            
        }

        private int[] GenerateArray(int size, int min, int max)
        {
            int[] array = new int[size];
            Random random = new Random();
            for(int count = 0; count < size; count++)
            {
                array[count] = random.Next(min, max);
            }
            return array;
        }

        private void 

    }
}

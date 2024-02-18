using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011ContainerWithMostWater
{
    internal class Solution
    {
        public Solution()
        {
            int[] height = { 2, 3, 4, 5, 18, 17, 6 };
            Console.WriteLine( MaxArea(height));
            Console.ReadKey();
        }

        public int MaxArea(int[] height)
        {
            int length = height.Length;
            int[,] dp = new int[length, length];
            int maxArea = 0;
            if (length == 2)
            {
                return Math.Min(height[0], height[1]);
            }

            for (int left = 0; left < length - 1; left++)
            {
                for (int right = left + 1; right < height.Length; right++)
                {
                    if (left + 1 < right)
                    {
                        dp[left, right] = Math.Min(height[left], height[right]) * (right - left);
                        dp[left, right] = Math.Max(dp[left, right], dp[left + 1, right]);
                        dp[left, right] = Math.Max(dp[left, right], dp[left, right - 1]);
                    }

                    maxArea = Math.Max(maxArea, dp[left, right]);
                }
            }

            return maxArea;
        }
    }
}

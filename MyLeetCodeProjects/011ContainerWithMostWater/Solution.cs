using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011ContainerWithMostWater
{
    internal class Solution
    {
        public Solution ( )
        {
            int[ ] height = { 2 , 2 };
            Console.WriteLine( MaxArea( height ) );
            Console.ReadKey( );
        }

        public int MaxArea ( int[ ] heights )
        {
            int maxArea = 0;
            int length = heights.Length;
            if ( length > 1 )
            {
                int left = 0;
                int right = length - 1;
                while ( left < right )
                {
                    int width = Math.Abs( left - right );
                    int height = Math.Min( heights[ left ] , heights[ right ] );
                    int area = width * height;
                    maxArea = area > maxArea ? area : maxArea;
                    if(heights[ left ] < heights[ right ] )
                    {
                        left++;
                    } else if(heights[ right ] < heights[ left ])
                    {
                        right--;
                    } else
                    {
                        left++;
                        right--;
                    }
                }

            }

            return maxArea;
        }
    }
}

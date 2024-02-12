using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007ReverseInteger
{
    internal class Solution
    {
        public Solution()
        {
            Console.WriteLine(Reverse(1324435664));
            Console.ReadKey();
        }

        public int Reverse(int x)
        {
            try
            {
                int result = 0;
                bool negative = x < 0;
                x = Math.Abs(x);
                char[] num = x.ToString().ToCharArray();
                int count = num.Length-1;
                var builder = new StringBuilder("");
                while (count >= 0)
                {
                    builder.Append(num[count]);
                    count--;
                }
                checked
                {
                    result = !negative ? int.Parse(builder.ToString()) : int.Parse(builder.ToString()) * -1;
                }
                return result;
            }
            catch (OverflowException e)
            {
                return 0;
            }
        }
    }
}

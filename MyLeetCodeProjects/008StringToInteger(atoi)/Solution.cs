using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008StringToInteger_atoi_
{
    internal class Solution
    {
        public Solution()
        {
            Console.WriteLine(MyAtoi("-+12"));
            Console.ReadKey();
        }

        public int MyAtoi(string s)
        {
            char[] row = s.Trim().ToCharArray();
            if (s.Length == 0) return 0;
            string number = "";
            bool negative = false;
            int result = 0;
            Span<char> span = new Span<char>(row);
            for(int i = 0; i < span.Length; i++)
            {
                if (i == 0 && (span[i] == '-' || span[i]=='+'))
                {
                    negative = span[i] == '-'?true:false;
                }
                else if (char.IsDigit( span[i]))
                {
                    number += span[i];
                }
                else
                {
                    break;
                }
            }
            try
            {
                checked
                {
                    result = number.Length > 0 ? int.Parse(number) : 0;
                    result *= negative ? -1 : 1;
                }
            }
            catch (OverflowException)
            {
                result = negative ? int.MinValue : int.MaxValue;
            }
            return result;
        }


    }
}

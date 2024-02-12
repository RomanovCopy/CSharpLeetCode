using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZigzagConversion
{
    internal class Solution
    {
        public Solution()
        {
            Console.WriteLine(Convert("PAYPALISHIRING", 2));
            Console.ReadKey();
        }

        public string Convert(string s, int numRows)
        {
            if (numRows == 1) return s;

            string[] rows = new string[numRows];
            int currentRow = 0;
            bool upDown = false;

            foreach (char ch in s)
            {
                rows[currentRow] += ch;

                if (currentRow == 0 || currentRow == numRows - 1)
                {
                    upDown = !upDown;
                }

                currentRow += upDown ? 1 : -1;
            }

            string newRow = "";
            foreach (string row in rows)
            {
                newRow += row;
            }

            return newRow;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009PalindromeNumber
{
    internal class Solution
    {
        public Solution()
        {
            Console.WriteLine( IsPalindrome(1221));
            Console.ReadKey();
        }

        public bool IsPalindrome(int x)
        {
            //исключительные варианты
            if (x < 0 || (x % 10 == 0 && x != 0))
                return false;
            int revertedNumber = 0;//реверсивное число
            //переводим в реверсивное только правую половину исходного числа
            while (x > revertedNumber)
            {
                //ставим последнюю цифру исходного числа в начало реверсивного
                revertedNumber = revertedNumber * 10 + x % 10;
                //удаляем последнюю цифру исходного числа
                x /= 10;
            }
            //если цифр четное колличество, то x == revertedNumber
            //иначе x == revertedNumber / 10
            return x == revertedNumber || x == revertedNumber / 10;
        }
    }
}

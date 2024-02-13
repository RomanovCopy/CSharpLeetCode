using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010RegularExpressionMatching
{
    internal class Solution
    {
        public Solution()
        {
            Console.WriteLine("aa", "a*");
            Console.ReadKey();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="s">входное число</param>
        /// <param name="p">шаблон регулярного выражения</param>
        /// <returns></returns>
        public bool IsMatch(string s, string p)
        {
            bool isMatch = false;
            if (p.Contains("*"))
            {//проверка на ноль или более повторений предшествующего элемента

            }
            else if (p.Contains("."))
            {//проверка на любой одиночный символ

            }
            else
            {//проверка на полное совпадение шаблона и строки

            }
            return isMatch;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009PalindromeNumber
{
    /*
     Учитывая целое число x, верните true, если x является палиндромом, и false в противном случае.

    Пример 1:

    Входные данные: x = 121
    Результат: true
    Объяснение: 121 читается как 121 слева направо и справа налево.

    Пример 2:

    Входные данные: x = -121
    Результат: false
    Объяснение: Слева направо читается -121. Справа налево становится 121-. Поэтому это не палиндром.

    Пример 3:

    Входные данные: x = 10
    Результат: false
    Объяснение: Читается как 01 справа налево. Поэтому это не палиндром.
     */

    internal class Program
    {
        static void Main(string[] args)
        {
            new Solution();
        }
    }
}

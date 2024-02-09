using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestSubstringWithoutRepeatingCharacters
{
    /*
     * Учитывая строку s, найдите длину самой длинной подстроки без повторяющихся символов.

Пример 1:
Ввод: s = "abcabcbb"
Вывод: 3
Объяснение: Ответ - "abc", длиной 3.

Пример 2:
Ввод: s = "bbbbb"
Вывод: 1
Объяснение: Ответ - "b", длиной 1.

Пример 3:
Ввод: s = "pwwkew"
Вывод: 3
Объяснение: Ответ - "wke", длиной 3.

Обратите внимание, что ответ должен быть подстрокой, "pwke" - это подпоследовательность, а не подстрока."
     */


    internal class Program
    {
        static void Main(string[] args)
        {
            new Solution();
        }
    }
}

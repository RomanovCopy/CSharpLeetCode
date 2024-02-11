using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedianOfTwoSortedArrays
{
    /*Учитывая два отсортированных массива nums1 и nums2 размером m и n соответственно, верните медиану двух отсортированных массивов.

   Общая сложность времени выполнения должна быть O(log (m+n)).

   Пример 1:

   Ввод: nums1 = [1,3], nums2 = [2]
   Вывод: 2.00000
   Пояснение: объединенный массив = [1,2,3] и медиана равна 2.
   Пример 2:

   Ввод: nums1 = [1,2], nums2 = [3,4]
   Вывод: 2.50000
   Пояснение: объединенный массив = [1,2,3,4] и медиана равна (2 + 3) / 2 = 2.5.*/

    internal class Program
    {
        static void Main(string[] args)
        {
            new Solution();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_TwoSum
{
    internal class Solution
    {

        internal Solution()
        {
            int[] nums = GenerateArray(10, 0, 20);
            int target = 25;
            Display(nums, TwoSum(nums, target), target);
            Console.ReadKey();
        }

        public int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[2];
            for(int next = 0; next < nums.Length; next++)
            {
                for(int next1 = next; next1 < nums.Length; next1++)
                {
                    if (next1 != next && nums[next1] + nums[next] == target)
                    {
                        result[0] = next;
                        result[1] = next1;
                        return result;
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// генерация нового массива 
        /// </summary>
        /// <param name="size">размер массива</param>
        /// <param name="min">минимальное значение добавляемых чисел</param>
        /// <param name="max">максимальное значение добавляемых чисел</param>
        /// <returns>массив с заданными параметрами</returns>
        private int[] GenerateArray(int size, int min, int max)
        {
            int[] array = new int[size];
            Random random = new Random();
            for (int count = 0; count < size; count++)
            {
                array[count] = random.Next(min, max);
            }
            return array;
        }
        /// <summary>
        /// Вывод результатов
        /// </summary>
        /// <param name="nums">начальный массив</param>
        /// <param name="result">результирующий массив</param>
        /// <param name="target">цель вычислений</param>
        private void Display(int[] nums, int[] result, int target)
        {
            Console.WriteLine("Target = " + target);
            Console.WriteLine("nums");
            DisplayArray(nums,5);
            Console.WriteLine("Rasultat");
            DisplayArray(result,5);
        }
        /// <summary>
        /// вывод отдельного массива в консоль
        /// </summary>
        /// <param name="array">массив для вывода в консоль</param>
        /// <param name="size">колличество элементов в строке до перехода на новую строку</param>>
        private void DisplayArray(int[] array, int size)
        {
            int length = 0;
            foreach (int num in array)
            {
                Console.Write(num+"\t");
                length++;
                if (length > size)
                {
                    Console.WriteLine();
                    length = 0;
                }
            }
        }

    }
}

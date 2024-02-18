﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011ContainerWithMostWater
{
    /*
     * Дан массив целых чисел height длиной n. 
     * Имеются n вертикальных линий, нарисованных так, что две конечные точки i-ой линии находятся в (i, 0) и (i, height[i]).
        Найдите две линии, которые вместе с осью x образуют контейнер, в котором содержится наибольшее количество воды.
        Верните максимальное количество воды, которое может вместить контейнер.Обратите внимание, что нельзя наклонять контейнер.

    Ввод: height = [1,8,6,2,5,4,8,3,7]
    Вывод: 49
    Объяснение: Вышеуказанные вертикальные линии представлены массивом [1,8,6,2,5,4,8,3,7]. 
    В этом случае максимальная площадь воды (синий участок), которую контейнер может вместить, равна 49.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            new Solution();
        }
    }
}

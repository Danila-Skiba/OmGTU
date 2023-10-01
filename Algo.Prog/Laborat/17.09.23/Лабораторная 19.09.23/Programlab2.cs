
/*Дана последовательность из n элементов:
•  Определить кол-во элементов, значения которых больше предшествующего соседа
•  Определить кол-во элементов, значения которых меньше всех вводимых до него
•  Определить кол-во элементов, значения которых больше левого и правого соседа
•  Определить наибольшую длину возрастающей подпоследовательности
*/
using System;

namespace Laborator_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов последовательности");
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            int count_2 = 0;
            int count_3 = 0;
            int len = 1;
            int count_4 = 1;
            int min;
            Console.WriteLine("Введите последовательность из " + n + " элементов");
            int l = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            min = l;
            if (k > l)
            {
                count++;
                len++;
            }
            if (k < l)
            {
                count_2++;
                min = k;
            }
            if (len > count_4)
                count_4 = l;
            for (int i = 2; i < n; i++)
            {
                int f = int.Parse(Console.ReadLine());
                if (f > k)
                {
                    count++;
                    len++;
                }
                else
                    len = 1;
                if (f < min)
                {
                    count_2++;
                    min = f;
                }
                if (k > l && k > f)
                {
                    count_3++;
                }
                if (len > count_4)
                    count_4 = len;
                l = k;
                k = f;
            }
            Console.WriteLine("1) Количество элементов, значения которых больше предшествующего соседа: " + count);
            Console.WriteLine("2) Количество элементов, значения которых меньше всех вводимых до него:  " + count_2);
            Console.WriteLine("3) Количество элементов, значения которых больше левого и правого соседа: " + count_3);
            Console.WriteLine("4) Наибольшая длина возрастающей последовательности: " + count_4);
        }
    }
}

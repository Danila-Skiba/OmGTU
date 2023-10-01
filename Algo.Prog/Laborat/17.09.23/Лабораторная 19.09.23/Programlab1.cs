
/*Дана последовательность элемент в количестве 10 и для этой последовательности найти:
•  Максимальный элемент
•  Количество отрицательных
•  Сумму положительных кратных 3
•  Минимальный среди положительных
*/
using System;

namespace Laborator_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите последовательность из 10 чисел");
            int sum = 0;
            int min_p = -1;
            int count = 0;
            int max = int.Parse(Console.ReadLine());
            if (max > 0)
                min_p = max;
            if (max < 0)
                count++;
            if (max > 0 && max % 3 == 0)
                sum++;
            for (int i = 1; i < 10; i++)
            {
                int f = int.Parse(Console.ReadLine());
                if (f > max)
                    max = f;
                if (f >= 0 && min_p <=0)
                    min_p = f;
                if (f <= min_p && f >= 0)
                    min_p = f;
                if ((f % 3) == 0 && f > 0)
                    sum += f;
                if (f < 0)
                    count++;
            }
            Console.WriteLine("1) Максимальное число: " + max);
            Console.WriteLine("2) Количество отрицательных: " + count);
            Console.WriteLine("3) Сумма положительных чисел, кратных 3: " + sum);
            if (min_p <=0 )
                Console.WriteLine("4) Минимальное положительное число не найдено");
            else
                Console.WriteLine("4) Минимальное положительное число: " + min_p);
        }
    }
}





/*Дана последовательность из n элементов необходимо определить
1) количество элементов, запись которых троичной пятиричной и семиричной системы исчесления оканчивается на одну и ту же цифру  
2) Определить количество элементов, которые содержат в своей записи хотя бы одну семёрку.
3) Определить у всех ли элементов сумма цифр кратна 7.*/
using System;

namespace Laborator_03_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов последовательности: ");
            int n = int.Parse(Console.ReadLine());
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            int sum = 0;
            int a, three, five, seven;
            Console.WriteLine("Введите последовательность из " + n + " элементов");
            for (int i = 0; i < n; i++)
            {
                a = int.Parse(Console.ReadLine());
                three = a % 3;
                five = a % 5;
                seven = a % 7;
                if (three == five && five == seven)
                {
                    count1++;
                }
                while (a > 0)
                {

                    if (a % 10 == 7)
                    {
                        count2++;
                        break;
                    }
                    sum += a % 10;
                    if (sum % 7 == 0)
                    {
                        count3++;
                    }
                    a /= 10;

                }
            }
            if (count1 == 0)
                Console.WriteLine("Нет таких элементов, у которых последние цифры в трёх.пяти.семи- ричных системах одинаковы");
            else
                Console.WriteLine("Количество элементов, у которых последние цифры в трёх.пяти.семи - ричных системах одинаковы: " + count1);
            if (count2 == 0)
                Console.WriteLine("Нет элементов, которые содержат в своей записи хотя бы 1  семёрку");
            else
                Console.WriteLine("Элементы, которые содержат в своей записи хотя бы 1  семёрку: " + count2);
            Console.WriteLine("У всех элементов сумма цифр кратна 7?");
            if (count3 == n)
                Console.WriteLine("Да");
            else
                Console.WriteLine("Нет");
        }
    }
}

//3) определить максимальную длину подпоследовательности состоящей из различных элементов
using System;

namespace Laborator_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            int l = 10000;
            int count_max = 1;
            for (int i = 1; i <= n; i++)
            {

                int k = int.Parse(Console.ReadLine());

                if (l != k)
                {
                    count++;
                }
                else
                {
                    if (count > count_max)
                    { count_max = count; }
                    count = 1;
                }
                l = k;
            }
            if (count > count_max)
                count_max = count;
            Console.WriteLine("Максимальная длина подпоследовательности, состоящей из разных элементов: " + count_max);
        }
    }
}
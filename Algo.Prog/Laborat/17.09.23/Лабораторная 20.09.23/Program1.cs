//1) определить наим длину подпоследовательности, состоящей из одинаковых элементов

using System;

namespace Laborator_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int l = 10000;
            int count = 1;
            int min_count = 10000;
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                a = int.Parse(Console.ReadLine());

                if (a == l)
                {
                    count++;
                }
                else
                {
                    if (count < min_count & count != 1)
                    {
                        min_count = count;
                    }
                    count = 1;
                }
                l = a;

            }
            if (count < min_count & count != 1)
            {
                min_count = count;
            }
            if (min_count == 10000)
            {
                min_count = 0;
            }
            Console.WriteLine("Наименьшая длина подпоследовательности из одинаковых элементов: " + min_count);
        }
    }
}

        
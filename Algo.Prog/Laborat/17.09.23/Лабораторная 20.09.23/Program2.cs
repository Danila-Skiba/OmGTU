//2) определить все ли элементы последовательности кратны номеру под которым они считываются
//(номер первый кратен 1 номер 2 кратен двойке и тд) 
using System;

namespace Laborator_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            int count_2 = 0;
            for (int i = 1; i <= n; i++)
            {
                int k = int.Parse(Console.ReadLine());
                //if (k%i==0)
                if (k % i != 0)
                { count++; }
                if (k % i == 0)
                {
                    count_2++;
                }
            }
            Console.WriteLine("Количество элементов,кратных своему номеру: " + count_2);
            Console.WriteLine("Все элементы последовательности кратны своему номеру - " + (count == 0));
        }
    }
}
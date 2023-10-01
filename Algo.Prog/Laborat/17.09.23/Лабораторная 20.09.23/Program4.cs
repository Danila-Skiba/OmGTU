//4) Определить образует ли заданная последовательность равномерно убывающую последовательность элементов
using System;

namespace Laborator_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
           
            int pred = int.Parse(Console.ReadLine()); 
           
            bool flag4 = true;
            int step = 0;
            
            for (int i = 1; i < num; i++)
            {
                int now = int.Parse(Console.ReadLine());
                
                if (i == 1) 
                {
                    step = pred - now;
                }
                if (i != 1)
                {
                    if (pred- now == step)
                    {
                        flag4 = true;
                    }
                    else
                    {
                        flag4 = false;
                    }
                }
                pred = now; 
            }
                if (flag4 == false)
                {
                    Console.WriteLine("не равномерно убыв");
                }
                else
                {
                    Console.WriteLine("равномерно убыв");
                }
            }
        }
    }



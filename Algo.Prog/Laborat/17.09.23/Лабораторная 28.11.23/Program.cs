using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
class Programm
{
    static void Main()
    {
        Console.WriteLine("Введите размерность массива\nколичество строк");
        int m = int.Parse(Console.ReadLine());
        Console.WriteLine("Количество столбцов");
        int n = int.Parse(Console.ReadLine());
        int[,] arr = new int[m, n];
        arr = Zapolnenie(arr, m, n);
        //1)Вывод
        Console.WriteLine("==============\nВведённый массив");
        Print(arr, m, n);
        //2) Максимальный элемент в каждой строке 
        Console.WriteLine("==============");
        int[] arrMAX = new int[m];
        arrMAX = MaxElemStr(arr, m, n);
        for (int i = 0; i < m; i++)
        {
            Console.WriteLine($"Макимальный элемент в {i + 1} строке: {arrMAX[i]}");
        }
        //3)Количество мин элементов в каждом столбце
        Console.WriteLine("===============");
        int[] arrCountMIN = new int[n];
        arrCountMIN = CountMinSt(arr, m, n);
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Количество минимальный элементов в {i + 1} столбце: {arrCountMIN[i]}");
        }
        //4) Замена элементов на 2 в столбцах, где сумма элементов больше произведения
        int[,] arrnew = Zamena(arr, m, n);
            Console.WriteLine("==============\nИзменённый массив");
        Print(arrnew, m, n);
        Console.ReadKey();
    }
    static int[,] Zapolnenie(int[,] array, int m, int n)
    {
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
        }
        return array;
    }
    static int[] MaxElemStr(int[,] array, int m, int n)
    {
        int[] arrmax = new int[m];
        for (int i = 0; i < m; i++)
        {
            int max = array[i, 0];
            for (int j = 0; j < n; j++)
            {
                if (array[i, j] > max)
                    max = array[i, j];  
            }
            arrmax[i] = max;
        }
        return arrmax;
    }
    static int[] CountMinSt(int[,] array, int m, int n)
    {
        int[] arrmin = new int[n];
        int count = 0;
        for (int j = 0; j < n; j++)
        {
            int min = array[0, j];
            for (int i = 0; i < m; i++)
            {
                if (array[i, j] < min)
                    min = array[i, j];
            }
            arrmin[j] = min;
            for (int c = 0; c < m; c++)
            {
                if (array[c, j] == min)
                    count++;
            }
            arrmin[j] = count;
            count = 0;
        }
        return arrmin;
    }
    static int[,] Zamena(int[,] array, int m, int n)
    {
        int sum = 0;
        int pr = 1;
        for (int j = 0; j < n; j++)
        {
            for (int i = 0; i < m; i++)
            {
                sum += array[i, j];
                pr *= array[i, j];
            }
            if (sum > pr)
            {
                for (int k = 0; k < m; k++)
                    array[k, j] = 2;
            }
            sum = 0;
            pr = 1;
        }
        return array;
    }
    static void Print(int[,] arr, int m, int n)
    {
        
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{arr[i, j]}\t");
            }
            Console.WriteLine();
        }
    }
}


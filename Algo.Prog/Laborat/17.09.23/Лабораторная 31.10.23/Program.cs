using System.Net.Security;
using System.Runtime.InteropServices;
class Programm
{
    static void Main()
    {   // Шаг 1 - Ввод и вывод всех множеств
        Console.WriteLine("Введите кол-во массивов");
        int n = int.Parse(Console.ReadLine());
        int[][] arr = new int[n][];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Введите кол-во элементов в массиве {i + 1}");
            int n1 = int.Parse(Console.ReadLine());
            arr[i] = new int[n1];
            for (int h = 0; h < n1; h++)
            {
                Console.WriteLine($"Введите элемент массива {i + 1} под индексом {h + 1}");
                int n2 = int.Parse(Console.ReadLine());
                arr[i][h] = n2;
            }
            Console.WriteLine("===========================");
        }
        Console.WriteLine("Введённый ступенчатый массив: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write($" Множетсво {i + 1}|\t ");
            for (int j = 0; j < arr[i].Length; j++)
            {
                Console.Write($" {arr[i][j]}, ");
            }
            Console.WriteLine();
        }
        //пересечение множеств
        int[] itog_peresech = arr[0];
        for (int i = 1; i < n; i++)
        {
            itog_peresech = Peresech(itog_peresech, arr[i]);
        }
        Console.WriteLine("Пересечение множеств: " + string.Join(", ", itog_peresech));
        // объединение
        int[] universal = arr[0];
        for (int i = 0; i < n; i++)
        {
            universal = Universal(universal, arr[i]); // объединение первого массива с последующими 
        }
        Console.WriteLine("Объединение множеств: " + string.Join(", ", universal));
        //дополнение к каждому множеству относительно объединения 
        for (int i = 0; i<n; i++)
        {
            int [] dop = Dopolnenie(arr[i], universal);
            Console.WriteLine($"Дополнение к множеству {i+1} относительно объединения: "+ string.Join(", ",dop));
        }
    }
    //2) Шаг 2 - пропишем нужные методы
    static int[] Peresech(int[] array1, int[] array2) // Метод, находящий общие элементы двух входящих массивов(пересечение наших множеств) 
    {
        int i = 0;
        int[] peresech = new int[Math.Min(array1.Length, array2.Length)];// устанавливает наименьшую длину общего массива 
        foreach (int num in array1) // перебор массива, где num - элемент массива 
        {
            if (Obchie_Chislo(array2, num)) // обращение к методу, чтобы найти совпадение элементов массива array2 с числом num 
            {
                peresech[i++] = num;
            }
        }
        Array.Resize(ref peresech, i);
        return peresech;
    }
    static bool Obchie_Chislo(int[] array, int num) //метод, который ищет совпадение элементов массива с заданным числом 
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == num)
                return true;
        }
        return false;
    }
    static int[] Universal(int[] array1, int[] array2)// Метод, который объединяет два массива 
    {
        int index = array1.Length;// отсчёт начинается с числа, равного длине 1 массива
        int[] rezult = new int[array1.Length + array2.Length];
        Array.Copy(array1, rezult, array1.Length); // Используется встроенный метод, который копирует элементы 1 массива в итоговый 
        foreach (int i in array2)
        {
            if (!Obchie_Chislo(array1, i)) //перебор второго массива на поиск несовпадающих элементов с 1 массивом и добавление их в итоговый массив
                rezult[index++] = i;
        }
        Array.Resize(ref rezult, index);
        Array.Sort(rezult);
        return rezult;
    }
    static int[] Dopolnenie(int[] array1, int[] union)//Метод, который исключает общие элементы двух входящих массивов 
    {
        int[] rezult = new int[union.Length];
        int i = 0;
        foreach (int j in union)
        {
            if (!Obchie_Chislo(array1, j))
            {
                rezult[i++] = j;
            }
        }
        Array.Resize(ref rezult, i);
        Array.Sort(rezult);
        return rezult;
    }
}
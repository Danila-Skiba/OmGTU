Console.Write("Кол-во участков трассы: ");
int N = int.Parse(Console.ReadLine());
Console.Write("Время прохождения каждого из переездов: ");
int t = int.Parse(Console.ReadLine());
Console.WriteLine("Время прохождений участков на a и b (через пробел) ");
int[] arr_a = new int[N];
int[] arr_b = new int[N];
int len = 0; int len2 = 0;
for(int i =0; i<N; i++)
{
    string[] S = Console.ReadLine().Split(" ");
    int a = int.Parse(S[0]);
    int b = int.Parse(S[1]);
    arr_a[i] = a + len;
    arr_b[i] = b + len2;
    len = arr_a[i];
    len2 = arr_b[i];
}
int lenght = t + arr_b[arr_b.Length-1];
for (int i=0; i<arr_b.Length; i++)
{
    if (arr_a[i] + t + (arr_b[N-1] - arr_b[i])<lenght)
    {
        lenght = arr_a[i] + t + (arr_b[N-1] - arr_b[i]);
    }
}
Console.Write($"Наименьшее потраченное время: {lenght}");

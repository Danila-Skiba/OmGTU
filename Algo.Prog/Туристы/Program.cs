Console.Write("Введите длину пути: ");
double s = double.Parse(Console.ReadLine());//длина пути

Console.Write("Введите скорость туристов в км/ч: ");
double v = double.Parse(Console.ReadLine());//скорость
v /= 60; //скорость в км/м

Console.Write("Введите время восхода солнца через пробел: ");
string[] time_v = Console.ReadLine().Split(" ");
double t_v = double.Parse(time_v[0])*60 + double.Parse(time_v[1]) ;//время восхода солнца в минутах

Console.Write("Введите время захода солнца через пробел: ");
string[] time_z = Console.ReadLine().Split(" ");
double t_z = double.Parse(time_z[0]) * 60 + double.Parse(time_z[1]); //время захода

Console.Write("Введите количество временных пунктов: ");
int n = int.Parse(Console.ReadLine());//кол-во временных пунктов 
double[] a = new double[n+2];
int[] num_p = new int[n+2];
a[0] = 0;
double len = 0;
Console.WriteLine("Введите расстояния от начала пути до каждого пункта");
double len3 = 0;
double[] a_2 = new double[n+2];
for (int i =1; i<n+1; i++)
{
    a[i] = double.Parse(Console.ReadLine());
    a_2[i] = a[i] - len3;
    len3 = a[i];
}
a_2[n + 1] = s - a[n];
double time = t_z - t_v;
len = 0;
for(int i=1; i<n+2; i++)
{
    if (len + a_2[i]/v<=time)
        len += a_2[i]/v;
    else if (len + a_2[i]/v > time)
       {
        num_p[i] = i-1;
        len = a_2[i]/v;
       }
}
Console.Write("Номера пунктов: ");
for(int j=0; j<a.Length; j++)
{
    if (num_p[j]!=0)
        Console.Write(num_p[j]+ " ");
}
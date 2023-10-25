int N = int.Parse(Console.ReadLine()); 
int L = 1;
int M = 0;
for (int i = 1; i <= N; i++)
{

    for (int j = 1; j <= i; j++)
    {
        L *= j;
    }
    M += L;
    L = 1;
}
Console.WriteLine(M);

double a = double.Parse(Console.ReadLine());
double b = double.Parse(Console.ReadLine());
double h = double.Parse(Console.ReadLine());
double S;
if (h == 0)
    S = a * b;
else if (a == b)
    S = a * b;
else
    S = ((a + b) / 2) * h;
Console.WriteLine(S);

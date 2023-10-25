float n = 20;
float a = -1;
float b = 3;
float c = n / (b - a);
float d = 1 / c;
for (float x = -1; x <= 3; x += 0.2f)
{
    float F1 = (float)(Math.Pow(2, (-x)) / 100);
    Console.WriteLine(F1);

}
for (float x = a; x <= b; x += d)
{
    float F2 = (float)(20 / (1 + Math.Pow(x, 2)));
    Console.WriteLine(F2);
}

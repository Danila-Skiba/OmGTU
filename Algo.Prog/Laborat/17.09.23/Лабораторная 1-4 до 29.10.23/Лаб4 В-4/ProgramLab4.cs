float b = 3.5f;
float x = 1;
float t = 0;
while (x <= 2 && t <= 1)
{
    float Z = (float)(b * x * (Math.Sqrt(t + b)) * (t * x + 2.1));
    Console.WriteLine(Z);
    x += 0.2f;
    t += 0.2f;
}

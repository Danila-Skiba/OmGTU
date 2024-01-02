
Console.Write("Количество мышек:  "); 
int n = int.Parse(Console.ReadLine());
Console.Write("Шаг поедания мышек: "); 
int k = int.Parse(Console.ReadLine());
Console.Write("Положение белой мышки: "); 
int white_mouse = int.Parse(Console.ReadLine());
bool[] mouses = new bool[n];
for (int i = 0; i < n; i++) 
{
    mouses[i] = true; 
}
int k0 = 0; int last_position = 0; int count = 0;
while (true)
{
    for (int i = 0; i < n; i++)
    {
        if (mouses[i] == true && k0 == k) 
        { 
            mouses[i] = false; 
            k0 = 1; 
            last_position = i; 
        }
        else if (mouses[i] == true && k0 != k) 
        { 
            k0++; 
        }
    }

    count = 0;
    foreach (bool j in mouses) 
    { if (j == false)
        {
            count++; 
        } 
    }
    if (count == n) 
    { 
        break;
    }

}
Console.Write("Позиция, с которой нужно поедать мышек для сохранения белой: ");
if (last_position != white_mouse) { Console.WriteLine(Math.Abs(n - last_position + white_mouse) % n); }
else { Console.WriteLine("Такой позиции нет"); }
//Console.WriteLine(last_position); 

﻿double x1 = -1;
double x2 = 1;
double a = 2;
double pi = Math.PI;
double b = pi / 6;
double c = 0.5;
double y1 = ((a * Math.Cos(x1 - b) / (c + Math.Pow(Math.Sin(x1), 2)))) + Math.Pow(2, x1);
double y2 = ((a * Math.Cos(x2 - b) / (c + Math.Pow(Math.Sin(x2), 2)))) + Math.Pow(2, x2);
Console.WriteLine(y1);
Console.WriteLine(y2);
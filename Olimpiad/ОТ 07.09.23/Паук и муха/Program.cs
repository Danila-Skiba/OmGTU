using System;
using System.IO;

    class Program
    {
        static void Main(string[] args)
        {

            int[] x = new int[3];
            int[] y = new int[3];
            int[] z = new int[3];
            for (int i = 0; i < 3; i++)
            {
                string cords = Console.ReadLine();
                string[] cor = cords.Split(" ");
                x[i] = int.Parse(cor[0]);
                y[i] = int.Parse(cor[1]);
                z[i] = int.Parse(cor[2]);
            }
            double ans = 0;
            if (x[1] == 0 || x[1] == x[0])
                ans = func(y, x, z);

            else if (y[1] == 0 || y[1] == y[0])
                ans = func(x, y, z);

            else if (z[1] == 0 || z[1] == z[0])
                ans = func(y, z, x);
            ans = Math.Round(ans, 3);
            Console.WriteLine(ans);
        }

        static double F_1(int[] a, int[] b, int[] c)
        {
            return Math.Sqrt(Math.Pow(a[1] - a[2], 2) + Math.Pow(Math.Abs(b[1] - b[2]) + Math.Abs(c[1] - c[2]), 2));
        }

        static double F_2(int[] a, int[] b, int[] c)
        {
            return Math.Sqrt(Math.Pow(a[1] - a[2], 2) + Math.Pow((b[0] - b[1]) + (b[0] - b[2]) + (c[0] - c[1]) + (c[0] - c[2]), 2));
        }

        static double F_3(int[] a, int[] b, int[] c)
        {
            return Math.Sqrt(Math.Pow(a[1] - a[2], 2) + Math.Pow((b[1] + b[2]) + (c[1] + c[2]), 2));
        }

        static double func(int[] a, int[] b, int[] c)
        {
            if (b[2] == b[1] || a[2] == 0 || a[2] == a[0])
                return F_1(c, a, b);

            else if (c[2] == 0 || c[2] == c[0])
                return F_1(a, b, c);

            else
            {
                if (a[1] + a[2] > a[0] || b[1] + b[2] > b[0])
                    return F_2(c, b, a);
                else
                    return F_3(c, b, a);
            }
        }
    }

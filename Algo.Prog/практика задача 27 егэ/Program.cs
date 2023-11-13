class Programm
{
    static void Main()
    {
        int sum = 0, sum0 = 0, sum1 = 0, sum2 = 0, sum01 = 0, sum02 = 0, sum03 = 0, sum11 = 0, sum12 = 0, sum13 = 0, sum21 = 0, sum22 = 0, sum23 = 0;
        int s0 = 0, s1 = 0, s2 = 0;
        int n = int.Parse(Console.ReadLine());
        int a, b;
        for (int i = 1; i < n; i++)
        {
            Console.WriteLine($"Введите {i} пару");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            if ((sum0 + a) % 3 == 0)
                if ((sum0 + b) % 3 == 0)
                    sum01 = Math.Max(sum0 + a, sum0 + b);
                else
                    sum01 = sum0 + a;
            else
                if ((sum0 + b) % 3 == 0)
                sum01 = sum0 + b;

            if (((sum1 + a) % 3 == 0) && (sum1 + a > sum0))
                if (((sum1 + b) % 3 == 0) && (sum1 + b > sum0))
                    sum02 = Math.Max(sum1 + a, sum1 + b);
                else
                    sum02 = sum1 + a;
            else
                if ((sum1 + b) % 3 == 0 && (sum1 + b > sum0))
                sum02 = sum1 + b;

            if (((sum2 + a) % 3 == 0) && (sum2 + a > sum0))
                if (((sum2 + b) % 3 == 0) && (sum2 + b > sum0))
                    sum03 = Math.Max(sum2 + a, sum2 + b);
                else
                    sum03 = sum2 + a;
            else
                if ((sum2 + b) % 3 == 0 && (sum2 + b > sum0))
                sum03 = sum2 + b;
            //////////////////////////////////////
            if ((sum0 + a) % 3 == 1)
                if ((sum0 + b) % 3 == 1)
                    sum11 = Math.Max(sum0 + a, sum0 + b);
                else
                    sum11 = sum0 + a;
            else
                if ((sum1 + b) % 3 == 1)
                sum11 = sum0 + b;

            if ((sum1 + a) % 3 == 1 && (sum1 + a > sum0))
                if ((sum1 + b) % 3 == 1 && (sum1 + b > sum0))
                    sum12 = Math.Max(sum1 + a, sum1 + b);
                else
                    sum12 = sum1 + a;
            else
                if ((sum1 + b) % 3 == 1 && (sum1 + b > sum0))
                sum12 = sum1 + b;

            if ((sum2 + a) % 3 == 1 && (sum2 + a > sum0))
                if ((sum2 + b) % 3 == 1 && (sum2 + b > sum0))
                    sum13 = Math.Max(sum2 + a, sum2 + b);
                else
                    sum13 = sum2 + a;
            else
                if ((sum2 + b) % 3 == 1 && (sum2 + b > sum0))
                sum13 = sum2 + b;
            ////////////////////////////////////////////
            if ((sum0 + a) % 3 == 2)
                if ((sum0 + b) % 3 == 2)
                    sum21 = Math.Max(sum0 + a, sum0 + b);
                else
                    sum21 = sum1 + a;
            else
                if ((sum1 + b) % 3 == 2)
                sum21 = sum1 + b;

            if ((sum1 + a) % 3 == 2 && (sum1 + a > sum0))
                if ((sum1 + b) % 3 == 2 && (sum1 + b > sum0))
                    sum22 = Math.Max(sum1 + a, sum1 + b);
                else
                    sum22 = sum1 + a;
            else
                if ((sum1 + b) % 3 == 2 && (sum1 + b > sum0))
                sum22 = sum1 + b;

            if ((sum2 + a) % 3 == 2 && (sum2 + a > sum0))
                if ((sum2 + b) % 3 == 2 && (sum2 + b > sum0))
                    sum23 = Math.Max(sum2 + a, sum2 + b);
                else
                    sum23 = sum2 + a;
            else
                if ((sum2 + b) % 3 == 2 && (sum2 + b > sum0))
                sum23 = sum2 + b;
            //////////////////////////////////////////////
            if ((sum0 == Math.Max(sum01, Math.Max(sum03, sum02))) && (a != 0) && (b != 0))
                s0 = 0;
            else s0 = 1;
            if ((sum1 == Math.Max(sum11, Math.Max(sum13, sum12))) && (a != 0) && (b != 0))
                s1 = 0;
            else s1 = 1;
            if ((sum2 == Math.Max(sum21, Math.Max(sum23, sum22))) && (a != 0) && (b != 0))
                s2 = 0;
            else s2 = 1;
            sum0 = Math.Max(sum01, Math.Max(sum02, sum03));
            sum1 = Math.Max(sum11, Math.Max(sum12, sum13));
            sum2 = Math.Max(sum21, Math.Max(sum22, sum23));
        }
        Console.WriteLine($"Введите {n} пару");
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());

        if (((sum0 + a) % 3 == 0) && (s0 == 1))
            if ((sum0 + b) % 3 == 0)
                sum01 = Math.Max(sum0 + b, sum0 + a);
            else sum01 = sum0 + a;
        else
            if (((sum0 + b) % 3 == 0) && (s0 == 1))
            sum01 = sum0 + b;
        else sum01 = 0;



        if (((sum1 + a) % 3 == 0) && (s1 == 1))
            if ((sum1 + b) % 3 == 0)
                sum02 = Math.Max(sum1 + b, sum1 + a);
            else sum02 = sum1 + a;
        else
            if (((sum1 + b) % 3 == 0) && (s1 == 1))
            sum02 = sum1 + b;
        else sum02 = 0;



        if (((sum2 + a) % 3 == 0) && (s2 == 1))
            if ((sum2 + b) % 3 == 0)
                sum03 = Math.Max(sum2 + b, sum2 + a);
            else sum03 = sum2 + a;
        else
            if (((sum2 + b) % 3 == 0) && (s2 == 1))
            sum03 = sum2 + b;
        else sum03 = 0;
        sum0 = Math.Max(sum01, Math.Max(sum02, sum03));
        Console.WriteLine();
        Console.WriteLine("Наибольшая сумма, кратная 3: " + sum0);
    }
}

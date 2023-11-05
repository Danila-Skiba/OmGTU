namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
            string data1 = Console.ReadLine();
            string[] d1 = data1.Split('.');
            int day1 = int.Parse(d1[0]);
            int mounth1 = int.Parse(d1[1]);
            int year1 = int.Parse(d1[2]);
            string data2 = Console.ReadLine();
            string[] d2 = data2.Split('.');
            int day2 = int.Parse(d2[0]);
            int mounth2 = int.Parse(d2[1]);
            int year2 = int.Parse(d2[2]);
            int n = int.Parse(Console.ReadLine());
            int  sum_years = 0, sum_mounth = 0, sum_days =0, otv = 0;
           for (int i = year1+1; i<=year2; i++)
           {
                if (i % 4 == 0)
                    sum_years += 366;
                else
                    sum_years += 365;
           }
            if (mounth1 <= mounth2)
            {
                for (int i = mounth1; i < mounth2; i++)
                {
                    if (i % 2 != 0 && i <= 7)
                        sum_mounth += 31;
                    else if (i % 2 == 0 && i >= 8)
                        sum_mounth += 31;
                    if (i % 2 == 0 && i <= 6 && i != 2)
                        sum_mounth += 30;
                    else if (i % 2 != 0 && i > 8)
                        sum_mounth += 30;
                    if (i == 2)
                        sum_mounth += 28;
                }
            }
            else if (mounth1 > mounth2)
            {
                for (int i = mounth2; i < mounth1; i++)
                {
                    if (i % 2 != 0 && i <= 7)
                        sum_mounth -= 31;
                    else if (i % 2 == 0 && i >= 8)
                        sum_mounth -= 31;
                    if (i % 2 == 0 && i <= 6 && i != 2)
                        sum_mounth -= 30;
                    else if (i % 2 != 0 && i > 8)
                        sum_mounth -= 30;
                    if (i == 2)
                        sum_mounth -= 28;
                }
            }
            sum_days = day2-day1+1;
            int sum = sum_days + sum_mounth + sum_years;
            Console.WriteLine(sum);
            /*for (int i =1; i<=sum; i++)
            {
                otv += n;
                n += 1;
            }
            Console.WriteLine("Результат: "+otv);*/
            Console.ReadKey();
            
        }
    }
}
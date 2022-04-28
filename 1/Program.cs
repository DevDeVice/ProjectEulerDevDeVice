using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] TabSum = new int[1000];
            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    Console.WriteLine(sum);
                    TabSum[sum] = i;
                    sum++;
                }
            }

            int all = 0;
            foreach (int number in TabSum)
            {
                all += number;
            }
            Console.WriteLine(all);
        }
    }
}



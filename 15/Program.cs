using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            long sum;
            long[,] grid = new long[20, 20];
            for (int i = 0; i < 20; i++)
            {
                grid[0, i] = 1;
                grid[i, 0] = 1;
                grid[1, i] = i + 1;
                grid[i, 1] = i + 1;
                for (int j = 2; j <= i; j++)
                {
                    sum = 0;
                    for (int k = j; k >= 0; k--)
                    {
                        sum += grid[i - 1, k];
                    }
                    grid[j, i] = sum;
                    grid[i, j] = sum;
                }
            }
            long suma = 0;
            for (int i = 0; i < 20; i++) suma += grid[19, i];
            Console.WriteLine(suma * 2);
        }
    }
}

using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            long n;
            int count, id = 0, max = 0;
            for (int i = 1; i < 1000000; i++)
            {
                n = i;
                count = 0;
                while (n != 1)
                {
                    if (n % 2 == 0) n /= 2;
                    else n = n * 3 + 1;
                    count++;
                }
                if (max < count)
                {
                    max = count;
                    id = i;
                }
            }
            Console.WriteLine($"Liczba {id} ma {max} dzielnikow");
        }
    }
}

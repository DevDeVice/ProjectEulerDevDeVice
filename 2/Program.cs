using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 2;
            int j = 2;
            int k = 3;
            for (int i = 1; i + j < 4000000; k = i + j)
            {
                if (k % 2 == 0) sum += k;
                i = j;
                j = k;
            }
            Console.WriteLine(sum);
        }
    }
}

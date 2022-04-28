using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            for (int i = 100000000; i < 1000000000; i++)
            {
                for (int j = 1; j < 20; j++)
                {
                    if (i % j != 0) break;
                    if (j % 19 == 0) result = i;
                }
                if (result > 0) break;
            }
            Console.WriteLine(result);
        }
    }
}

using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            bool t;
            int primeNum = 4;
            for (int i = 10; i < 100000000; i++)
            {
                t = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        t = false;
                        break;
                    }
                }
                if (t) primeNum++;
                if (primeNum == 10001)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}

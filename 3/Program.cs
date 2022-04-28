using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int largest = 1;
            long primeFactor = 600851475143;

            for (int i = 1; i < 100000; i++)
            {
                if (primeFactor % i == 0)
                {
                    primeFactor /= i;
                    if (i > largest) largest = i;
                    i = 1;
                }
                if (primeFactor == 0) break;
            }
            Console.WriteLine(largest);
        }
    }
}

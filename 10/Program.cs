using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 2000000;
            long sum = 0;
            bool[] prime = new bool[max];
            for (int i = 2; i < max; i++) prime[i] = true;

            for (int i = 2; i < max; i++)
            {
                if (prime[i])
                {
                    sum += i;
                    Console.WriteLine($"Prime: {i} Suma: {sum}");
                    for (int j = i * 2; j < max; j += i)
                    {
                        prime[j] = false;
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}

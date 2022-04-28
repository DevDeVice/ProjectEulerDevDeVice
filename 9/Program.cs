using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            for (int i = 1; i < 1000; i++)
            {
                for (int j = i + 1; j < 1000; j++)
                {
                    float k = (float)Math.Sqrt(i * i + j * j);

                    if (k % 1 != 0) continue;

                    if (i + j + k > 980 && i + j + k < 1020)
                    {
                        Console.WriteLine("I: " + i);
                        Console.WriteLine("J: " + j);
                        Console.WriteLine("K: " + k);
                        Console.WriteLine("ALL: " + i + j + k);
                        Console.WriteLine();
                    }
                    if (i + j + k == 1000)
                    {
                        result = i * j * (int)k;
                        break;
                    }
                }
                if (result != 0) break;
            }
            Console.WriteLine(result);
        }
    }
}

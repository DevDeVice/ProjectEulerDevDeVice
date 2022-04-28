using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumSquares = 0;
            int squaresSum = 0;
            for (int i = 1; i <= 100; i++)
            {
                sumSquares += i * i;
                squaresSum += i;
            }
            Console.WriteLine(squaresSum * squaresSum - sumSquares);
        }
    }
}

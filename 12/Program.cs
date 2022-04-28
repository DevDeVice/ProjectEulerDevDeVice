using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 10000;
            int[] arrayPrime = new int[2000];
            bool[] prime = new bool[max];
            int counter = 0;
            for (int i = 2; i < max; i++) prime[i] = true;
            for (int i = 2; i < max; i++)
            {
                if (prime[i])
                {
                    arrayPrime[counter] = i;
                    counter++;
                    for (int j = i * 2; j < max; j += i)
                    {
                        prime[j] = false;
                    }
                }
            }
            Console.WriteLine($"Prime gotowy");



            int number = 0;
            int trueNumber = 0;
            for (int i = 1; i < 100000; i++)
            {
                int result = 1;
                trueNumber += i;
                number += trueNumber;
                Console.WriteLine($"Sprawdzana liczba: {trueNumber}");
                int[] array = new int[100];
                Console.WriteLine();
                for (int j = 0; j < 100; j++)
                {
                    if (number % arrayPrime[j] == 0)
                    {
                        Console.WriteLine($"Number {number} podzielono przez {arrayPrime[j]} zostalo {number / arrayPrime[j]}");
                        array[j]++;
                        number /= arrayPrime[j];
                        j = -1;
                    }
                    else continue;
                }
                for (int j = 0; j < 100; j++)
                {
                    result *= array[j] + 1;
                }
                if (result > 500)
                {
                    Console.WriteLine($"POWYZEJ 500: {result} dla i={i} trueNum={trueNumber}");
                    break;
                }
            }
        }
    }
}

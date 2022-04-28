using System;
using System.Collections.Generic;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            //1-9
            sum += 3 + 3 + 5 + 4 + 4 + 3 + 5 + 5 + 4;
            //10-19
            sum += 3 + 6 + 6 + 8 + 8 + 7 + 7 + 9 + 8 + 8;
            //20-99
            sum += 10 * (6 + 6 + 5 + 5 + 5 + 7 + 6 + 6) + 8 * 36;
            //100-999
            sum += 36 * 100 + 9 * 854 + 7 * 9 + 891 * 10 + 11;
            Console.WriteLine(sum);
        }
    }
}

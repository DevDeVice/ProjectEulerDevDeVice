using System;
using System.Numerics;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = numPower(2, 1000);
            int sum = 0;
            for (int i = 0; i < result.Length; i++) sum += Convert.ToInt32(result[i].ToString());
            Console.WriteLine(sum);
        }
        static string numPower(int n, int p)
        {
            string power = BigInteger.Pow(n, p).ToString();
            return power;
        }
    }
}

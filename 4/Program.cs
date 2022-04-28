using System;
using System.Text;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            for (int i = 999; i > 900; i--)
            {
                for (int j = 999; j > 900; j--)
                {
                    int a = i * j;
                    string b = Convert.ToString(a);
                    if (b[0] == b[5] && b[1] == b[4] && b[2] == b[3])
                    {
                        result = Int32.Parse(b);
                        break;
                    }
                }
                if (result != 0) break;
            }
            Console.WriteLine(result);
        }
    }
}

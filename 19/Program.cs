using System;

namespace ConsoleApp19
{
    class Program
    {
        static int day = 0;
        static int counter = 0;
        static void Main(string[] args)
        {
            //1.01 1900 to poniedzialek
            //28 i 29 co 4 .2  !!!!!bez podzielnych przez 400
            //30dni to: .4 .6 .9 .11
            //31 .1 .3 .5 .7 .8 .10 .12
            //ile niedzieli wypada w pierwszy dzien tygodnia
            for (int i = 1900; i < 2001; i++)
            {
                dayC(31, i);
                if (i % 4 == 0 && (i % 100 != 0 || i % 400 == 0)) dayC(29, i);
                else dayC(28, i);
                dayC(31, i);
                dayC(30, i);
                dayC(31, i);
                dayC(30, i);
                dayC(31, i);
                dayC(31, i);
                dayC(30, i);
                dayC(31, i);
                dayC(30, i);
                dayC(31, i);
            }
            Console.WriteLine(counter);
        }
        static void dayC(int n, int i)
        {
            if (day == 6 && i > 1900) counter++;
            day = ((n + day) % 7);
        }
    }
}

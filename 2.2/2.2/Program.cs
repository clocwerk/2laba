using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace lab2._2
{
    class Program
    {

        static void Main(string[] args)
        {
            const double p = 3.14;
            const double dx = p / 30;
            const double a = -p / 2;
            const double b = p / 2;
            double x = a;
            double y = 0;
            while (true)
            {
                if (x >= a && x <= b + dx)
                {
                    y = Math.Sin(x) / x;
                    Console.WriteLine("      x  |   y=f(x)   ");
                    Console.WriteLine("x = " + x + "|" + "y = " + y);
                    x = x + dx;

                }
            }
        }
    }
}
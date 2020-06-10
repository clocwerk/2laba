using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
namespace laba2._4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Order of the Matrix m: \t");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Enter the Order of the Matrix n: \t");
            int n = int.Parse(Console.ReadLine());
            int i, j, ch;
            Random rand = new Random();
            int[,] mass = new int[m, n];
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    mass[i, j] = rand.Next(-10, 30);
                    Console.Write(mass[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
            Console.Write("Enter The Matrix Elements k: \t");
            int k = int.Parse(Console.ReadLine());
            Console.Write("Enter The Matrix Elements p: \t");
            int p = int.Parse(Console.ReadLine());
            for (i = 0; i < m; i++)
            {
                ch = mass[i, k - 1];
                mass[i, k - 1] = mass[i, p - 1];
                mass[i, p - 1] = ch;

            }
            Console.WriteLine("New massiv:");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(mass[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}
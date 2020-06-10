using System;

namespace _2._1
{
    class Program
    { 
static void Main(string[] args)
    {
        int i = 0;
        int n;
        while (i == 0)
        {
            Console.WriteLine(" Specify an integer n, 1 <= n <= 24, which indicates the number of the month of the year: ");
            n = int.Parse(Console.ReadLine());
            if (1 <= n && n <= 24)
            {
                i++;
                switch (n)
                {
                    case 1: Console.WriteLine(" 1 – «перша година». "); break;
                    case 2: Console.WriteLine(" 2 – «друга година». "); break;
                    case 3: Console.WriteLine(" 3 – «третя година». "); break;
                    case 4: Console.WriteLine(" 4 – «четверта година». "); break;
                    case 5: Console.WriteLine(" 5 – «пята година». "); break;
                    case 6: Console.WriteLine(" 6 – «шоста година». "); break;
                    case 7: Console.WriteLine(" 7 – «сьома година». "); break;
                    case 8: Console.WriteLine(" 8 – «восьма година». "); break;
                    case 9: Console.WriteLine(" 9 – «девята година». "); break;
                    case 10: Console.WriteLine(" 10 – «десята година». "); break;
                    case 11: Console.WriteLine(" 11 – «одинадцята година». "); break;
                    case 12: Console.WriteLine(" 12 – «дванадцята година». "); break;
                    case 13: Console.WriteLine(" 13 – «тринадцята година». "); break;
                    case 14: Console.WriteLine(" 14 – «чотирнадцята година». "); break;
                    case 15: Console.WriteLine(" 15 – «пятнадцята година». "); break;
                    case 16: Console.WriteLine(" 16 – «шістнадцята година». "); break;
                    case 17: Console.WriteLine(" 17 – «сімнадцята година». "); break;
                    case 18: Console.WriteLine(" 18 – «вісімнадцята година». "); break;
                    case 19: Console.WriteLine(" 19 – «девятнадцята година». "); break;
                    case 20: Console.WriteLine(" 20 – «двадцята година». "); break;
                    case 21: Console.WriteLine(" 21 – «двадцять перша година». "); break;
                    case 22: Console.WriteLine(" 22 – «двадцять друга година». "); break;
                    case 23: Console.WriteLine(" 23 – «двадцять третя година». "); break;
                    case 24: Console.WriteLine(" 24 – «двадцять четверта година». "); break;
                    default: Console.WriteLine("Ви ввели неправильне значення n!"); break;
                }
            }
            else
            {
                Console.WriteLine(" Ви ввели неправильне число ");
                i = 0;
            }
        }

    }
}
}
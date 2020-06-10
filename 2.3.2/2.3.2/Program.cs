using System;

namespace _2._3._2
{
    class Program
    {
        static void ValsGenerator(int[] Vals)
        {                         
            Random aRand = new Random();                         
            for (int i = 0; i < Vals.Length; i++)
                Vals[i] = aRand.Next(-10, 10);

        }
        static void Main(string[] args)
        {
            const int N = 10;
            long sum = 0;
            int mul = 1;
            int[] Data = new int[N];
            ValsGenerator(Data);
            for (int i = 0; i < Data.Length; i++)
            {
                Console.WriteLine("Data[" + i + "] = " + Data[i]);
                if (Data[i] < 0)
                {
                    sum += Data[i];
                }
            }

            for (int i = 0; i < Data.Length; ++i)
            {
                if (Data[i] < 0)
                {
                    break;
                }
                mul *= Data[i];
            }
            Console.WriteLine("Sum of negative numbers = " + Math.Abs(sum));
            Console.WriteLine("Multiply the elements of the array to the first negative = " + mul);

        }
    }
}

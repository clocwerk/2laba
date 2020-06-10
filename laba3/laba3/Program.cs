using System;
namespace laba3
{
    public class Program
    {
        static public int Example(int[] a, int n)
        {
            int sum = 0;

            for (int i = 0; i < n; ++i)
                if (a[i] < 0)
                {
                    sum += a[i];
                }
            Console.WriteLine("Negative sum = " + Math.Abs(sum));
            int mul = 1;
            for (int i = 0; i < n; ++i)
            {
                if (a[i] < 0)
                {
                    break;
                }
                mul *= a[i];
            }
            Console.WriteLine("Multiplication of array elements =" + mul);
            int r;

            return r = mul + Math.Abs(sum);
        }
        static void Main(string[] args)
        {
            const int n = 6;
            int[] a = new int[n] { 3, 12, 5, -9, 8, -4 };
            Console.WriteLine(Example(a, n));
        }
    }
}

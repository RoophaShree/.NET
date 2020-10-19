using System;

namespace sin_Value
{
    class Program
    {
        static double CalculateSinX(int deg, int terms)
        {
            double x;
            double result;
            double temp;

            int loop;
            x = Math.PI * deg / 180f;
            result = x;
            temp = x;

            for (loop = 1; loop <= terms; loop++)
            {
                temp = (-temp * x * x) / ((2 * loop) * (2 * loop + 1));
                result = result + temp;
            }

            return result;
        }
        public static void Main()
        {
            int degree = 0;
            int terms = 0;

            double result = 0.0;

            Console.Write("Enter the angle in Degrees:");
            degree = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of terms:");
            terms = int.Parse(Console.ReadLine());

            result = CalculateSinX(degree, terms);
            Console.WriteLine("Sin({0})={1}", degree, result);
        }
    }
}
    



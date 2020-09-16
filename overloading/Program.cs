using System;

namespace overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(addMethod(8, 6));
            Console.WriteLine(addMethod(1, 2));
        }

        static int addMethod(int x,int y)
        {
            int m;
            return m = x + y;
        }
        static double addMethod(double a, double b)
        {
            double n;
            return n = a + b;
        }
    }
}

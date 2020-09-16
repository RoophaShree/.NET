using System;

namespace overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num1;
            double Num2;
            Num1 = addMethodint(8, 6);
            Num2 = addMethoddouble(1.2, 2.4);
            Console.WriteLine("Int: " +Num1);
            Console.WriteLine("double:" +Num2);
        }

        static int addMethodint(int x,int y)
        {
            
            return  x + y;
        }
        static double addMethoddouble(double a, double b)
        {
            
            return  a + b;
        }
    }
}

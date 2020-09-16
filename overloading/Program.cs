using System;

namespace overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num1;
            double Num2;
            Num1 = addMethod(8, 6);
            Num2 = addMethod(1, 2);
            Console.WriteLine("Int: " +Num1);
            Console.WriteLine("double:" +Num2);
        }

        static int addMethod(int x,int y)
        {
            
            return  x + y;
        }
        static double addMethod(double a, double b)
        {
            
            return  a + b;
        }
    }
}

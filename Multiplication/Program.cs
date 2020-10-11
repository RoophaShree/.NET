using System;

namespace Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter 1st num=");
            a = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Enter 2nd num=");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 3rd num=");
            c = int.Parse(Console.ReadLine());

            int result = a * b*c;

            Console.WriteLine("Multiplication output: {0} * {1} * {2} = {3}", a,b,c,result);
            




        }
    }
}

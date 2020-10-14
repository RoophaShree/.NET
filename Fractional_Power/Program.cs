using System;

namespace Fractional_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1 = 0;
            double number2 = 0;
            double number3 = 0;

            number1 = Math.Pow(Math.PI, 3.2);
            number2 = Math.Pow(1.67, 1.8);
            number3 = Math.Pow(Math.E, 1.7);

            Console.WriteLine("Number1 : " + number1);
            Console.WriteLine("Number2 : " + number2);
            Console.WriteLine("Number3 : " + number3);
        }
    }
}

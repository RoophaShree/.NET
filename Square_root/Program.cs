using System;

namespace Square_root
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            double squareRoot = 0;

            Console.Write("Enter the value of number: ");
            number= int.Parse(Console.ReadLine());

            squareRoot = Math.Ceiling(Math.Pow(number, (double)1 / 2));
            Console.WriteLine("Square Root is : " + squareRoot);

           // return 0;
        }
    }
}

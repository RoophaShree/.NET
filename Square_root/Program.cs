﻿using System;

namespace Square_root
{
    class Program
    {
        static int Main(string[] args)
        {
            int number = 0;
            double squareRoot = 0;

            Console.Write("Enter the value of number: ");
            number = Convert.ToInt32(Console.ReadLine());

            squareRoot = Math.Ceiling(Math.Pow(number, (double)1 / 2));
            Console.WriteLine("Square Root is : " + squareRoot);

            return 0;
        }
    }
}

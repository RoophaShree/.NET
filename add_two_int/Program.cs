﻿using System;

namespace add_two_int
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
                int a = 0;
                int b = 0;

                
                Console.Write("Enter first number: ");
                a = int.Parse(Console.ReadLine());
                Console.Write("Enter second number: ");
                b = int.Parse(Console.ReadLine());

                
                int sum = a + b;

                Console.WriteLine("Addition of " + a + " and " + b + " is = " + sum);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.ToString());
            }
        }
    }
}

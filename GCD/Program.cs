﻿using System;

class Program
{
    static void Main(string[] args)
    {
        int num1 = 0;
        int num2 = 0;
        int GCD = 0;

        Program G = new Program(); 

        Console.Write("Enter the 1st Number : ");
        num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the 2nd Number : ");
        num2 = int.Parse(Console.ReadLine());

        GCD = G.GetGcd(num1, num2);

        Console.WriteLine("\n The Greatest Common Divisor is: " + GCD);
    }
    int GetGcd(int number1, int number2)
    {
        int rem = 0;

        while (number2 > 0)
        {
            rem = number1 % number2;
            number1 = number2;
            number2 = rem;
        }
        return number1;
    }
}
﻿using System;

namespace Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter 1st num=");
            a = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Enter 2nd num=");
            b = int.Parse(Console.ReadLine());

            int result = a * b;

            Console.WriteLine("Multiplication output:{0}*{1} = {2}", a,b,result);
            //Console.Readkey();




        }
    }
}

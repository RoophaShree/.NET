﻿using System;

namespace Access_Modifiers
{
    class Car
    {
        private string model = "Ford";
    }
    class Program
    { 
        static void Main(string[] args)
        {
            Car myObj = new Car();
            Console.WriteLine(myObj.model);
        }
    }
}

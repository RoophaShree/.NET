﻿using System;
using System.Collections;



    class Program
    {
        static void Main(string[] args)
        {
            var ppl = Tuple.Create(1, "Roopa", "Jobs");
        Console.WriteLine(ppl.Item1);
        Console.WriteLine(ppl.Item2);
        Console.WriteLine(ppl.Item3);
        Console.WriteLine("\n");

        var numbers = Tuple.Create("One", 2, 3, "Four", 5, "Six", 7, "Eight");
        Console.WriteLine(numbers.Item1);
        Console.WriteLine(numbers.Item2);
        Console.WriteLine(numbers.Item3);
        Console.WriteLine(numbers.Item4);
        Console.WriteLine(numbers.Item5);
        Console.WriteLine(numbers.Item6);
        Console.WriteLine(numbers.Item7);
        Console.WriteLine(numbers.Rest);
        Console.WriteLine(numbers.Rest.Item1);
        }
    }


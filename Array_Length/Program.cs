﻿using System;
class Program
{
    static void Main()
    {

        int[] arrayA = new int[35];
        int lengthA = arrayA.Length;
        Console.WriteLine("Length of ArrayA : {0}", +lengthA);
        long longLength = arrayA.LongLength;
        Console.WriteLine("Length of the LongLength Array  : {0}", longLength);
        int[,] twoD = new int[34, 10];
        Console.WriteLine("The Size of 2D Array is : {0}", twoD.Length);
        Console.ReadLine();
    }
}
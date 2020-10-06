using System;
class Program
{
    static void Main()
    {

        int[] arrayA = new int[35];
        int lengthA = arrayA.Length;
        Console.WriteLine("Length of ArrayA : {0}", +lengthA);
        long longLength = arrayA.LongLength;
        Console.WriteLine("Length of the LongLength Array  : {0}", longLength);
        int[,] len = new int[4, 1];
        Console.WriteLine("The Size of 2D Array is : {0}", len.Length);
        Console.ReadLine();
    }
}
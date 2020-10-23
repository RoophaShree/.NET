using System;
public class Program
{
    public static void Main()
    {
        Random r = new Random();
        int genRand = r.Next(23456789,987654321);
        Console.WriteLine("Random Number = " + genRand);
    }
}
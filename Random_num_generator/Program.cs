using System;
public class Program
{
    public static void Main()
    {
        Random r = new Random();
        int genRand = r.Next(234,9876);
        Console.WriteLine("Random Number = " + genRand);
    }
}
using System;
public class Program
{
    public static void Main()
    {
        Random r = new Random();
        int genRand = r.Next(1,5);
        Console.WriteLine("Random Number = " + genRand);
    }
}
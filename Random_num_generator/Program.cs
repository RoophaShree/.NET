using System;
public class Program
{
    public static void Main()
    {
        Random r = new Random();
        double genRand = r.Next(23456789123579875643,98765432167890975432234567);
        Console.WriteLine("Random Number = " + genRand);
    }
}
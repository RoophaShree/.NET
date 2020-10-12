using System;

namespace USDtoINR
{
    class Program
    {
        static void Main(string[] args)
        {
            double usd = 0;
            double inr = 0;
            double val = 0;

            Console.WriteLine("Enter amt in USD:");
            usd = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the USD Value: ");
            val = double.Parse(Console.ReadLine());

            inr = usd * val;
            Console.WriteLine("USD " + usd +"---> INR " + inr);
        }
    }
}

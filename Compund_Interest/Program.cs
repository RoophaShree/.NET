using System;

namespace Compund_Interest
{
    class Program
    {
        class Interest
        {
            static void CalculateCompoundInterest(double amount, double roi, int years, int annualCompound)
            {
                double result = 0;
                int i = 0;

                for (i = 1; i <= years; i++)
                {
                    result = amount * Math.Pow((1 + roi / annualCompound), (annualCompound * i));
                    Console.WriteLine("Your amount after {0} Year " + ": {1}", i, result);
                }

            }
            private static void Main()
            {
                int years = 0;
                int annualCompound = 0;

                double roi = 0;
                double amount = 0;

                Console.Write("Enter the amount : ");
                amount = double.Parse(Console.ReadLine());

                Console.Write("Enter the rate of interest : ");
                roi = double.Parse(Console.ReadLine()) / 100;

                Console.Write("Enter the total number of years : ");
                years = int.Parse(Console.ReadLine());

                Console.Write("Compounding frequency : ");
                annualCompound = int.Parse(Console.ReadLine());

                CalculateCompoundInterest(amount, roi, years, annualCompound);
            }
        }
    }
    }


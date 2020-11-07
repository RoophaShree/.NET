using System;

namespace Factor
{
    class Program
    {
        static void PrintFactors(int num)
        {
            int iLoop = 0;
            Console.WriteLine("The all factors of " + num + " are :");

            for (iLoop = 1; iLoop <= num; iLoop++)
            {
                if (num % iLoop == 0)
                {
                    Console.Write(iLoop + " ");
                }
            }
        }
        static void Main(string[] args)
        {
            int num = 0;
            Console.Write("Enter an integer number: ");
            num = int.Parse(Console.ReadLine());

            PrintFactors(num);

            Console.WriteLine();
        }
    }
}
    

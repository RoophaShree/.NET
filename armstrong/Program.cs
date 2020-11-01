using System;

namespace armstrong
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int digiCount = 0;
            int number = 0;
            int tNumber = 0;
            int[] digiArray = new int[10];
            double sum = 0;

            Console.Write("Enter Number : ");
            tNumber = number = int.Parse(Console.ReadLine());

            
            while (number > 0)
            {
                digiArray[i++] = number % 10;
                number = number / 10;
                digiCount++;
            }

            for (i = 0; i < digiCount; i++)
            {
                sum += Math.Pow(digiArray[i], digiCount);
            }
            if (sum == tNumber)
                Console.WriteLine("Given Number is armstrong");
            else
                Console.WriteLine("Given Number is not armstrong");
        }
    }
}

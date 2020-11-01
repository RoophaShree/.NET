using System;

namespace armstrong
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int Count = 0;
            int number = 0;
            int tNumber = 0;
            int[] Array = new int[10];
            double sum = 0;

            Console.Write("Enter Number : ");
            tNumber = number = int.Parse(Console.ReadLine());

            
            while (number > 0)
            {
                Array[i++] = number % 10;
                number = number / 10;
                Count++;
            }

            for (i = 0; i < Count; i++)
            {
                sum += Math.Pow(Array[i], Count);
            }
            if (sum == tNumber)
                Console.WriteLine("Given Number is armstrong");
            else
                Console.WriteLine("Given Number is not armstrong");
        }
    }
}

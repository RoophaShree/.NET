using System;

namespace armstrong
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int Count = 0;
            int num = 0;
            int tNum = 0;
            int[] Array = new int[10];
            double sum = 0;

            Console.Write("Enter Number : ");
            tNum = num = int.Parse(Console.ReadLine());

            
            while (num > 0)
            {
                Array[i++] = num % 10;
                num = num / 10;
                Count++;
            }

            for (i = 0; i < Count; i++)
            {
                sum += Math.Pow(Array[i], Count);
            }
            if (sum == tNum)
                Console.WriteLine("Given Number is an armstrong");
            else
                Console.WriteLine("Given Number is not an armstrong");
        }
    }
}

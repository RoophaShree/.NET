using System;

namespace Floyd_s_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int outer = 1;
            int inner = 1;
            int num = 1;
            int rows = 0;

            Console.Write("Enter the number of rows: ");
            rows = int.Parse(Console.ReadLine());

            for (; outer <= rows; outer = outer + 1)
            {
                for (inner = 1; inner < outer + 1; inner++)
                {
                    Console.Write(num + " ");
                    num = num + 1;
                }
                Console.WriteLine();
            }
        }
    }
}

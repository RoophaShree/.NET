using System;

namespace Floyd_s_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int j = 1;
            int num = 1;
            int rows = 0;

            Console.Write("Enter the number of rows: ");
            rows = int.Parse(Console.ReadLine());

            for (; i <= rows; i = i + 1)
            {
                for (j = 1; j < i + 1; j++)
                {
                    Console.Write(num + "");
                    num = num + 1;
                }
                Console.WriteLine();
            }
        }
    }
}

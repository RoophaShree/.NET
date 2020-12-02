using System;

namespace Upper_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j = 0;

            int row = 3;
            int col = 3;

            int[ , ] Matrix = new int[row, col];

            Console.Write("Enter the elements of matrix: ");
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    Matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\n Matrix: ");
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    Console.Write(Matrix[i, j] + "\t");

                }
                Console.WriteLine();
            }

            Console.WriteLine("Upper triangular matrix: ");
            for (i = 0; i < row; i++)
            {
                Console.WriteLine();
                for (j = 0; j < col; j++)
                {
                    if (i <= j)
                        Console.Write(Matrix[i, j] + "\t");
                    else
                        Console.Write(" \t");
                }
            }

            Console.WriteLine();
        }
    }
}

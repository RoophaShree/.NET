using System;

namespace Start_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //int row = 0;
            //int col = 0;

            for (int row = 4; row >= 1; --row)
            {
                for (int col = 1; col <= 1; ++col)
                {
                    Console.WriteLine("*");
                }

                Console.WriteLine();
            }
        }
    }
}

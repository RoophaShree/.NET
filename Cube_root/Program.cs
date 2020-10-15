using System;

namespace Cube_root
{
    class Program
    {
        static int Main(string[] args)
        {
            int number = 0;
            double cubeRoot = 0;

            Console.Write("Enter the value of number: ");
            number = int.Parse(Console.ReadLine());

            cubeRoot = Math.Ceiling(Math.Pow(number, (double)1 / 3));
            Console.WriteLine("Cube Root is : " + cubeRoot);

            return 0;
        }
    }
}

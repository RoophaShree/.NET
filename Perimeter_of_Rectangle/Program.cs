using System;

namespace Perimeter_of_Rectangle
{
    class Program
    {
        public static int Main()
        {
            int length = 0;
            int width = 0;
            int perimeter = 0;

            Console.Write("Enter the value of length: ");
            length = int.Parse(Console.ReadLine());

            Console.Write("Enter the value of width: ");
            width = int.Parse(Console.ReadLine());

            perimeter = 2 * (length + width);

            Console.WriteLine("Perimeter of rectangle: " + perimeter);
            return 0;
        }
    }
}

using System;

namespace Perimeter_of_circle
{
    class Program
    {
        public static int Main()
        {
            float radius = 0F;
            float parimeter = 0F;

            Console.Write("Enter the radius: ");
            radius = float.Parse(Console.ReadLine());

            parimeter = (float)(2 * Math.PI * radius);
            Console.WriteLine("Perimeter of Circle is: " + parimeter);

            return 0;
        }
    }
}
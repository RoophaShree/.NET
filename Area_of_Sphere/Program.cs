using System;

namespace Area_of_Sphere
{
    class Program
    {
        public static float CalculateArea(float radius)
        {
            float area = 0F;

            area = (float)(4 * Math.PI * radius * radius);

            return area;
        }
        public static void Main()
        {
            float radius = 0F;
            float area = 0F;

            Console.Write("Enter the value of radius: ");
            radius = float.Parse(Console.ReadLine());

            area = CalculateArea(radius);
            Console.WriteLine("Area of Sphere: " + area);
        }
    }
}

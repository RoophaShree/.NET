using System;

namespace Area_Of_Cone
{
    class Cone
    {
        public void CalculateArea(double radius, double height)
        {
            double area = 0.0;

            area = Math.PI * radius * (radius + Math.Sqrt(radius * radius + height * height));

            //return area;
        }
        public static void Main()
        {
            double area = 0;
            double radius = 0;
            double height = 0;

            Cone C = new Cone();

            Console.Write("Enter the radius of a cone: ");
            radius = double.Parse(Console.ReadLine());

            Console.Write("Enter the height of a cone: ");
            height = double.Parse(Console.ReadLine());

            area = C.CalculateArea(radius, height);

            Console.WriteLine("Area of cone is: " + area);
        }
    }
}


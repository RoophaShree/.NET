using System;

namespace Size_of_the_area_in_sqrfeet
{
    class Program
    {
        static int calculateArea(int lengthInFeets, int widthInFeets)
        {
            return (lengthInFeets * widthInFeets);
        }
        public static void Main()
        {
            int length= 0;
            int width = 0;
            int plotArea = 0;


            Console.Write("Enter length of the plot in feets: ");
            length = int.Parse(Console.ReadLine());

            Console.Write("Enter width of room in feet:");
            width= int.Parse(Console.ReadLine());

            plotArea = calculateArea(length, width);

            Console.WriteLine("Plot area is " + plotArea + " square feet");
        }
    }
}

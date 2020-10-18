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
            int lengthInFeets = 0;
            int widthInFeets = 0;
            int plotArea = 0;


            Console.Write("Enter length of the plot in feets: ");
            lengthInFeets = int.Parse(Console.ReadLine());

            Console.Write("Enter width of room in feet:");
            widthInFeets = int.Parse(Console.ReadLine());

            plotArea = calculateArea(lengthInFeets, widthInFeets);

            Console.WriteLine("Plot area is " + plotArea + " square feet");
        }
    }
}

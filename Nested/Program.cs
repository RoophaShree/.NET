using System;
using System.IO;
using System.Text;

namespace IncludeHelp
{
    class Test
    {
        // Main Method 
        static void Main(string[] args)
        {
            //finding largest of three  numbers 
            int a;
            int b;
            int c;

            //input numbers 
            Console.Write("Enter first number : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third number : ");
            c = Convert.ToInt32(Console.ReadLine());

            //finding largest number
            int large = (a > b) ? ((a > c) ? a : c) : (b > c ? b : c);

            Console.WriteLine("Largest number is {0}", large);

            //hit ENTER to exit the program
            Console.ReadLine();
        }
    }
}
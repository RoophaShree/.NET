using System;
using System.IO;
using System.Text;

namespace IncludeHelp
{
    class Program
    {
        
        static void Main(string[] args)
        {
           
            int a;
            int b;
            int c;

            
            Console.Write("Enter first number : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third number : ");
            c = Convert.ToInt32(Console.ReadLine());

            
            int large = (a > b) ? ((a > c) ? a : c) : (b > c ? b : c);

            Console.WriteLine("Largest number is {0}", large);

            
            //Console.ReadLine();
        }
    }
}
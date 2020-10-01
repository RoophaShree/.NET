using System;

namespace Exception
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter a number: ");

            var num = int.Parse(Console.ReadLine());

            Console.WriteLine("Squre of {0} is {1}", num, num * num);
        }
    }
}

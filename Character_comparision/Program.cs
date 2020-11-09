using System;

namespace Character_comparision
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;

            
            Console.Write("Enter a character/number: ");
            a = Console.ReadLine()[0];
            Console.Write("Enter another character/number: ");
            b= Console.ReadLine()[0];

            
            if (a == b)
                Console.WriteLine("Entered inputs are the same");
            else
                Console.WriteLine("Entered outputs are not the same");

            
            Console.ReadLine();
        }
    }
}

using System;

namespace Character_comparision
{
    class Program
    {
        static void Main(string[] args)
        {
            int ch1;
            int ch2;

            
            Console.Write("Enter a character/number: ");
            ch1 = Console.ReadLine()[0];
            Console.Write("Enter another character/number: ");
            ch2 = Console.ReadLine()[0];

            
            if (ch1 == ch2)
                Console.WriteLine("Entered inputs are the same");
            else
                Console.WriteLine("Entered outputs are not the same");

            
            Console.ReadLine();
        }
    }
}

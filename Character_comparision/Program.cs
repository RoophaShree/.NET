using System;

namespace Character_comparision
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch1;
            char ch2;

            
            Console.Write("Enter a character: ");
            ch1 = Console.ReadLine();
            Console.Write("Enter another character: ");
            ch2 = Console.ReadLine()[0];

            
            if (ch1 == ch2)
                Console.WriteLine("Input characters are the same");
            else
                Console.WriteLine("Input characters are not the same");

            
            Console.ReadLine();
        }
    }
}

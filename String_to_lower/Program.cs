using System;

namespace String_to_lower
{
    class Program
    {
        static void Main(string[] args)
        {
            String str1;
            String str2;

            Console.Write("Enter string : ");
            str1 = Console.ReadLine();

            str2 = str1.ToLower();

            Console.WriteLine("Converted string is: " + str2);
        }
    }


}

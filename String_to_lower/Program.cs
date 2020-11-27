using System;

namespace String_to_lower
{
    class Program
    {
        static void Main(string[] args)
        {
            String str1;
            String str2;

            Console.Write("Enter string to be converted : ");
            str1 = Console.ReadLine();

            str2 = str1.ToLower();

            Console.WriteLine("Converted string to lower case is: " + str2);
        }
    }


}

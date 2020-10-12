using System;

namespace Convert_Char
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch;

            Console.Write("Enter a character : ");
            ch = Convert.ToChar(Console.ReadLine());

            if (ch >= 65 && ch <= 90)
            {
                Console.WriteLine("Converted Character '" + ch + "' into : '" + char.ToLower(ch) + "'");
            }
            else if (ch >= 97 && ch <= 122)
            {
                Console.WriteLine("Converted Character '" + ch + "' into : '" + char.ToUpper(ch) + "'");
            }
        }
    }
}

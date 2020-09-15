using System;

namespace Reversal_of_a_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string myStr, rev;
            int a = {1, 2, 3};
            rev = "";
            Console.WriteLine("Enter the string", myStr);
        
            int len;
            len = myStr.Length - 1;
            while (len >= 0)
            {
                rev = rev + myStr[len];
                len--;
            }
            Console.WriteLine("Reversed String is {0}", rev);
            Console.ReadLine();
        }
    }
}
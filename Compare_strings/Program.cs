using System;

namespace Compare_strings
{
    class Program
    {
        static void Main()
        {
            string str = "Helloo";

            if (str.CompareTo("Helloo") == 0)
            {
                Console.WriteLine("String is matched");
            }
            else
            {
                Console.WriteLine("String is not matched");
            }


            if (str.CompareTo("Hiii") == 0)
            {
                Console.WriteLine("String is matched");
            }
            else
            {
                Console.WriteLine("String is not matched");
            }
        }
    }
}

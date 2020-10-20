using System;

namespace String_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            string gender = "Male";

            switch (gender)
            {
                case "Male":
                    Console.WriteLine("He is male...");
                    break;
                case "Female":
                    Console.WriteLine("She is female...");
                    break;
                default:
                    Console.WriteLine("Default");
                    break;
            }

            
            Console.ReadLine();
        }
    }
}

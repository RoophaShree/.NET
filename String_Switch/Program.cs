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
                    Console.WriteLine("I am Roopa");
                    break;
                case "Female":
                    Console.WriteLine("My mom name is Jyothi...");
                    break;
                default:
                    Console.WriteLine("Default");
                    break;
            }

            
            Console.ReadLine();
        }
    }
}

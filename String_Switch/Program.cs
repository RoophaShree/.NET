using System;

namespace String_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            string gender = "Female";

            switch (gender)
            {
                case "Female":
                    Console.WriteLine("I am Roopa");
                    break;
                case "Male":
                    Console.WriteLine("My dad name is Srinivas...");
                    break;
                default:
                    Console.WriteLine("Default");
                    break;
            }

            
           // Console.ReadLine();
        }
    }
}

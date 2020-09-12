using System;

namespace CSharp_Math
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Max(5, 10));
            Console.WriteLine(Math.Min(5, 10));
            Console.WriteLine(Math.Sqrt(64));
            Console.WriteLine(Math.Abs(-4.7));
            Console.WriteLine(Math.Round(9.99));
            string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.WriteLine("The length of the txt string is: " + txt.Length);
            string txt1 = "Hello World";
            Console.WriteLine(txt1.ToUpper());  
            Console.WriteLine(txt1.ToLower());
            string firstName = "John ";
            string lastName = "Doe";
            string name = firstName + lastName;
            Console.WriteLine(name);
            string firstName1 = "John";
            string lastName1 = "Doe";
            string name1 = $"My full name is: {firstName1} {lastName1}";
            Console.WriteLine(name);
        }
    }
}

using System;
using System.Net.Cache;

namespace Exception_handling
{
    class Program
    {
        static void checkAge(int age)
        {
            if(age<18)
            {
                throw new ArithmeticException("Access Denied-You must be at least 18 years old");
            }
            else
            {
                Console.WriteLine("Access Granted-you are good to go");
            }
        }
        static void Main(string[] args)
        {
            checkAge(18);
        }
    }
}

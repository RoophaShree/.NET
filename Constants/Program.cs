using System;

namespace Constants
{
    class Program
    {
        static void Main(string[] args)
        {
            const int a = 10;   //integer constant 
            const float b = 20.23f; //float constant
            const double c = 10.23;  //double constant
            const char d = 'Y';     //character constant 
            const string e = "Hello";   //string constant

            
            Console.WriteLine("a: {0}", a);
            Console.WriteLine("b: {0}", b);
            Console.WriteLine("c: {0}", c);
            Console.WriteLine("d: {0}", d);
            Console.WriteLine("e: {0}", e);


            
            Console.ReadLine();
        }
    }
}

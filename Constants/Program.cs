using System;

namespace Constants
{
    class Program
    {
        static void Main(string[] args)
        {
            const int a = 10;   //integer  
            const float b = 20.23f; //float 
            const double c = 10.23;  //double 
            const char d = 'Y';     //character  
            const string e = "Hello";   //string 

            
            Console.WriteLine("a: {0}", a);
            Console.WriteLine("b: {0}", b);
            Console.WriteLine("c: {0}", c);
            Console.WriteLine("d: {0}", d);
            Console.WriteLine("e: {0}", e);


            
            Console.ReadLine();
        }
    }
}

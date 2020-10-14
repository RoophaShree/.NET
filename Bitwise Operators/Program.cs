using System;
using System.IO;
using System.Text;

namespace Bitwise_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 5;
            int result = 0;

            result=a & b;
            result = a | b;     
            Console.WriteLine("a | b  : {0}", result);

            result = a ^ b;     
            Console.WriteLine("a ^ b  : {0}", result);

            result = ~a;        
            Console.WriteLine("~a     : {0}", result);

            result = a << 2;   
            Console.WriteLine("a << b : {0}", result);

            result = a >> 2;    
            Console.WriteLine("a >> b : {0}", result);

            Console.ReadLine();


        }
    }
}

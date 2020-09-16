using System;

namespace method_parameter
{
    class Program
    {
        static void myMethod(string fname)
        {
            Console.WriteLine("Ryon " + fname);

        }
        static void Main(string[] args)
        {
            myMethod("Robin");
            myMethod("Pascal");
            myMethod("Ghays");
        }
    }
}

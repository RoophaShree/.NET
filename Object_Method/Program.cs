using System;

namespace Object_Method
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Class1 myObj = new Class1();
            Console.WriteLine(myObj.color);
            myObj.carSpeed();
        }
    }
}
